/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Tree_EMS_EquipmentTypeController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/Tree_EMS_EquipmentType")]
    [PermissionTable(Name = "Tree_EMS_EquipmentType")]
    public partial class Tree_EMS_EquipmentTypeController : ApiBaseController<ITree_EMS_EquipmentTypeService>
    {
        public Tree_EMS_EquipmentTypeController(ITree_EMS_EquipmentTypeService service)
        : base(service)
        {
        }
    }
}

