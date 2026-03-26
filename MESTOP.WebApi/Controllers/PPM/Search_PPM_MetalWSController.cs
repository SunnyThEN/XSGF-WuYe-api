/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_PPM_MetalWSController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_PPM_MetalWS")]
    [PermissionTable(Name = "Search_PPM_MetalWS")]
    public partial class Search_PPM_MetalWSController : ApiBaseController<ISearch_PPM_MetalWSService>
    {
        public Search_PPM_MetalWSController(ISearch_PPM_MetalWSService service)
        : base(service)
        {
        }
    }
}

