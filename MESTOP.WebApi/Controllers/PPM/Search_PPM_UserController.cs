/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_PPM_UserController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_PPM_User")]
    [PermissionTable(Name = "Search_PPM_User")]
    public partial class Search_PPM_UserController : ApiBaseController<ISearch_PPM_UserService>
    {
        public Search_PPM_UserController(ISearch_PPM_UserService service)
        : base(service)
        {
        }
    }
}

