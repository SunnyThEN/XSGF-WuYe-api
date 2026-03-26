/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SIPSolutionFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SIPSolutionFile")]
    [PermissionTable(Name = "QCM_SIPSolutionFile")]
    public partial class QCM_SIPSolutionFileController : ApiBaseController<IQCM_SIPSolutionFileService>
    {
        public QCM_SIPSolutionFileController(IQCM_SIPSolutionFileService service)
        : base(service)
        {
        }
    }
}

