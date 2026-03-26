/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sys_QuartzOptionsController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MESTOP.Sys.IServices;
namespace MESTOP.Sys.Controllers
{
    [Route("api/Sys_QuartzOptions")]
    [PermissionTable(Name = "Sys_QuartzOptions")]
    public partial class Sys_QuartzOptionsController : ApiBaseController<ISys_QuartzOptionsService>
    {
        public Sys_QuartzOptionsController(ISys_QuartzOptionsService service)
        : base(service)
        {
        }
    }
}

