/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_MaterialReceiptMainController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_MaterialReceiptMain")]
    [PermissionTable(Name = "WOC_MaterialReceiptMain")]
    public partial class WOC_MaterialReceiptMainController : ApiBaseController<IWOC_MaterialReceiptMainService>
    {
        public WOC_MaterialReceiptMainController(IWOC_MaterialReceiptMainService service)
        : base(service)
        {
        }
    }
}

