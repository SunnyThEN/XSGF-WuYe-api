/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderStatusController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderStatus")]
    [PermissionTable(Name = "WOC_WorkOrderStatus")]
    public partial class WOC_WorkOrderStatusController : ApiBaseController<IWOC_WorkOrderStatusService>
    {
        public WOC_WorkOrderStatusController(IWOC_WorkOrderStatusService service)
        : base(service)
        {
        }
    }
}

