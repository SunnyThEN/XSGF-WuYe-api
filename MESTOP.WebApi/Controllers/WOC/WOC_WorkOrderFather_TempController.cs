/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderFather_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderFather_Temp")]
    [PermissionTable(Name = "WOC_WorkOrderFather_Temp")]
    public partial class WOC_WorkOrderFather_TempController : ApiBaseController<IWOC_WorkOrderFather_TempService>
    {
        public WOC_WorkOrderFather_TempController(IWOC_WorkOrderFather_TempService service)
        : base(service)
        {
        }
    }
}

