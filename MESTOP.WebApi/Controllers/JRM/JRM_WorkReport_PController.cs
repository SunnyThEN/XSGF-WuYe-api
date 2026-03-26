/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_WorkReport_PController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_WorkReport_P")]
    [PermissionTable(Name = "JRM_WorkReport_P")]
    public partial class JRM_WorkReport_PController : ApiBaseController<IJRM_WorkReport_PService>
    {
        public JRM_WorkReport_PController(IJRM_WorkReport_PService service)
        : base(service)
        {
        }
    }
}

