/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_BD_LOTMASTERController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_BD_LOTMASTER")]
    [PermissionTable(Name = "T_BD_LOTMASTER")]
    public partial class T_BD_LOTMASTERController : ApiBaseController<IT_BD_LOTMASTERService>
    {
        public T_BD_LOTMASTERController(IT_BD_LOTMASTERService service)
        : base(service)
        {
        }
    }
}

