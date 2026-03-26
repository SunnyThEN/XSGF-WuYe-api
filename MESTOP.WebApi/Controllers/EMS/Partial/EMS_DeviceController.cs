/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("EMS_Device",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using EMS.IServices;
using EMS.Services;

namespace EMS.Controllers
{
    public partial class EMS_DeviceController
    {
        private readonly IEMS_DeviceService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public EMS_DeviceController(
            IEMS_DeviceService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("getSelectorDevice")]
        public IActionResult getSelectorDevice([FromBody] PageDataOptions options)
        {
            //1.可以直接调用框架的GetPageData查询
            PageGridData<EMS_Device> data = EMS_DeviceService.Instance.GetPageData(options);
            return JsonNormal(data);
        }
    }
}
