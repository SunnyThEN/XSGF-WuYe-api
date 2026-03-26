/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_PRD_INSTOCKENTRYController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_PRD_INSTOCKENTRY")]
    [PermissionTable(Name = "T_PRD_INSTOCKENTRY")]
    public partial class T_PRD_INSTOCKENTRYController : ApiBaseController<IT_PRD_INSTOCKENTRYService>
    {
        public T_PRD_INSTOCKENTRYController(IT_PRD_INSTOCKENTRYService service)
        : base(service)
        {
        }
    }
}

