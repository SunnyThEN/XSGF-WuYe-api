/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_MetalProcessFlowStepController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_MetalProcessFlowStep")]
    [PermissionTable(Name = "PPM_MetalProcessFlowStep")]
    public partial class PPM_MetalProcessFlowStepController : ApiBaseController<IPPM_MetalProcessFlowStepService>
    {
        public PPM_MetalProcessFlowStepController(IPPM_MetalProcessFlowStepService service)
        : base(service)
        {
        }
    }
}

