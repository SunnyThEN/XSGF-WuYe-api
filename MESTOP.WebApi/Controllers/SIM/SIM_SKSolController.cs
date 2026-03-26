/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹SIM_SKSolController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using SIM.IServices;
namespace SIM.Controllers
{
    [Route("api/SIM_SKSol")]
    [PermissionTable(Name = "SIM_SKSol")]
    public partial class SIM_SKSolController : ApiBaseController<ISIM_SKSolService>
    {
        public SIM_SKSolController(ISIM_SKSolService service)
        : base(service)
        {
        }
    }
}

