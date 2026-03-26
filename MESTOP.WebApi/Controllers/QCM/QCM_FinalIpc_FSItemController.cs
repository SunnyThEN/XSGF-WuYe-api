/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_FinalIpc_FSItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_FinalIpc_FSItem")]
    [PermissionTable(Name = "QCM_FinalIpc_FSItem")]
    public partial class QCM_FinalIpc_FSItemController : ApiBaseController<IQCM_FinalIpc_FSItemService>
    {
        public QCM_FinalIpc_FSItemController(IQCM_FinalIpc_FSItemService service)
        : base(service)
        {
        }
    }
}

