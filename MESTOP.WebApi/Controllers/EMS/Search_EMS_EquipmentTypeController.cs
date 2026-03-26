/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_EMS_EquipmentTypeController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/Search_EMS_EquipmentType")]
    [PermissionTable(Name = "Search_EMS_EquipmentType")]
    public partial class Search_EMS_EquipmentTypeController : ApiBaseController<ISearch_EMS_EquipmentTypeService>
    {
        public Search_EMS_EquipmentTypeController(ISearch_EMS_EquipmentTypeService service)
        : base(service)
        {
        }
    }
}

