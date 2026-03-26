/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FCM_PlanShiftController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using FCM.IServices;
namespace FCM.Controllers
{
    [Route("api/FCM_PlanShift")]
    [PermissionTable(Name = "FCM_PlanShift")]
    public partial class FCM_PlanShiftController : ApiBaseController<IFCM_PlanShiftService>
    {
        public FCM_PlanShiftController(IFCM_PlanShiftService service)
        : base(service)
        {
        }
    }
}

