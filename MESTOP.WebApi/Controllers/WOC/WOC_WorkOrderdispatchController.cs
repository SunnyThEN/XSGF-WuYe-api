/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderdispatchController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderdispatch")]
    [PermissionTable(Name = "WOC_WorkOrderdispatch")]
    public partial class WOC_WorkOrderdispatchController : ApiBaseController<IWOC_WorkOrderdispatchService>
    {
        public WOC_WorkOrderdispatchController(IWOC_WorkOrderdispatchService service)
        : base(service)
        {
        }
    }
}

