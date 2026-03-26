/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_WorkFlow",Enums.ActionPermissionOptions.Search)]
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

namespace JRM.Controllers
{
    public partial class JRM_WorkFlowController
    {
        private readonly IJRM_WorkFlowService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_WorkFlowController(
            IJRM_WorkFlowService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

    }
}
