/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FCM_TeamMemberController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using FCM.IServices;
namespace FCM.Controllers
{
    [Route("api/FCM_TeamMember")]
    [PermissionTable(Name = "FCM_TeamMember")]
    public partial class FCM_TeamMemberController : ApiBaseController<IFCM_TeamMemberService>
    {
        public FCM_TeamMemberController(IFCM_TeamMemberService service)
        : base(service)
        {
        }
    }
}

