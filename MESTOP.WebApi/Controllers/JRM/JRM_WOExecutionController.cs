/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_WOExecutionController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_WOExecution")]
    [PermissionTable(Name = "JRM_WOExecution")]
    public partial class JRM_WOExecutionController : ApiBaseController<IJRM_WOExecutionService>
    {
        public JRM_WOExecutionController(IJRM_WOExecutionService service)
        : base(service)
        {
        }
    }
}

