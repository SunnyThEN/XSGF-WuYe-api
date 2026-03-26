/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_QCM_TestItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/Search_QCM_TestItem")]
    [PermissionTable(Name = "Search_QCM_TestItem")]
    public partial class Search_QCM_TestItemController : ApiBaseController<ISearch_QCM_TestItemService>
    {
        public Search_QCM_TestItemController(ISearch_QCM_TestItemService service)
        : base(service)
        {
        }
    }
}

