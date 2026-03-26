/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ReportCController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ReportC")]
    [PermissionTable(Name = "JRM_ReportC")]
    public partial class JRM_ReportCController : ApiBaseController<IJRM_ReportCService>
    {
        public JRM_ReportCController(IJRM_ReportCService service)
        : base(service)
        {
        }
    }
}

