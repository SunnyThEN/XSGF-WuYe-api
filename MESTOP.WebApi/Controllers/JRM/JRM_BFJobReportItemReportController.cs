/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_BFJobReportItemReportController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_BFJobReportItemReport")]
    [PermissionTable(Name = "JRM_BFJobReportItemReport")]
    public partial class JRM_BFJobReportItemReportController : ApiBaseController<IJRM_BFJobReportItemReportService>
    {
        public JRM_BFJobReportItemReportController(IJRM_BFJobReportItemReportService service)
        : base(service)
        {
        }
    }
}

