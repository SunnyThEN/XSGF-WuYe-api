/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_MetalWorkStationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_MetalWorkStation")]
    [PermissionTable(Name = "PPM_MetalWorkStation")]
    public partial class PPM_MetalWorkStationController : ApiBaseController<IPPM_MetalWorkStationService>
    {
        public PPM_MetalWorkStationController(IPPM_MetalWorkStationService service)
        : base(service)
        {
        }
    }
}

