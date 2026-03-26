/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("T_PRD_RETURNMTRLENTRY",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using CSR_JD.IServices;

namespace CSR_JD.Controllers
{
    public partial class T_PRD_RETURNMTRLENTRYController
    {
        private readonly IT_PRD_RETURNMTRLENTRYService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public T_PRD_RETURNMTRLENTRYController(
            IT_PRD_RETURNMTRLENTRYService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
