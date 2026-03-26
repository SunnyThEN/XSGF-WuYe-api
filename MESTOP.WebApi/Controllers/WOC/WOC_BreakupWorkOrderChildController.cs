/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_BreakupWorkOrderChildController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_BreakupWorkOrderChild")]
    [PermissionTable(Name = "WOC_BreakupWorkOrderChild")]
    public partial class WOC_BreakupWorkOrderChildController : ApiBaseController<IWOC_BreakupWorkOrderChildService>
    {
        public WOC_BreakupWorkOrderChildController(IWOC_BreakupWorkOrderChildService service)
        : base(service)
        {
        }
    }
}

