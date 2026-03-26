/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_DispatchCard_WorkFlow_TempController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_DispatchCard_WorkFlow_Temp")]
    [PermissionTable(Name = "WOC_DispatchCard_WorkFlow_Temp")]
    public partial class WOC_DispatchCard_WorkFlow_TempController : ApiBaseController<IWOC_DispatchCard_WorkFlow_TempService>
    {
        public WOC_DispatchCard_WorkFlow_TempController(IWOC_DispatchCard_WorkFlow_TempService service)
        : base(service)
        {
        }
    }
}

