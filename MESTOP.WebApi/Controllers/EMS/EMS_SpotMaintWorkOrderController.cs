/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_SpotMaintWorkOrderController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_SpotMaintWorkOrder")]
    [PermissionTable(Name = "EMS_SpotMaintWorkOrder")]
    public partial class EMS_SpotMaintWorkOrderController : ApiBaseController<IEMS_SpotMaintWorkOrderService>
    {
        public EMS_SpotMaintWorkOrderController(IEMS_SpotMaintWorkOrderService service)
        : base(service)
        {
        }
    }
}

