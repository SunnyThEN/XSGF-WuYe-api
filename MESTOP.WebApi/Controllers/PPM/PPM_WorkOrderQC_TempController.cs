/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_WorkOrderQC_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_WorkOrderQC_Temp")]
    [PermissionTable(Name = "PPM_WorkOrderQC_Temp")]
    public partial class PPM_WorkOrderQC_TempController : ApiBaseController<IPPM_WorkOrderQC_TempService>
    {
        public PPM_WorkOrderQC_TempController(IPPM_WorkOrderQC_TempService service)
        : base(service)
        {
        }
    }
}

