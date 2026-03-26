/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CSR_JD_InventorySearchController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/CSR_JD_InventorySearch")]
    [PermissionTable(Name = "CSR_JD_InventorySearch")]
    public partial class CSR_JD_InventorySearchController : ApiBaseController<ICSR_JD_InventorySearchService>
    {
        public CSR_JD_InventorySearchController(ICSR_JD_InventorySearchService service)
        : base(service)
        {
        }
    }
}

