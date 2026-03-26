/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_PPM_WorkFlowStepController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Search_PPM_WorkFlowStep")]
    [PermissionTable(Name = "Search_PPM_WorkFlowStep")]
    public partial class Search_PPM_WorkFlowStepController : ApiBaseController<ISearch_PPM_WorkFlowStepService>
    {
        public Search_PPM_WorkFlowStepController(ISearch_PPM_WorkFlowStepService service)
        : base(service)
        {
        }
    }
}

