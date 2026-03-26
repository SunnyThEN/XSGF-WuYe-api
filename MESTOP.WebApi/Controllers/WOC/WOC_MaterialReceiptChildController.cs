/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_MaterialReceiptChildController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_MaterialReceiptChild")]
    [PermissionTable(Name = "WOC_MaterialReceiptChild")]
    public partial class WOC_MaterialReceiptChildController : ApiBaseController<IWOC_MaterialReceiptChildService>
    {
        public WOC_MaterialReceiptChildController(IWOC_MaterialReceiptChildService service)
        : base(service)
        {
        }
    }
}

