/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Tree_PPM_WorkFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PPM.IServices;
namespace PPM.Controllers
{
    [Route("api/Tree_PPM_WorkFlow")]
    [PermissionTable(Name = "Tree_PPM_WorkFlow")]
    public partial class Tree_PPM_WorkFlowController : ApiBaseController<ITree_PPM_WorkFlowService>
    {
        public Tree_PPM_WorkFlowController(ITree_PPM_WorkFlowService service)
        : base(service)
        {
        }
    }
}

