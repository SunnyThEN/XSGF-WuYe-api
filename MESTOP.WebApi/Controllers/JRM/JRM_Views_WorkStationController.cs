/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_Views_WorkStationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_Views_WorkStation")]
    [PermissionTable(Name = "JRM_Views_WorkStation")]
    public partial class JRM_Views_WorkStationController : ApiBaseController<IJRM_Views_WorkStationService>
    {
        public JRM_Views_WorkStationController(IJRM_Views_WorkStationService service)
        : base(service)
        {
        }
    }
}

