/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("QCM_FinalIpc",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using QCM.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Enums;
using QCM.Repositories;
using MESTOP.Core.Utilities;
using System.Linq;
using MESTOP.Core.Extensions;
using WOC.Repositories;

namespace QCM.Controllers
{
    public partial class QCM_FinalIpcController
    {
        private readonly IQCM_FinalIpcService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public QCM_FinalIpcController(
            IQCM_FinalIpcService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("Revokejob")]
        [ApiActionPermission(ActionPermissionOptions.Search)]

        public ActionResult   Revokejob(string  PID)
        {
        try { 
                var qcm= WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.PID == PID.ToGuid());
                if (qcm != null)
                {
                    var qcmchildlist = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.ParentId == qcm.PID&&(x.ProcessName.Contains("分切")|| x.ProcessName.Contains("分剪")));
                    if (qcmchildlist.Count>0)
                    {
                       var inaudit= qcmchildlist.FindAll(x => x.isInAudit == 1);
                        if (inaudit.Count>0)
                        {
                            return Json(WebResponseContent.Instance.Error("子卷已入库,不允许母卷撤销"));

                        }

                    }

                  var product=  WOC_Dispatch_WorkOrderRepository.Instance.FindFirst(x => x.MWOId == qcm.MWOId);

                    if (product != null)
                    
                    {
                        qcm.ProductCode = product.ProductCode;
                        qcm.ProductName = product.ProductName;
                     
                    }
                    qcm.ProcessStatus = "2";

                        WOC_Dispatch_WorkFlowRepository.Instance.Update(qcm,true);

                      if (qcm.ParentId is  not null) {
                    
                       var qcmlist = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.ParentId == qcm.ParentId);
                        if (qcmlist.Count>0) {

                            var qcmrplist = qcmlist.Where(x => x.ProcessStatus == "2").ToList();
                            //如果所有自卷都填报状态 开启母卷 填报状态
                            if (qcmlist.Count == qcmrplist.Count)
                            {
                                var qcmfather = WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.PID == qcm.ParentId);
                                if(qcmfather is not null)
                                {

                                    qcmfather.ProcessStatus = "2";

                                    WOC_Dispatch_WorkFlowRepository.Instance.Update(qcmfather, true);
                                    return Json(WebResponseContent.Instance.OK("母卷"+qcmfather.NEWFLOT+"可以重新填报"));
                                }

                            }

                        
                        }





                    }

                }
            }
            catch (Exception e)
            {
                return Json(WebResponseContent.Instance.Error(e.Message));

            }

            return Json(WebResponseContent.Instance.OK());

        }


        }
}
