/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SelfTestController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SelfTest")]
    [PermissionTable(Name = "QCM_SelfTest")]
    public partial class QCM_SelfTestController : ApiBaseController<IQCM_SelfTestService>
    {
        public QCM_SelfTestController(IQCM_SelfTestService service)
        : base(service)
        {
        }
    }
}

