/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_EquipmentMaintenanceSolutionController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_EquipmentMaintenanceSolution")]
    [PermissionTable(Name = "EMS_EquipmentMaintenanceSolution")]
    public partial class EMS_EquipmentMaintenanceSolutionController : ApiBaseController<IEMS_EquipmentMaintenanceSolutionService>
    {
        public EMS_EquipmentMaintenanceSolutionController(IEMS_EquipmentMaintenanceSolutionService service)
        : base(service)
        {
        }
    }
}

