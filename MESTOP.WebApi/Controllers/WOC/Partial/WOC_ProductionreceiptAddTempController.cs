/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_ProductionreceiptAddTemp",Enums.ActionPermissionOptions.Search)]
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
using Microsoft.AspNetCore.Authorization;
using MESTOP.Core.Utilities;
using WOC.Repositories;

namespace WOC.Controllers
{
    public partial class WOC_ProductionreceiptAddTempController
    {
        private readonly IWOC_ProductionreceiptAddTempService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_ProductionreceiptAddTempController(
            IWOC_ProductionreceiptAddTempService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("InWarehouse")]
        [ApiActionPermission]
     

        public  ActionResult  InWarehouse([FromBody] WOC_ProductionreceiptAddTemp AddTemp)
        {
            return Json(Service.InWare(AddTemp));

          //WebResponseContent.Instance.OK());
        }
        [HttpPost, Route("isSubmit")]
        [ApiActionPermission] 
        public ActionResult isSubmit([FromBody] WOC_ProductionreceiptAddTemp AddTemp)
        {
            return Json(Service.isInSubmit(AddTemp));

            //WebResponseContent.Instance.OK());
        }
        [HttpPost, Route("isAudit")]
        [ApiActionPermission]


        public ActionResult isAudit([FromBody] WOC_ProductionreceiptAddTemp AddTemp)
        {
            return Json(Service.isInAudit(AddTemp));

            //WebResponseContent.Instance.OK());
        }
    }
}
