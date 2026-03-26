/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CSR_JD_BOMDetailedController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/CSR_JD_BOMDetailed")]
    [PermissionTable(Name = "CSR_JD_BOMDetailed")]
    public partial class CSR_JD_BOMDetailedController : ApiBaseController<ICSR_JD_BOMDetailedService>
    {
        public CSR_JD_BOMDetailedController(ICSR_JD_BOMDetailedService service)
        : base(service)
        {
        }
    }
}

