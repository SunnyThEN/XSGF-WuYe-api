/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderMainController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderMain")]
    [PermissionTable(Name = "WOC_WorkOrderMain")]
    public partial class WOC_WorkOrderMainController : ApiBaseController<IWOC_WorkOrderMainService>
    {
        public WOC_WorkOrderMainController(IWOC_WorkOrderMainService service)
        : base(service)
        {
        }
    }
}

