/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_PPMUserController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_PPMUser")]
    [PermissionTable(Name = "Search_PPMUser")]
    public partial class Search_PPMUserController : ApiBaseController<ISearch_PPMUserService>
    {
        public Search_PPMUserController(ISearch_PPMUserService service)
        : base(service)
        {
        }
    }
}

