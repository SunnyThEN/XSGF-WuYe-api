/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_BD_BARCODEMAINController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/T_BD_BARCODEMAIN")]
    [PermissionTable(Name = "T_BD_BARCODEMAIN")]
    public partial class T_BD_BARCODEMAINController : ApiBaseController<IT_BD_BARCODEMAINService>
    {
        public T_BD_BARCODEMAINController(IT_BD_BARCODEMAINService service)
        : base(service)
        {
        }
    }
}

