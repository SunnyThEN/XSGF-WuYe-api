/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("EMS_DeviceReceive",Enums.ActionPermissionOptions.Search)]
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
using EMS.Repositories;
using EMS.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EMS.Controllers
{
    public partial class EMS_DeviceReceiveController
    {
        private readonly IEMS_DeviceReceiveService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEMS_DeviceReceiveListRepository _deviceReceiveListRepository;

        [ActivatorUtilitiesConstructor]
        public EMS_DeviceReceiveController(
            IEMS_DeviceReceiveService service,
            IHttpContextAccessor httpContextAccessor,
            IEMS_DeviceReceiveListRepository deviceReceiveListRepository
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _deviceReceiveListRepository = deviceReceiveListRepository;
        }

        /// <summary>
        /// 获取领用单工装夹具明细列表
        /// </summary>
        /// <param name="DeviceReceiveId">工装领用主键</param>
        /// <returns></returns>
        [Route("getDetailRows"), HttpGet]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetDetailRows(int DeviceReceiveId)
        {
            var rows = await _deviceReceiveListRepository.FindAsIQueryable(x => x.DeviceReceiveId == DeviceReceiveId)
                  .ToListAsync();
            return JsonNormal(rows);
        }
    }
}
