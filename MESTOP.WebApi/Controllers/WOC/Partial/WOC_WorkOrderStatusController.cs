/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_WorkOrderStatus",Enums.ActionPermissionOptions.Search)]
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
using Microsoft.AspNetCore.Authorization;
 
using WOC.Repositories;
using MESTOP.Core.Extensions;
using MESTOP.Core.Utilities;
using Microsoft.Extensions.Hosting;

namespace WOC.Controllers
{
    public partial class WOC_WorkOrderStatusController
    {
        private readonly IWOC_WorkOrderStatusService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_WorkOrderStatusController(
            IWOC_WorkOrderStatusService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

 

    }
}
