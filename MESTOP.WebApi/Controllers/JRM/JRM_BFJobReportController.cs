/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_BFJobReportController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_BFJobReport")]
    [PermissionTable(Name = "JRM_BFJobReport")]
    public partial class JRM_BFJobReportController : ApiBaseController<IJRM_BFJobReportService>
    {
        public JRM_BFJobReportController(IJRM_BFJobReportService service)
        : base(service)
        {
        }
    }
}

