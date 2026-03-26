/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Tree_MMS_BOMDetailed",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using MMS.IServices;
using MESTOP.Core.Utilities;

namespace MMS.Controllers
{
    public partial class Tree_MMS_BOMDetailedController
    {
        private readonly ITree_MMS_BOMDetailedService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Tree_MMS_BOMDetailedController(
            ITree_MMS_BOMDetailedService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("GetTreeNodes")]
        public async Task<IActionResult> GetTreeNodes()
        {

            var data = await Service.GetAllChildren();

            return Json(WebResponseContent.Instance.OK(null, data));
        }

    }
}
