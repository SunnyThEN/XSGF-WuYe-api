/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("QCM_AbnormalList",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using QCM.IServices;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using MESTOP.Core.Utilities;
using WOC.Repositories;
using MESTOP.Core.Extensions;
using System.Linq;
using QCM.Repositories;

namespace QCM.Controllers
{
    public partial class QCM_AbnormalListController
    {
        private readonly IQCM_AbnormalListService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public QCM_AbnormalListController(
            IQCM_AbnormalListService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }



        [HttpPost, Route("Revokejob")]
        [ApiActionPermission(ActionPermissionOptions.Search)]

        public ActionResult Revokejob(string AID)
        {
            try
            {
                var qcmab=  QCM_AbnormalListRepository.Instance.FindFirst(x => x.AbnId == AID.ToGuid());
                
                if (qcmab != null) 
                {
                var qcm = WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.PID == qcmab.PID);
                if (qcm != null)
                {
                        var product = WOC_Dispatch_WorkOrderRepository.Instance.FindFirst(x => x.MWOId == qcm.MWOId);

                        if (product != null)

                        {
                            qcm.ProductCode = product.ProductCode;
                            qcm.ProductName = product.ProductName;

                        }
                        qcm.ProcessStatus = "2";

                var  upd=    WOC_Dispatch_WorkFlowRepository.Instance.Update(qcm, true);
                        if(upd >0)
                        {
                            QCM_AbnormalListRepository.Instance.Delete(qcmab, true);

                        }


                    if (qcm.ParentId is not null)
                    {

                        var qcmlist = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.ParentId == qcm.ParentId);
                        if (qcmlist.Count > 0)
                        {

                            var qcmrplist = qcmlist.Where(x => x.ProcessStatus == "2").ToList();
                            //如果所有自卷都填报状态 开启母卷 填报状态
                            if (qcmlist.Count == qcmrplist.Count)
                            {
                                var qcmfather = WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.PID == qcm.ParentId);
                                if (qcmfather is not null)
                                {

                                    qcmfather.ProcessStatus = "2";

                                    WOC_Dispatch_WorkFlowRepository.Instance.Update(qcmfather, true);
                                    return Json(WebResponseContent.Instance.OK("母卷" + qcmfather.NEWFLOT + "可以重新填报"));
                                }

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
