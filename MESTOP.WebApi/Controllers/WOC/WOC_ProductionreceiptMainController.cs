/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProductionreceiptMainController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProductionreceiptMain")]
    [PermissionTable(Name = "WOC_ProductionreceiptMain")]
    public partial class WOC_ProductionreceiptMainController : ApiBaseController<IWOC_ProductionreceiptMainService>
    {
        public WOC_ProductionreceiptMainController(IWOC_ProductionreceiptMainService service)
        : base(service)
        {
        }
    }
}

