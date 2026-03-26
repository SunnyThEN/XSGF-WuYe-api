/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("SYS_Codingrules",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using SYS.IServices;

namespace SYS.Controllers
{
    public partial class SYS_CodingrulesController
    {
        private readonly ISYS_CodingrulesService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public SYS_CodingrulesController(
            ISYS_CodingrulesService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpGet, Route("GetSYS_Codingrules")]
        public IActionResult GetSYS_Codingrules(string TBActionType, string position, string parameter,string inputstr)
        {


            string MES_Code = _service.GetSYS_Codingrules(TBActionType, position, parameter, inputstr);
            return JsonNormal(MES_Code);

        }

    }
}
