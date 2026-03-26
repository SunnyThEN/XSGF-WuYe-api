/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("QCM_Sampling",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using QCM.IServices;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;

namespace QCM.Controllers
{
    public partial class QCM_SamplingController
    {
        private readonly IQCM_SamplingService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public QCM_SamplingController(
            IQCM_SamplingService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("GetSamples")]
        [ApiActionPermission]
        [AllowAnonymous]
        public object GetSamples(int SIPType, string materialCode, string orderCode)
        {
            return Service.GetSamples(SIPType, materialCode, orderCode);
        }


    }
}
