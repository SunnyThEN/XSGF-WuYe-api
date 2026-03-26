/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ReprtRMaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ReprtRMaterial")]
    [PermissionTable(Name = "JRM_ReprtRMaterial")]
    public partial class JRM_ReprtRMaterialController : ApiBaseController<IJRM_ReprtRMaterialService>
    {
        public JRM_ReprtRMaterialController(IJRM_ReprtRMaterialService service)
        : base(service)
        {
        }
    }
}

