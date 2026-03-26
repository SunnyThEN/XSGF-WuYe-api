/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_WorkFlowStepController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_WorkFlowStep")]
    [PermissionTable(Name = "PPM_WorkFlowStep")]
    public partial class PPM_WorkFlowStepController : ApiBaseController<IPPM_WorkFlowStepService>
    {
        public PPM_WorkFlowStepController(IPPM_WorkFlowStepService service)
        : base(service)
        {
        }
    }
}

