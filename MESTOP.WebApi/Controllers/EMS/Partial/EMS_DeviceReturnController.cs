/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("EMS_DeviceReturn",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using EMS.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Enums;
using EMS.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EMS.Controllers
{
    public partial class EMS_DeviceReturnController
    {
        private readonly IEMS_DeviceReturnService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEMS_DeviceReturnListRepository _deviceReturnListRepository;

        [ActivatorUtilitiesConstructor]
        public EMS_DeviceReturnController(
            IEMS_DeviceReturnService service,
            IHttpContextAccessor httpContextAccessor,
            IEMS_DeviceReturnListRepository deviceReturnListRepository
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _deviceReturnListRepository = deviceReturnListRepository;
        }
        /// <summary>
        /// 获取领用单工装夹具明细列表
        /// </summary>
        /// <param name="ToolsReturnId">工装领用主键</param>
        /// <returns></returns>
        [Route("getDetailRows"), HttpGet]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetDetailRows(int DeviceReturnId)
        {
            var rows = await _deviceReturnListRepository.FindAsIQueryable(x => x.DeviceReturnId == DeviceReturnId)
                  .ToListAsync();
            return JsonNormal(rows);
        }
    }
}
