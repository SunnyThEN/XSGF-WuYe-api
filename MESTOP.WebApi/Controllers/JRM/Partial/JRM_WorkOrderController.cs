/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_WorkOrder",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using JRM.Repositories;
using MESTOP.Core.Enums;
using MESTOP.Core.Extensions;
using MESTOP.Core.Filters;
using MESTOP.Core.Utilities;
using System.Linq;
using WOC.Repositories;

namespace JRM.Controllers
{
    public partial class JRM_WorkOrderController
    {
        private readonly IJRM_WorkOrderService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_WorkOrderController(
            IJRM_WorkOrderService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost, Route("JrmOrder")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult<JRM_WorkOrder> JrmOrder(string jrmFLOT)
        {


            if (!jrmFLOT.IsNullOrEmpty())
            {
                var jrmRepository = JRM_WorkOrderRepository.Instance.Find(x => x.NEWFLOT == jrmFLOT && "123".Contains(x.ProcessStatus)).MinBy(x => x.Sort);
                if (jrmRepository != null)
                {


                    return JsonNormal(WebResponseContent.Instance.OK(null,jrmRepository));
                }
                else
                {
                    return JsonNormal(WebResponseContent.Instance.Error("未找到对应的工单"));
                }
            }
            else
            { return JsonNormal(WebResponseContent.Instance.Error("必须输入读取条件")); }



        }



        [HttpPost, Route("Jrmcomplete")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult<WOC_Dispatch_WorkFlow> Jrmcomplete(string Pid)
        {


           
                var jrmRepository = WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.PID == Pid.GetGuid());
                if (jrmRepository != null)
                {
                jrmRepository.RealEndTime = DateTime.Now;

                var EndTime = jrmRepository.RealEndTime.Value.AddMinutes(-5);
                var StartTime = jrmRepository.RealStartTime;

                var s = jrmRepository.RealEndTime - jrmRepository.RealStartTime;
                if (EndTime < StartTime)
                {

                    return JsonNormal(WebResponseContent.Instance.Error("记录完工时间必须5分钟以上"));
                }
                else
                {


                    

                    jrmRepository.workhour=s.Value.TotalMinutes.ToString(); 
                      WOC_Dispatch_WorkFlowRepository.Instance.Update(jrmRepository, true);

                }
                 
               

                return JsonNormal(WebResponseContent.Instance.OK("该工序完工时间已记录"));
            }
            return JsonNormal(WebResponseContent.Instance.Error("记录完工时间失败"));
        }

    
     

    }
}
