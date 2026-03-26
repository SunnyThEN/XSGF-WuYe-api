/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_BFJobReportItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_BFJobReportItem")]
    [PermissionTable(Name = "JRM_BFJobReportItem")]
    public partial class JRM_BFJobReportItemController : ApiBaseController<IJRM_BFJobReportItemService>
    {
        public JRM_BFJobReportItemController(IJRM_BFJobReportItemService service)
        : base(service)
        {
        }
    }
}

