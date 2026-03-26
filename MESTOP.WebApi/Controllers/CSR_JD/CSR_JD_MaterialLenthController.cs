/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CSR_JD_MaterialLenthController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/CSR_JD_MaterialLenth")]
    [PermissionTable(Name = "CSR_JD_MaterialLenth")]
    public partial class CSR_JD_MaterialLenthController : ApiBaseController<ICSR_JD_MaterialLenthService>
    {
        public CSR_JD_MaterialLenthController(ICSR_JD_MaterialLenthService service)
        : base(service)
        {
        }
    }
}

