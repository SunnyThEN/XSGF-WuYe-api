/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SIPItemFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SIPItemFile")]
    [PermissionTable(Name = "QCM_SIPItemFile")]
    public partial class QCM_SIPItemFileController : ApiBaseController<IQCM_SIPItemFileService>
    {
        public QCM_SIPItemFileController(IQCM_SIPItemFileService service)
        : base(service)
        {
        }
    }
}

