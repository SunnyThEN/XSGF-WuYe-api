/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_EquipmentSpotCheckItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_EquipmentSpotCheckItem")]
    [PermissionTable(Name = "EMS_EquipmentSpotCheckItem")]
    public partial class EMS_EquipmentSpotCheckItemController : ApiBaseController<IEMS_EquipmentSpotCheckItemService>
    {
        public EMS_EquipmentSpotCheckItemController(IEMS_EquipmentSpotCheckItemService service)
        : base(service)
        {
        }
    }
}

