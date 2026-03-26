/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_Dispatch_WorkOrder",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.Utilities;
using WOC.Repositories;
using JRM.Repositories;

namespace WOC.Controllers
{
    public partial class WOC_Dispatch_WorkOrderController
    {
        private readonly IWOC_Dispatch_WorkOrderService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_Dispatch_WorkOrderController(
            IWOC_Dispatch_WorkOrderService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("updateWOStatus")]
        [ApiActionPermission]
        public ActionResult updateWOStatus([FromBody] WOC_Dispatch_WorkOrder wOC_WorkOrder)
        {
        
                var wocchild = WOC_Dispatch_WorkOrderRepository.Instance.FindFirst(x => x.MWOId == wOC_WorkOrder.MWOId);
                if (wocchild is not null)
                {
         
                    var  workfloworder = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.MWOId == wOC_WorkOrder.MWOId);
                int wostatus = 0;
               
                foreach ( var wf in workfloworder )  
                {
                    if (wf.ProcessStatus == "2")
                    {
                        wostatus = 1;
                        return JsonNormal(WebResponseContent.Instance.Error(wf.ProcessName+"开工中不能终止计划"));
                    }
                    if (wf.ProcessStatus == "6")
                    {
                        var feedsub=  JRM_FeedReport_SubRepository.Instance.FindFirst(x=>x.NEWFLOT==wf.NEWFLOT);
                        if(feedsub is not null)
                        {
                            wostatus = 1;
                            return JsonNormal(WebResponseContent.Instance.Error("退火中不能终止计划"));
                        } 

                    }
                }
                if(  wostatus == 0) 
                { 
                    foreach (var flow in workfloworder)
                    {
                        if (flow.ProcessStatus == "1")
                        {
                            flow.ProcessStatus = "8";
                            WOC_Dispatch_WorkFlowRepository.Instance.Update(flow, true);
                        }
                        if (flow.ProcessStatus == "6")
                        {
                            flow.ProcessStatus = "8";
                            WOC_Dispatch_WorkFlowRepository.Instance.Update(flow, true); 
                        }
                    }
                  

                }

               
                wocchild.WOStatus = wOC_WorkOrder.WOStatus.ToString();
                WOC_Dispatch_WorkOrderRepository.Instance.Update(wocchild, true);

            }
                 
            return JsonNormal(WebResponseContent.Instance.OK("递交成功"));
        }
    }
}
