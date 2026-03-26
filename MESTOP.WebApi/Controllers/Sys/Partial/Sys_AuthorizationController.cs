/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Sys_Authorization",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using MESTOP.Sys.IServices;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;

namespace MESTOP.Sys.Controllers
{
    public partial class Sys_AuthorizationController
    {
        private readonly ISys_AuthorizationService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Sys_AuthorizationController(
            ISys_AuthorizationService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("getCode")]
        [ApiActionPermission]
        [AllowAnonymous]
        public string getCode(string SYSstr, string MACcode)
        {
            return _service.AuthorizationCode(SYSstr, MACcode);


        }
    }
}
