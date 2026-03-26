/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_PBomBillChild_DFController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_PBomBillChild_DF")]
    [PermissionTable(Name = "WOC_PBomBillChild_DF")]
    public partial class WOC_PBomBillChild_DFController : ApiBaseController<IWOC_PBomBillChild_DFService>
    {
        public WOC_PBomBillChild_DFController(IWOC_PBomBillChild_DFService service)
        : base(service)
        {
        }
    }
}

