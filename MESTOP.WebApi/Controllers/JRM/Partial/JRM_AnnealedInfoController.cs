/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_AnnealedInfo",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using MESTOP.Core.Filters;
using JRM.Services;

namespace JRM.Controllers
{
    public partial class JRM_AnnealedInfoController
    {
        private readonly IJRM_AnnealedInfoService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_AnnealedInfoController(
            IJRM_AnnealedInfoService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }



        [HttpPost, Route("UpdateResual")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        public async Task<object> UpdateResual([FromBody] JRM_AnnealedInfo jrm)
        {

           return   JRM_AnnealedInfoService.Instance.UpdateResual(jrm);

        }
            
    }
}
