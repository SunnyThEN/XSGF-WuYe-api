/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_QCM_SIPSolutionItemController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/Search_QCM_SIPSolutionItem")]
    [PermissionTable(Name = "Search_QCM_SIPSolutionItem")]
    public partial class Search_QCM_SIPSolutionItemController : ApiBaseController<ISearch_QCM_SIPSolutionItemService>
    {
        public Search_QCM_SIPSolutionItemController(ISearch_QCM_SIPSolutionItemService service)
        : base(service)
        {
        }
    }
}

