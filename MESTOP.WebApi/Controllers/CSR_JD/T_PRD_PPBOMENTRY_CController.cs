/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_PRD_PPBOMENTRY_CController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_PRD_PPBOMENTRY_C")]
    [PermissionTable(Name = "T_PRD_PPBOMENTRY_C")]
    public partial class T_PRD_PPBOMENTRY_CController : ApiBaseController<IT_PRD_PPBOMENTRY_CService>
    {
        public T_PRD_PPBOMENTRY_CController(IT_PRD_PPBOMENTRY_CService service)
        : base(service)
        {
        }
    }
}

