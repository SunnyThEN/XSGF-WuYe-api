/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_Dispatch_WorkFlow",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.Extensions;
using WOC.Repositories;
using MESTOP.Core.Utilities;
using System.Linq;

namespace WOC.Controllers
{
    public partial class WOC_Dispatch_WorkFlowController
    {
        private readonly IWOC_Dispatch_WorkFlowService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_Dispatch_WorkFlowController(
            IWOC_Dispatch_WorkFlowService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

      
    }
}
