/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_WorkOrderdispatch",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Enums;
using WOC.Repositories;
using MESTOP.Core.Extensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WOC.Controllers
{
    public partial class WOC_WorkOrderdispatchController
    {
        private readonly IWOC_WorkOrderdispatchService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_WorkOrderdispatchController(
            IWOC_WorkOrderdispatchService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
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

            var roleRepository = WOC_WorkOrderdispatchRepository.Instance.FindAsIQueryable(x => 1 == 1);

            //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置
            var query = WOC_WorkOrderdispatchRepository.Instance.FindAsIQueryable(x => x.Orderlevel == 2);


            var rows = query.TakeOrderByPage(options.Page, options.Rows)
            .OrderBy(x => x.WorkOrderCode)
            .Select(s => new
            {
                s.MWOId,
                s.WorkOrderCode,
                s.ProductCode,
                s.ProductName,
                s.ProductShortCode,
         
                s.BOMVersion,
                s.ProcessFlowCode,
                s.ProcessFlowName,
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
                s.shipmentReferCode,
                s.shipmentReferStatus,
                s.ParentWorkOrderCode,
                s.MainProcessFlowCode,
                children = roleRepository.Where(x => x.ParentId == s.MWOId).ToList()
                //hasChildren = roleRepository.Any(x => x.ParentId == s.MWOId)
            }).ToList();





            //var rowsf = query.TakeOrderByPage(options.Page, options.Rows).OrderBy(x => x.WorkOrderCode).ToList();

            //orderdispatch.
            //rows.Add(hasChildren = roleRepository.Any(x => x.ParentId == s.MWOId));



            return JsonNormal(new { total = query.Count(), rows });
        }
        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> GetChildrenData(int MWOId)
        {


            var roleRepository = WOC_WorkOrderdispatchRepository.Instance.FindAsIQueryable(x => 1 == 1);
            var rows = await roleRepository.Where(x => x.ParentId == MWOId)
                .Select(s => new
                {
                    s.MWOId,
                    s.WorkOrderCode,
                    s.ProductCode,
                    s.ProductName,
                    s.ProductShortCode,
             
                    s.BOMVersion,
                    s.ProcessFlowCode,
                    s.ProcessFlowName,
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
                    s.shipmentReferCode,
                    s.shipmentReferStatus,
                    s.ParentWorkOrderCode,
                    s.MainProcessFlowCode,
                    //children = roleRepository.Where(x => x.ParentId == s.MWOId).ToList()
                    hasChildren = roleRepository.Any(x => x.ParentId == s.MWOId)
                }).ToListAsync();
            return JsonNormal(new { rows });
        }
    }
}
