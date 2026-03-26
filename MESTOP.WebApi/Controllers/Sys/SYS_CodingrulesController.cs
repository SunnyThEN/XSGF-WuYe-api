/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹SYS_CodingrulesController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using SYS.IServices;
namespace SYS.Controllers
{
    [Route("api/SYS_Codingrules")]
    [PermissionTable(Name = "SYS_Codingrules")]
    public partial class SYS_CodingrulesController : ApiBaseController<ISYS_CodingrulesService>
    {
        public SYS_CodingrulesController(ISYS_CodingrulesService service)
        : base(service)
        {
        }
    }
}

