/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_Dispatch_WorkStationListController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_Dispatch_WorkStationList")]
    [PermissionTable(Name = "WOC_Dispatch_WorkStationList")]
    public partial class WOC_Dispatch_WorkStationListController : ApiBaseController<IWOC_Dispatch_WorkStationListService>
    {
        public WOC_Dispatch_WorkStationListController(IWOC_Dispatch_WorkStationListService service)
        : base(service)
        {
        }
    }
}

