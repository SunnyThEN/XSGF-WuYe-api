/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Base_PrintTemplateController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using BASE.IServices;
namespace BASE.Controllers
{
    [Route("api/Base_PrintTemplate")]
    [PermissionTable(Name = "Base_PrintTemplate")]
    public partial class Base_PrintTemplateController : ApiBaseController<IBase_PrintTemplateService>
    {
        public Base_PrintTemplateController(IBase_PrintTemplateService service)
        : base(service)
        {
        }
    }
}

