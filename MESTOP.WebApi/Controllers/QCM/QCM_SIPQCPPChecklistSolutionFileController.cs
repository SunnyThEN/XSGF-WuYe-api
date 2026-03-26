/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SIPQCPPChecklistSolutionFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SIPQCPPChecklistSolutionFile")]
    [PermissionTable(Name = "QCM_SIPQCPPChecklistSolutionFile")]
    public partial class QCM_SIPQCPPChecklistSolutionFileController : ApiBaseController<IQCM_SIPQCPPChecklistSolutionFileService>
    {
        public QCM_SIPQCPPChecklistSolutionFileController(IQCM_SIPQCPPChecklistSolutionFileService service)
        : base(service)
        {
        }
    }
}

