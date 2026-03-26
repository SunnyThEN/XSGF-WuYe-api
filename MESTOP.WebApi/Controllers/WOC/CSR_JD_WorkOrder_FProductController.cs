/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CSR_JD_WorkOrder_FProductController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/CSR_JD_WorkOrder_FProduct")]
    [PermissionTable(Name = "CSR_JD_WorkOrder_FProduct")]
    public partial class CSR_JD_WorkOrder_FProductController : ApiBaseController<ICSR_JD_WorkOrder_FProductService>
    {
        public CSR_JD_WorkOrder_FProductController(ICSR_JD_WorkOrder_FProductService service)
        : base(service)
        {
        }
    }
}

