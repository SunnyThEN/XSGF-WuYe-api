/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_TestItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_TestItem")]
    [PermissionTable(Name = "QCM_TestItem")]
    public partial class QCM_TestItemController : ApiBaseController<IQCM_TestItemService>
    {
        public QCM_TestItemController(IQCM_TestItemService service)
        : base(service)
        {
        }
    }
}

