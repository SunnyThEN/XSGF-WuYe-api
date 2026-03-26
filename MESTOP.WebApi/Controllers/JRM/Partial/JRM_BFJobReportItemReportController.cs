/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_BFJobReportItemReport",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;

namespace JRM.Controllers
{
    public partial class JRM_BFJobReportItemReportController
    {
        private readonly IJRM_BFJobReportItemReportService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_BFJobReportItemReportController(
            IJRM_BFJobReportItemReportService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
