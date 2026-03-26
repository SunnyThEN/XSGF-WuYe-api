/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SIPItemTypeFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SIPItemTypeFile")]
    [PermissionTable(Name = "QCM_SIPItemTypeFile")]
    public partial class QCM_SIPItemTypeFileController : ApiBaseController<IQCM_SIPItemTypeFileService>
    {
        public QCM_SIPItemTypeFileController(IQCM_SIPItemTypeFileService service)
        : base(service)
        {
        }
    }
}

