/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderChild_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderChild_Temp")]
    [PermissionTable(Name = "WOC_WorkOrderChild_Temp")]
    public partial class WOC_WorkOrderChild_TempController : ApiBaseController<IWOC_WorkOrderChild_TempService>
    {
        public WOC_WorkOrderChild_TempController(IWOC_WorkOrderChild_TempService service)
        : base(service)
        {
        }
    }
}

