/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_Dispatch_EquipmentController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_Dispatch_Equipment")]
    [PermissionTable(Name = "WOC_Dispatch_Equipment")]
    public partial class WOC_Dispatch_EquipmentController : ApiBaseController<IWOC_Dispatch_EquipmentService>
    {
        public WOC_Dispatch_EquipmentController(IWOC_Dispatch_EquipmentService service)
        : base(service)
        {
        }
    }
}

