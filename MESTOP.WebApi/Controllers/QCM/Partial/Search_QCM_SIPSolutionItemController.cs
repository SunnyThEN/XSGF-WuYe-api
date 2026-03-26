/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Search_QCM_SIPSolutionItem",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using QCM.IServices;

namespace QCM.Controllers
{
    public partial class Search_QCM_SIPSolutionItemController
    {
        private readonly ISearch_QCM_SIPSolutionItemService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Search_QCM_SIPSolutionItemController(
            ISearch_QCM_SIPSolutionItemService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
