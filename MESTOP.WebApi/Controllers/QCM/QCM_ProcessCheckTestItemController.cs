/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_ProcessCheckTestItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_ProcessCheckTestItem")]
    [PermissionTable(Name = "QCM_ProcessCheckTestItem")]
    public partial class QCM_ProcessCheckTestItemController : ApiBaseController<IQCM_ProcessCheckTestItemService>
    {
        public QCM_ProcessCheckTestItemController(IQCM_ProcessCheckTestItemService service)
        : base(service)
        {
        }
    }
}

