/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_PRD_INSTOCKController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_PRD_INSTOCK")]
    [PermissionTable(Name = "T_PRD_INSTOCK")]
    public partial class T_PRD_INSTOCKController : ApiBaseController<IT_PRD_INSTOCKService>
    {
        public T_PRD_INSTOCKController(IT_PRD_INSTOCKService service)
        : base(service)
        {
        }
    }
}

