/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_AbnormalListController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_AbnormalList")]
    [PermissionTable(Name = "QCM_AbnormalList")]
    public partial class QCM_AbnormalListController : ApiBaseController<IQCM_AbnormalListService>
    {
        public QCM_AbnormalListController(IQCM_AbnormalListService service)
        : base(service)
        {
        }
    }
}

