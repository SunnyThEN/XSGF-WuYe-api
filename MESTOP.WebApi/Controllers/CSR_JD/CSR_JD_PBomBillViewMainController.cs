/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CSR_JD_PBomBillViewMainController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/CSR_JD_PBomBillViewMain")]
    [PermissionTable(Name = "CSR_JD_PBomBillViewMain")]
    public partial class CSR_JD_PBomBillViewMainController : ApiBaseController<ICSR_JD_PBomBillViewMainService>
    {
        public CSR_JD_PBomBillViewMainController(ICSR_JD_PBomBillViewMainService service)
        : base(service)
        {
        }
    }
}

