/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_WOC_Dispatch_MaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/Search_WOC_Dispatch_Material")]
    [PermissionTable(Name = "Search_WOC_Dispatch_Material")]
    public partial class Search_WOC_Dispatch_MaterialController : ApiBaseController<ISearch_WOC_Dispatch_MaterialService>
    {
        public Search_WOC_Dispatch_MaterialController(ISearch_WOC_Dispatch_MaterialService service)
        : base(service)
        {
        }
    }
}

