/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_View_WorkReportController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_View_WorkReport")]
    [PermissionTable(Name = "JRM_View_WorkReport")]
    public partial class JRM_View_WorkReportController : ApiBaseController<IJRM_View_WorkReportService>
    {
        public JRM_View_WorkReportController(IJRM_View_WorkReportService service)
        : base(service)
        {
        }
    }
}

