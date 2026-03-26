/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("EMS_EquipmentSpotCheckSoluton",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using EMS.IServices;

namespace EMS.Controllers
{
    public partial class EMS_EquipmentSpotCheckSolutonController
    {
        private readonly IEMS_EquipmentSpotCheckSolutonService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public EMS_EquipmentSpotCheckSolutonController(
            IEMS_EquipmentSpotCheckSolutonService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
