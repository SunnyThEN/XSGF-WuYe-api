/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_WorkOrder",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using Microsoft.AspNetCore.Authorization;
using MESTOP.Core.Filters;
using Autofac.Core;
using MESTOP.Core.Utilities;
using PPM.Repositories;
using WOC.Repositories;
using System.Linq;
using MESTOP.Core.Enums;
using MESTOP.Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace WOC.Controllers
{
    public partial class WOC_WorkOrderController
    {
        private readonly IWOC_WorkOrderService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_WorkOrderController(
            IWOC_WorkOrderService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("Add")]
        [ApiActionPermission]
       

        public override ActionResult Add(SaveModel saveDataModel)
        {
            //var MainWF= PPM_WorkFlowRepository.Instance.Find(x=>x.ProcessFlowCode==saveDataModel.MainProcessFlowCode);
            return base.Add(saveDataModel);
        }



        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return Getmes_workordermainRootData(loadData);
            //return GetTreeTableRootData(loadData).Result;

        }


        [HttpPost, Route("Getmes_workordermainRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult Getmes_workordermainRootData([FromBody] PageDataOptions options)
        {
            var roleRepository = WOC_WorkOrderRepository.Instance.FindAsIQueryable(x => 1 == 1);

            //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置
            var query = WOC_WorkOrderRepository.Instance.FindAsIQueryable(x => x.Orderlevel==1);
            var rows = query.TakeOrderByPage(options.Page, options.Rows)
                .OrderByDescending(x => x.CreateDate).Select(s => new
                {
                    s.MWOId,
                    s.WorkOrderCode,
                    s.ProductCode,
                    s.ProductName,
                    s.ProductShortCode,
           
                    s.MainProcessFlowCode,
                    s.BOMVersion,
                    s.ProcessFlowCode,
                    s.WORequiredQty,
                    s.DispatchedQty,
                    s.UndispatchedQty,
                    s.OutPutOKWIPQty,
                    s.OutPutNGWIPQty,
                    s.UnOutPutWIPQty,
                    s.PlanEndTime,
                    s.PlanStartTime,
                    s.WOStatus,
                    s.CreateDate,
                    s.Creator,
                    s.Modifier,
                    s.ModifyDate,
                    s.ParentId,
                    s.Orderlevel,
                    s.OrgCode,
                    children = roleRepository.Where(x => x.ParentId == s.MWOId && x.Orderlevel == 4).ToList()
                    //hasChildren = roleRepository.Any(x => x.ParentId == s.MWOId)
                }).ToList();
            return JsonNormal(new { total = query.Count(), rows });
        }
        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> GetChildrenData(int MWOId)
        {


            var roleRepository = WOC_WorkOrderRepository.Instance.FindAsIQueryable(x => 1 == 1);
            var rows = await roleRepository.Where(x => x.ParentId == MWOId && x.Orderlevel == 4)
                .Select(s => new
                {
                    s.MWOId,
                    s.WorkOrderCode,
                    s.ProductCode,
                    s.ProductName,
                    s.ProductShortCode,
              
                    s.MainProcessFlowCode,
                    s.BOMVersion,
                    s.ProcessFlowCode,
                    s.WORequiredQty,
                    s.DispatchedQty,
                    s.UndispatchedQty,
                    s.OutPutOKWIPQty,
                    s.OutPutNGWIPQty,
                    s.UnOutPutWIPQty,
                    s.PlanEndTime,
                    s.PlanStartTime,
                    s.WOStatus,
                    s.CreateDate,
                    s.Creator,
                    s.Modifier,
                    s.ModifyDate,
                    s.ParentId,
                    s.Orderlevel,
                    s.OrgCode,
                    hasChildren = roleRepository.Any(x => x.ParentId == s.MWOId)
                }).ToListAsync();
            return JsonNormal(new { rows });
        }
        WebResponseContent WebResponse = new WebResponseContent();


        [HttpPost, Route("WOsplit")]
        [ApiActionPermission]
        [AllowAnonymous]
   
        public   ActionResult WOsplit([FromBody] List<Search_PPM_WorkFlow> workflow,string ParentWorkOrderCode)
        {
            var wo = WOC_WorkOrderRepository.Instance.Find(x => x.WorkOrderCode == ParentWorkOrderCode).FirstOrDefault();
            var parentIds = wo.MWOId;

            WOC_WorkOrder wkorder = wo;

            foreach (var wf in workflow)
            {   try {
                    wkorder.ParentId = parentIds;
                    wkorder.MWOId = 0;
                    wkorder.WorkOrderCode = ParentWorkOrderCode + wf.ProcessFlowCode;
                    wkorder.ProcessFlowCode = wf.ProcessFlowCode;
                    wkorder.ProductName = wf.MaterialName;
                    wkorder.ProductCode = wf.MaterialCode;
                    wkorder.ProductShortCode = wf.MaterialShortNo;
                    wkorder.Orderlevel = 4;
                  
                WOC_WorkOrderRepository.Instance.Add(wkorder, true);
                 }   
                    catch(Exception e)
                {
                    return Json(WebResponseContent.Instance.Error(e.Message));
 
                    }


          
            }
            //addwo = wo;
            return Json(WebResponseContent.Instance.OK());
           
            //var MainWF= PPM_WorkFlowRepository.Instance.Find(x=>x.ProcessFlowCode==saveDataModel.MainProcessFlowCode);
            //return null;
        }

    }




}
