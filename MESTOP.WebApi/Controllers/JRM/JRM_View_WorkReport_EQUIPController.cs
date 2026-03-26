/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_View_WorkReport_EQUIPController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_View_WorkReport_EQUIP")]
    [PermissionTable(Name = "JRM_View_WorkReport_EQUIP")]
    public partial class JRM_View_WorkReport_EQUIPController : ApiBaseController<IJRM_View_WorkReport_EQUIPService>
    {
        public JRM_View_WorkReport_EQUIPController(IJRM_View_WorkReport_EQUIPService service)
        : base(service)
        {
        }
    }
}

