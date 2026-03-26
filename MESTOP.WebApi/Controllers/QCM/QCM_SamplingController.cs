/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SamplingController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_Sampling")]
    [PermissionTable(Name = "QCM_Sampling")]
    public partial class QCM_SamplingController : ApiBaseController<IQCM_SamplingService>
    {
        public QCM_SamplingController(IQCM_SamplingService service)
        : base(service)
        {
        }
    }
}

