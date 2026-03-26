/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProductionreceiptAddTempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProductionreceiptAddTemp")]
    [PermissionTable(Name = "WOC_ProductionreceiptAddTemp")]
    public partial class WOC_ProductionreceiptAddTempController : ApiBaseController<IWOC_ProductionreceiptAddTempService>
    {
        public WOC_ProductionreceiptAddTempController(IWOC_ProductionreceiptAddTempService service)
        : base(service)
        {
        }
    }
}

