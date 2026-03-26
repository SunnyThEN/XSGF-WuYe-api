/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_WOC_WorkOrderController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/Search_WOC_WorkOrder")]
    [PermissionTable(Name = "Search_WOC_WorkOrder")]
    public partial class Search_WOC_WorkOrderController : ApiBaseController<ISearch_WOC_WorkOrderService>
    {
        public Search_WOC_WorkOrderController(ISearch_WOC_WorkOrderService service)
        : base(service)
        {
        }
    }
}

