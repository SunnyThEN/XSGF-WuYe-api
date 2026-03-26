/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ReportAuditController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ReportAudit")]
    [PermissionTable(Name = "JRM_ReportAudit")]
    public partial class JRM_ReportAuditController : ApiBaseController<IJRM_ReportAuditService>
    {
        public JRM_ReportAuditController(IJRM_ReportAuditService service)
        : base(service)
        {
        }
    }
}

