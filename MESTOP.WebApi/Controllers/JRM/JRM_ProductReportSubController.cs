/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ProductReportSubController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ProductReportSub")]
    [PermissionTable(Name = "JRM_ProductReportSub")]
    public partial class JRM_ProductReportSubController : ApiBaseController<IJRM_ProductReportSubService>
    {
        public JRM_ProductReportSubController(IJRM_ProductReportSubService service)
        : base(service)
        {
        }
    }
}

