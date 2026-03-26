/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_WorkReport",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using WOC.Repositories;
using System.Linq;
using MESTOP.Core.BaseProvider;
using Autofac.Core;
using MESTOP.Core.BaseInterface;
using JRM.Repositories;
using ORG.Repositories;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;

namespace JRM.Controllers
{
    public partial class JRM_WorkReportController
    {
        private readonly IJRM_WorkReportService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_WorkReportController(
            IJRM_WorkReportService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

 

 


    }
}
