/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_TemplateTestItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_TemplateTestItem")]
    [PermissionTable(Name = "QCM_TemplateTestItem")]
    public partial class QCM_TemplateTestItemController : ApiBaseController<IQCM_TemplateTestItemService>
    {
        public QCM_TemplateTestItemController(IQCM_TemplateTestItemService service)
        : base(service)
        {
        }
    }
}

