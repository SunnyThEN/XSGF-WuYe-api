/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_JRM_WorkReportController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/Search_JRM_WorkReport")]
    [PermissionTable(Name = "Search_JRM_WorkReport")]
    public partial class Search_JRM_WorkReportController : ApiBaseController<ISearch_JRM_WorkReportService>
    {
        public Search_JRM_WorkReportController(ISearch_JRM_WorkReportService service)
        : base(service)
        {
        }
    }
}

