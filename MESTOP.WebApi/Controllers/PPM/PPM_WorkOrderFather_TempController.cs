/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PPM_WorkOrderFather_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/PPM_WorkOrderFather_Temp")]
    [PermissionTable(Name = "PPM_WorkOrderFather_Temp")]
    public partial class PPM_WorkOrderFather_TempController : ApiBaseController<IPPM_WorkOrderFather_TempService>
    {
        public PPM_WorkOrderFather_TempController(IPPM_WorkOrderFather_TempService service)
        : base(service)
        {
        }
    }
}

