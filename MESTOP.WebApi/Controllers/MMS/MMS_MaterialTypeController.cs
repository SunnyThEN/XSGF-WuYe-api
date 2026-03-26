/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MMS_MaterialTypeController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/MMS_MaterialType")]
    [PermissionTable(Name = "MMS_MaterialType")]
    public partial class MMS_MaterialTypeController : ApiBaseController<IMMS_MaterialTypeService>
    {
        public MMS_MaterialTypeController(IMMS_MaterialTypeService service)
        : base(service)
        {
        }
    }
}

