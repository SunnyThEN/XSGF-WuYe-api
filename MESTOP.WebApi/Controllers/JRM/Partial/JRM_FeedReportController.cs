/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_FeedReport",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using MESTOP.Core.Utilities;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using Autofac.Core;

namespace JRM.Controllers
{
    public partial class JRM_FeedReportController
    {
        private readonly IJRM_FeedReportService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_FeedReportController(
            IJRM_FeedReportService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        [Route("addAgain"),HttpPost]
        [ApiActionPermission]
        [AllowAnonymous]
        public WebResponseContent addAgain([FromBody] SaveModel saveModel)
        {
            return _service.addAgain(saveModel);
        }
    }
}
