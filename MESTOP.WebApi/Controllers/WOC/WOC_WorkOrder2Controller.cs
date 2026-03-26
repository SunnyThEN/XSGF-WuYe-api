/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WOC_WorkOrder2Controller编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using WOC.IServices;
namespace WOC.Controllers
{
    [Route("api/WOC_WorkOrder2")]
    [PermissionTable(Name = "WOC_WorkOrder2")]
    public partial class WOC_WorkOrder2Controller : ApiBaseController<IWOC_WorkOrder2Service>
    {
        public WOC_WorkOrder2Controller(IWOC_WorkOrder2Service service)
        : base(service)
        {
        }
    }
}

