/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("CSR_JD_OtherWebApi",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using CSR_JD.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Enums;
using MESTOP.Core.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace CSR_JD.Controllers
{
    public partial class CSR_JD_OtherWebApiController
    {
        private readonly ICSR_JD_OtherWebApiService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public CSR_JD_OtherWebApiController(
            ICSR_JD_OtherWebApiService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("SyncData")]
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<IActionResult> SyncData(int SyncType)
        {
            var SyncData = 0;
            try
            {
                SyncData = await Service.SyncData(SyncType);
                if (SyncData <= 0) return Json(WebResponseContent.Instance.Error("同步了0条数据"));
            }
            catch (Exception ex)
            {
                return Json(WebResponseContent.Instance.Error(ex.Message.ToString()));
            }

            return Json(WebResponseContent.Instance.OK("同步更新了" + SyncData + "条数据"));
            //return Json(WebResponseContent.Instance.OK("同步更新了"+ SyncData+"条数据"));
        }



        [HttpPost, Route("PRD_PPBOMPush")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_PPBOMPush(List<string> FBILLNO,string FentryIds)
        {

            await Service.PRD_PPBOMPush(FBILLNO, FentryIds);
            return Json(WebResponseContent.Instance.OK());
  
        }

        [HttpPost, Route("PRD_MOExcuteOperation")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_MOExcuteOperation(List<string> WorklNO)
        {

            await Service.PRD_MOExcuteOperation(WorklNO);
            return Json(WebResponseContent.Instance.OK());
          
        }


       

        [HttpPost, Route("PRDINSTOCK")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRDINSTOCK(int FID)
        {

            //await Service.PRDINSTOCK(FID);
            return Json(WebResponseContent.Instance.OK());

        }


        [HttpPost, Route("PRD_MOPush")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_MOPush(List<string> WorklNO)
        {
           
            await Service.PRD_MOPush(WorklNO);
            return Json(WebResponseContent.Instance.OK());
           
        }

        [HttpPost, Route("PRD_INSTOCKSubmit")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_INSTOCKSubmit(List<string> MtrlNO)
        {

            await Service.PRD_INSTOCKSubmit(MtrlNO);
            return Json(WebResponseContent.Instance.OK());

        }

        [HttpPost, Route("PRD_INSTOCKAudit")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_INSTOCKAudit(List<string> MtrlNO)
        {

            await Service.PRD_INSTOCKAudit(MtrlNO);
            return Json(WebResponseContent.Instance.OK());

        }

        [HttpPost, Route("PRD_PPBOMPushRETURNMTRL")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_PPBOMPushRETURNMTRL(string FentryIds)
        {

            await Service.PRD_PPBOMPushRETURNMTRL(FentryIds);
            return Json(WebResponseContent.Instance.OK());

        }

        [HttpPost, Route("PRD_ReturnMtrlSubmit")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_ReturnMtrlSubmit(string MtrlNO)
        {

            await Service.PRD_ReturnMtrlSubmit(MtrlNO);
            return Json(WebResponseContent.Instance.OK());

        }

        [HttpPost, Route("PRD_ReturnMtrlAudit")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_ReturnMtrlAudit(string MtrlNO)
        {

            await Service.PRD_ReturnMtrlAudit(MtrlNO);
            return Json(WebResponseContent.Instance.OK());

        }

        [HttpPost, Route("PRD_ReturnMtrlDelete")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> PRD_ReturnMtrlDelete(string FID)
        {

            await Service.PRD_ReturnMtrlDelete(FID);
            return Json(WebResponseContent.Instance.OK());

        }
    }
}
