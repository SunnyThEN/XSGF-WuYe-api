/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_WorkFlowController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_WorkFlow")]
    [PermissionTable(Name = "JRM_WorkFlow")]
    public partial class JRM_WorkFlowController : ApiBaseController<IJRM_WorkFlowService>
    {
        public JRM_WorkFlowController(IJRM_WorkFlowService service)
        : base(service)
        {
        }
    }
}

