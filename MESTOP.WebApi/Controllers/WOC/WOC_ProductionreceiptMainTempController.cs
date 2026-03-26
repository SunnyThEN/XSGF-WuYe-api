/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProductionreceiptMainTempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProductionreceiptMainTemp")]
    [PermissionTable(Name = "WOC_ProductionreceiptMainTemp")]
    public partial class WOC_ProductionreceiptMainTempController : ApiBaseController<IWOC_ProductionreceiptMainTempService>
    {
        public WOC_ProductionreceiptMainTempController(IWOC_ProductionreceiptMainTempService service)
        : base(service)
        {
        }
    }
}

