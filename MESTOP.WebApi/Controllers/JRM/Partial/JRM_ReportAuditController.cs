/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_ReportAudit",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.Utilities;
using WOC.Repositories;
using JRM.Repositories;
using MESTOP.Core.ManageUser;

namespace JRM.Controllers
{
    public partial class JRM_ReportAuditController
    {
        private readonly IJRM_ReportAuditService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_ReportAuditController(
            IJRM_ReportAuditService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("ReportAudit")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        public async Task<object> ReportAudit([FromBody] List<JRM_ReportAudit> row)
        {

            try
            { 
            foreach (var r in row) {
                r.ReportAudit = 1;
                r.ReportReviewer = UserContext.Current.UserTrueName;
                var Recpipt = JRM_ReportAuditRepository.Instance.Update(r,true);
            }

            }

            catch (Exception ex)
            {
                return WebResponseContent.Instance.Error(ex.Message);
            }
            return WebResponseContent.Instance.OK();

        }


    }
    }
