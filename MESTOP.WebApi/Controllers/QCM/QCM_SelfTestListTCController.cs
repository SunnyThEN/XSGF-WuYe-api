/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SelfTestListTCController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SelfTestListTC")]
    [PermissionTable(Name = "QCM_SelfTestListTC")]
    public partial class QCM_SelfTestListTCController : ApiBaseController<IQCM_SelfTestListTCService>
    {
        public QCM_SelfTestListTCController(IQCM_SelfTestListTCService service)
        : base(service)
        {
        }
    }
}

