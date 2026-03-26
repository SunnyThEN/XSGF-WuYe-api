/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_Dispatch_WorkStationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_Dispatch_WorkStation")]
    [PermissionTable(Name = "WOC_Dispatch_WorkStation")]
    public partial class WOC_Dispatch_WorkStationController : ApiBaseController<IWOC_Dispatch_WorkStationService>
    {
        public WOC_Dispatch_WorkStationController(IWOC_Dispatch_WorkStationService service)
        : base(service)
        {
        }
    }
}

