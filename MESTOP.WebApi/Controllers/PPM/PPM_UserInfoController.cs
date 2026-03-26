/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_UserInfoController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_UserInfo")]
    [PermissionTable(Name = "PPM_UserInfo")]
    public partial class PPM_UserInfoController : ApiBaseController<IPPM_UserInfoService>
    {
        public PPM_UserInfoController(IPPM_UserInfoService service)
        : base(service)
        {
        }
    }
}

