/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_ProcessWorkFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_ProcessWorkFlow")]
    [PermissionTable(Name = "WOC_ProcessWorkFlow")]
    public partial class WOC_ProcessWorkFlowController : ApiBaseController<IWOC_ProcessWorkFlowService>
    {
        public WOC_ProcessWorkFlowController(IWOC_ProcessWorkFlowService service)
        : base(service)
        {
        }
    }
}

