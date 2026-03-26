/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProductAdd_DFController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProductAdd_DF")]
    [PermissionTable(Name = "WOC_ProductAdd_DF")]
    public partial class WOC_ProductAdd_DFController : ApiBaseController<IWOC_ProductAdd_DFService>
    {
        public WOC_ProductAdd_DFController(IWOC_ProductAdd_DFService service)
        : base(service)
        {
        }
    }
}

