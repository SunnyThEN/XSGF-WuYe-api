/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_MetalProcessFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_MetalProcessFlow")]
    [PermissionTable(Name = "Search_MetalProcessFlow")]
    public partial class Search_MetalProcessFlowController : ApiBaseController<ISearch_MetalProcessFlowService>
    {
        public Search_MetalProcessFlowController(ISearch_MetalProcessFlowService service)
        : base(service)
        {
        }
    }
}

