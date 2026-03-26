/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_IssuesSummaryController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_IssuesSummary")]
    [PermissionTable(Name = "QCM_IssuesSummary")]
    public partial class QCM_IssuesSummaryController : ApiBaseController<IQCM_IssuesSummaryService>
    {
        public QCM_IssuesSummaryController(IQCM_IssuesSummaryService service)
        : base(service)
        {
        }
    }
}

