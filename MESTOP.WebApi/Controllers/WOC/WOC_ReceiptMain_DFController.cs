/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ReceiptMain_DFController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ReceiptMain_DF")]
    [PermissionTable(Name = "WOC_ReceiptMain_DF")]
    public partial class WOC_ReceiptMain_DFController : ApiBaseController<IWOC_ReceiptMain_DFService>
    {
        public WOC_ReceiptMain_DFController(IWOC_ReceiptMain_DFService service)
        : base(service)
        {
        }
    }
}

