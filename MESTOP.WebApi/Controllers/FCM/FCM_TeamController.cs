/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FCM_TeamController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using FCM.IServices;
namespace FCM.Controllers
{
    [Route("api/FCM_Team")]
    [PermissionTable(Name = "FCM_Team")]
    public partial class FCM_TeamController : ApiBaseController<IFCM_TeamService>
    {
        public FCM_TeamController(IFCM_TeamService service)
        : base(service)
        {
        }
    }
}

