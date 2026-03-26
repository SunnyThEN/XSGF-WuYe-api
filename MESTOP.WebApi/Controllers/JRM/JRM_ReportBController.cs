/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ReportBController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ReportB")]
    [PermissionTable(Name = "JRM_ReportB")]
    public partial class JRM_ReportBController : ApiBaseController<IJRM_ReportBService>
    {
        public JRM_ReportBController(IJRM_ReportBService service)
        : base(service)
        {
        }
    }
}

