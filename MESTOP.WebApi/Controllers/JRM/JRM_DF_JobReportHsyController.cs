/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_DF_JobReportHsyController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_DF_JobReportHsy")]
    [PermissionTable(Name = "JRM_DF_JobReportHsy")]
    public partial class JRM_DF_JobReportHsyController : ApiBaseController<IJRM_DF_JobReportHsyService>
    {
        public JRM_DF_JobReportHsyController(IJRM_DF_JobReportHsyService service)
        : base(service)
        {
        }
    }
}

