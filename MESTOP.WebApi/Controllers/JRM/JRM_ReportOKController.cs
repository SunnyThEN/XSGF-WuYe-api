/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ReportOKController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ReportOK")]
    [PermissionTable(Name = "JRM_ReportOK")]
    public partial class JRM_ReportOKController : ApiBaseController<IJRM_ReportOKService>
    {
        public JRM_ReportOKController(IJRM_ReportOKService service)
        : base(service)
        {
        }
    }
}

