/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FCM_TeamShiftController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using FCM.IServices;
namespace FCM.Controllers
{
    [Route("api/FCM_TeamShift")]
    [PermissionTable(Name = "FCM_TeamShift")]
    public partial class FCM_TeamShiftController : ApiBaseController<IFCM_TeamShiftService>
    {
        public FCM_TeamShiftController(IFCM_TeamShiftService service)
        : base(service)
        {
        }
    }
}

