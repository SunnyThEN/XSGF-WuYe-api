/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ReworkOderController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ReworkOder")]
    [PermissionTable(Name = "WOC_ReworkOder")]
    public partial class WOC_ReworkOderController : ApiBaseController<IWOC_ReworkOderService>
    {
        public WOC_ReworkOderController(IWOC_ReworkOderService service)
        : base(service)
        {
        }
    }
}

