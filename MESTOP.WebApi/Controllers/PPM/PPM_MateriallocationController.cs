/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_MateriallocationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_Materiallocation")]
    [PermissionTable(Name = "PPM_Materiallocation")]
    public partial class PPM_MateriallocationController : ApiBaseController<IPPM_MateriallocationService>
    {
        public PPM_MateriallocationController(IPPM_MateriallocationService service)
        : base(service)
        {
        }
    }
}

