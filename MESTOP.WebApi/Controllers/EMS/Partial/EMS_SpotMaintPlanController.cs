/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("EMS_SpotMaintPlan",Enums.ActionPermissionOptions.Search)]
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
using EMS.Services;

namespace EMS.Controllers
{
    public partial class EMS_SpotMaintPlanController
    {
        private readonly IEMS_SpotMaintPlanService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public EMS_SpotMaintPlanController(
            IEMS_SpotMaintPlanService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        //ApiActionPermission("EMS_SpotMaintPlan", ActionPermissionOptions.Search)设置查询表的权限，如果不填写只要登陆了都可以查询
        /// <summary>
        /// 获取table1的数据
        /// </summary>
        /// <param name="loadData"></param>
        /// <returns></returns>
        [Route("getTable1Data"), HttpPost, ApiActionPermission("EMS_SpotMaintPlan", ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetTable1Data([FromBody] PageDataOptions loadData)
        {
            return JsonNormal(await Service.GetTable1Data(loadData));
        }

        /// <summary>
        /// 获取table1的数据
        /// </summary>
        /// <param name="loadData"></param>
        /// <returns></returns>
        [Route("getTable2Data"), HttpPost, ApiActionPermission("EMS_SpotMaintPlan", ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetTable2Data([FromBody] PageDataOptions loadData)
        {
            return JsonNormal(await Service.GetTable2Data(loadData));
        }
        [HttpPost, Route("getSelectorPlan")]
        public IActionResult getSelectorPlan([FromBody] PageDataOptions options)
        {
            //1.可以直接调用框架的GetPageData查询
            PageGridData<EMS_SpotMaintPlan> data = EMS_SpotMaintPlanService.Instance.GetPageData(options);
            return JsonNormal(data);
        }
    }
}
