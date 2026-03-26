/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_PBomBillMain_JTController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_PBomBillMain_JT")]
    [PermissionTable(Name = "WOC_PBomBillMain_JT")]
    public partial class WOC_PBomBillMain_JTController : ApiBaseController<IWOC_PBomBillMain_JTService>
    {
        public WOC_PBomBillMain_JTController(IWOC_PBomBillMain_JTService service)
        : base(service)
        {
        }
    }
}

