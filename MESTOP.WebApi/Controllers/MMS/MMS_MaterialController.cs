/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MMS_MaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/MMS_Material")]
    [PermissionTable(Name = "MMS_Material")]
    public partial class MMS_MaterialController : ApiBaseController<IMMS_MaterialService>
    {
        public MMS_MaterialController(IMMS_MaterialService service)
        : base(service)
        {
        }
    }
}

