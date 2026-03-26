/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹RMS_VacantRoomController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using RMS.IServices;
namespace RMS.Controllers
{
    [Route("api/RMS_VacantRoom")]
    [PermissionTable(Name = "RMS_VacantRoom")]
    public partial class RMS_VacantRoomController : ApiBaseController<IRMS_VacantRoomService>
    {
        public RMS_VacantRoomController(IRMS_VacantRoomService service)
        : base(service)
        {
        }
    }
}

