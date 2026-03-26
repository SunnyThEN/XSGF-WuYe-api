/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sys_DictionaryController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MESTOP.Sys.IServices;
namespace MESTOP.Sys.Controllers
{
    [Route("api/Sys_Dictionary")]
    [PermissionTable(Name = "Sys_Dictionary")]
    public partial class Sys_DictionaryController : ApiBaseController<ISys_DictionaryService>
    {
        public Sys_DictionaryController(ISys_DictionaryService service)
        : base(service)
        {
        }
    }
}

