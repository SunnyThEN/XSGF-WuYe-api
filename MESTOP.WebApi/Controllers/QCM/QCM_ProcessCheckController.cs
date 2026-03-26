/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_ProcessCheckController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_ProcessCheck")]
    [PermissionTable(Name = "QCM_ProcessCheck")]
    public partial class QCM_ProcessCheckController : ApiBaseController<IQCM_ProcessCheckService>
    {
        public QCM_ProcessCheckController(IQCM_ProcessCheckService service)
        : base(service)
        {
        }
    }
}

