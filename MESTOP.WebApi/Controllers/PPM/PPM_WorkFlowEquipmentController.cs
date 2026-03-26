/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_WorkFlowEquipmentController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_WorkFlowEquipment")]
    [PermissionTable(Name = "PPM_WorkFlowEquipment")]
    public partial class PPM_WorkFlowEquipmentController : ApiBaseController<IPPM_WorkFlowEquipmentService>
    {
        public PPM_WorkFlowEquipmentController(IPPM_WorkFlowEquipmentService service)
        : base(service)
        {
        }
    }
}

