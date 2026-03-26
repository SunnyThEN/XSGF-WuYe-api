/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_PRD_RETURNMTRLENTRYController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_PRD_RETURNMTRLENTRY")]
    [PermissionTable(Name = "T_PRD_RETURNMTRLENTRY")]
    public partial class T_PRD_RETURNMTRLENTRYController : ApiBaseController<IT_PRD_RETURNMTRLENTRYService>
    {
        public T_PRD_RETURNMTRLENTRYController(IT_PRD_RETURNMTRLENTRYService service)
        : base(service)
        {
        }
    }
}

