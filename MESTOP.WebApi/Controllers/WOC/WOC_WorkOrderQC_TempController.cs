/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrderQC_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrderQC_Temp")]
    [PermissionTable(Name = "WOC_WorkOrderQC_Temp")]
    public partial class WOC_WorkOrderQC_TempController : ApiBaseController<IWOC_WorkOrderQC_TempService>
    {
        public WOC_WorkOrderQC_TempController(IWOC_WorkOrderQC_TempService service)
        : base(service)
        {
        }
    }
}

