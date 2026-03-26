/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SamplingIpcController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SamplingIpc")]
    [PermissionTable(Name = "QCM_SamplingIpc")]
    public partial class QCM_SamplingIpcController : ApiBaseController<IQCM_SamplingIpcService>
    {
        public QCM_SamplingIpcController(IQCM_SamplingIpcService service)
        : base(service)
        {
        }
    }
}

