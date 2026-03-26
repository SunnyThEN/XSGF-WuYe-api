/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ViewWorkReport_PERSController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ViewWorkReport_PERS")]
    [PermissionTable(Name = "JRM_ViewWorkReport_PERS")]
    public partial class JRM_ViewWorkReport_PERSController : ApiBaseController<IJRM_ViewWorkReport_PERSService>
    {
        public JRM_ViewWorkReport_PERSController(IJRM_ViewWorkReport_PERSService service)
        : base(service)
        {
        }
    }
}

