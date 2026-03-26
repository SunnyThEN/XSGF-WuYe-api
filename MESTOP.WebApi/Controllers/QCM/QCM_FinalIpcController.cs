/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_FinalIpcController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_FinalIpc")]
    [PermissionTable(Name = "QCM_FinalIpc")]
    public partial class QCM_FinalIpcController : ApiBaseController<IQCM_FinalIpcService>
    {
        public QCM_FinalIpcController(IQCM_FinalIpcService service)
        : base(service)
        {
        }
    }
}

