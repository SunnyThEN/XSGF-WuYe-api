/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProcessWorkOrderController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProcessWorkOrder")]
    [PermissionTable(Name = "WOC_ProcessWorkOrder")]
    public partial class WOC_ProcessWorkOrderController : ApiBaseController<IWOC_ProcessWorkOrderService>
    {
        public WOC_ProcessWorkOrderController(IWOC_ProcessWorkOrderService service)
        : base(service)
        {
        }
    }
}

