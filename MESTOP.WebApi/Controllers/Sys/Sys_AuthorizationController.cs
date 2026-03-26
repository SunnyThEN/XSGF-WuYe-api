/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sys_AuthorizationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MESTOP.Sys.IServices;
namespace MESTOP.Sys.Controllers
{
    [Route("api/Sys_Authorization")]
    [PermissionTable(Name = "Sys_Authorization")]
    public partial class Sys_AuthorizationController : ApiBaseController<ISys_AuthorizationService>
    {
        public Sys_AuthorizationController(ISys_AuthorizationService service)
        : base(service)
        {
        }
    }
}

