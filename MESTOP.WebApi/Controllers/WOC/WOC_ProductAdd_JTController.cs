/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProductAdd_JTController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProductAdd_JT")]
    [PermissionTable(Name = "WOC_ProductAdd_JT")]
    public partial class WOC_ProductAdd_JTController : ApiBaseController<IWOC_ProductAdd_JTService>
    {
        public WOC_ProductAdd_JTController(IWOC_ProductAdd_JTService service)
        : base(service)
        {
        }
    }
}

