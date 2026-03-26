/*

 *如果要增加方法请在当前目录下Partial文件夹JRM_JHC_JobReportController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;

using JRM.IServices;

namespace JHC.Controllers
{
    [Route("api/JRM_JHC_JobReport")]
    [PermissionTable(Name = "JRM_JHC_JobReport")]
    public partial class JRM_JHC_JobReportController : ApiBaseController<IJRM_JHC_JobReportService>
    {
        public JRM_JHC_JobReportController(IJRM_JHC_JobReportService service)
        : base(service)
        {
        }
    }
}

