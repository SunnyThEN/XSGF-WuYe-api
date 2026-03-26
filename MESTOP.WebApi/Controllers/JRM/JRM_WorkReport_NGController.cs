/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_WorkReport_NGController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_WorkReport_NG")]
    [PermissionTable(Name = "JRM_WorkReport_NG")]
    public partial class JRM_WorkReport_NGController : ApiBaseController<IJRM_WorkReport_NGService>
    {
        public JRM_WorkReport_NGController(IJRM_WorkReport_NGService service)
        : base(service)
        {
        }
    }
}

