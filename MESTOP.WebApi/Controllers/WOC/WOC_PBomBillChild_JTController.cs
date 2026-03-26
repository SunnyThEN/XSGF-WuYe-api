/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_PBomBillChild_JTController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_PBomBillChild_JT")]
    [PermissionTable(Name = "WOC_PBomBillChild_JT")]
    public partial class WOC_PBomBillChild_JTController : ApiBaseController<IWOC_PBomBillChild_JTService>
    {
        public WOC_PBomBillChild_JTController(IWOC_PBomBillChild_JTService service)
        : base(service)
        {
        }
    }
}

