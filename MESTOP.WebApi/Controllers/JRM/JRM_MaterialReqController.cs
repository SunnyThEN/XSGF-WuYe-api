/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_MaterialReqController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_MaterialReq")]
    [PermissionTable(Name = "JRM_MaterialReq")]
    public partial class JRM_MaterialReqController : ApiBaseController<IJRM_MaterialReqService>
    {
        public JRM_MaterialReqController(IJRM_MaterialReqService service)
        : base(service)
        {
        }
    }
}

