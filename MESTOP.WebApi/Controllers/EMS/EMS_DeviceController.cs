/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_DeviceController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_Device")]
    [PermissionTable(Name = "EMS_Device")]
    public partial class EMS_DeviceController : ApiBaseController<IEMS_DeviceService>
    {
        public EMS_DeviceController(IEMS_DeviceService service)
        : base(service)
        {
        }
    }
}

