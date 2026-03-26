/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FCM_HolidayController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using FCM.IServices;
namespace FCM.Controllers
{
    [Route("api/FCM_Holiday")]
    [PermissionTable(Name = "FCM_Holiday")]
    public partial class FCM_HolidayController : ApiBaseController<IFCM_HolidayService>
    {
        public FCM_HolidayController(IFCM_HolidayService service)
        : base(service)
        {
        }
    }
}

