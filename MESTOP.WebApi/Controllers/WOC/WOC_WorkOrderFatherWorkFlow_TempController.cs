/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderFatherWorkFlow_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderFatherWorkFlow_Temp")]
    [PermissionTable(Name = "WOC_WorkOrderFatherWorkFlow_Temp")]
    public partial class WOC_WorkOrderFatherWorkFlow_TempController : ApiBaseController<IWOC_WorkOrderFatherWorkFlow_TempService>
    {
        public WOC_WorkOrderFatherWorkFlow_TempController(IWOC_WorkOrderFatherWorkFlow_TempService service)
        : base(service)
        {
        }
    }
}

