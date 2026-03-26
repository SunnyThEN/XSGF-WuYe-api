/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_PPM_ProdprocessController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_PPM_Prodprocess")]
    [PermissionTable(Name = "Search_PPM_Prodprocess")]
    public partial class Search_PPM_ProdprocessController : ApiBaseController<ISearch_PPM_ProdprocessService>
    {
        public Search_PPM_ProdprocessController(ISearch_PPM_ProdprocessService service)
        : base(service)
        {
        }
    }
}

