/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_Dispatch_WorkFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_Dispatch_WorkFlow")]
    [PermissionTable(Name = "WOC_Dispatch_WorkFlow")]
    public partial class WOC_Dispatch_WorkFlowController : ApiBaseController<IWOC_Dispatch_WorkFlowService>
    {
        public WOC_Dispatch_WorkFlowController(IWOC_Dispatch_WorkFlowService service)
        : base(service)
        {
        }
    }
}

