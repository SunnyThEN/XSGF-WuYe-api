/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("FCM_Plan",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using FCM.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Enums;

namespace FCM.Controllers
{
    public partial class FCM_PlanController
    {
        private readonly IFCM_PlanService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public FCM_PlanController(
            IFCM_PlanService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 获取table1的数据
        /// </summary>
        /// <param name="loadData"></param>
        /// <returns></returns>
        [Route("getTable1Data"), HttpPost, ApiActionPermission("FCM_Plan", ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetTable1Data([FromBody] PageDataOptions loadData)
        {
            return JsonNormal(await Service.GetTable1Data(loadData));
        }

        /// <summary>
        /// 获取table1的数据
        /// </summary>
        /// <param name="loadData"></param>
        /// <returns></returns>
        [Route("getTable2Data"), HttpPost, ApiActionPermission("FCM_Plan", ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetTable2Data([FromBody] PageDataOptions loadData)
        {
            return JsonNormal(await Service.GetTable2Data(loadData));
        }
    }
}
