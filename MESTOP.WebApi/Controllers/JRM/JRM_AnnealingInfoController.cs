/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_AnnealingInfoController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_AnnealingInfo")]
    [PermissionTable(Name = "JRM_AnnealingInfo")]
    public partial class JRM_AnnealingInfoController : ApiBaseController<IJRM_AnnealingInfoService>
    {
        public JRM_AnnealingInfoController(IJRM_AnnealingInfoService service)
        : base(service)
        {
        }
    }
}

