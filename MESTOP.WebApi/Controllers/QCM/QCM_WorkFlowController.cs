/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_WorkFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_WorkFlow")]
    [PermissionTable(Name = "QCM_WorkFlow")]
    public partial class QCM_WorkFlowController : ApiBaseController<IQCM_WorkFlowService>
    {
        public QCM_WorkFlowController(IQCM_WorkFlowService service)
        : base(service)
        {
        }
    }
}

