/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_MetalProcessFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_MetalProcessFlow")]
    [PermissionTable(Name = "PPM_MetalProcessFlow")]
    public partial class PPM_MetalProcessFlowController : ApiBaseController<IPPM_MetalProcessFlowService>
    {
        public PPM_MetalProcessFlowController(IPPM_MetalProcessFlowService service)
        : base(service)
        {
        }
    }
}

