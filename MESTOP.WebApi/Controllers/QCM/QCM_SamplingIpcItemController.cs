/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SamplingIpcItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SamplingIpcItem")]
    [PermissionTable(Name = "QCM_SamplingIpcItem")]
    public partial class QCM_SamplingIpcItemController : ApiBaseController<IQCM_SamplingIpcItemService>
    {
        public QCM_SamplingIpcItemController(IQCM_SamplingIpcItemService service)
        : base(service)
        {
        }
    }
}

