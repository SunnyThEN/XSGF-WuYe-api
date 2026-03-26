/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_BreakupWorkOrderMainController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_BreakupWorkOrderMain")]
    [PermissionTable(Name = "WOC_BreakupWorkOrderMain")]
    public partial class WOC_BreakupWorkOrderMainController : ApiBaseController<IWOC_BreakupWorkOrderMainService>
    {
        public WOC_BreakupWorkOrderMainController(IWOC_BreakupWorkOrderMainService service)
        : base(service)
        {
        }
    }
}

