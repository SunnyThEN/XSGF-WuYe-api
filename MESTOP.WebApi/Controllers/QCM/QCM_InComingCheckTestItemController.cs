/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_InComingCheckTestItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_InComingCheckTestItem")]
    [PermissionTable(Name = "QCM_InComingCheckTestItem")]
    public partial class QCM_InComingCheckTestItemController : ApiBaseController<IQCM_InComingCheckTestItemService>
    {
        public QCM_InComingCheckTestItemController(IQCM_InComingCheckTestItemService service)
        : base(service)
        {
        }
    }
}

