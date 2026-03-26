/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_Report_AController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_Report_A")]
    [PermissionTable(Name = "JRM_Report_A")]
    public partial class JRM_Report_AController : ApiBaseController<IJRM_Report_AService>
    {
        public JRM_Report_AController(IJRM_Report_AService service)
        : base(service)
        {
        }
    }
}

