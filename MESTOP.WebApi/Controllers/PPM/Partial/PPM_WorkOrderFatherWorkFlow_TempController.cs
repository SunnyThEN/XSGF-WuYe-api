/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PPM_WorkOrderFatherWorkFlow_Temp",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PPM.IServices;

namespace PPM.Controllers
{
    public partial class PPM_WorkOrderFatherWorkFlow_TempController
    {
        private readonly IPPM_WorkOrderFatherWorkFlow_TempService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PPM_WorkOrderFatherWorkFlow_TempController(
            IPPM_WorkOrderFatherWorkFlow_TempService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
