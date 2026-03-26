/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ReceiptChild_DFController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ReceiptChild_DF")]
    [PermissionTable(Name = "WOC_ReceiptChild_DF")]
    public partial class WOC_ReceiptChild_DFController : ApiBaseController<IWOC_ReceiptChild_DFService>
    {
        public WOC_ReceiptChild_DFController(IWOC_ReceiptChild_DFService service)
        : base(service)
        {
        }
    }
}

