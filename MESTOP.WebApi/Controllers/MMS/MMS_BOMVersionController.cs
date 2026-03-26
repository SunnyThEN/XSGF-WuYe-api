/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MMS_BOMVersionController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/MMS_BOMVersion")]
    [PermissionTable(Name = "MMS_BOMVersion")]
    public partial class MMS_BOMVersionController : ApiBaseController<IMMS_BOMVersionService>
    {
        public MMS_BOMVersionController(IMMS_BOMVersionService service)
        : base(service)
        {
        }
    }
}

