/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_WorkOrderFatherWorkFlow_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_WorkOrderFatherWorkFlow_Temp")]
    [PermissionTable(Name = "PPM_WorkOrderFatherWorkFlow_Temp")]
    public partial class PPM_WorkOrderFatherWorkFlow_TempController : ApiBaseController<IPPM_WorkOrderFatherWorkFlow_TempService>
    {
        public PPM_WorkOrderFatherWorkFlow_TempController(IPPM_WorkOrderFatherWorkFlow_TempService service)
        : base(service)
        {
        }
    }
}

