/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MMS_BOMMaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/MMS_BOMMaterial")]
    [PermissionTable(Name = "MMS_BOMMaterial")]
    public partial class MMS_BOMMaterialController : ApiBaseController<IMMS_BOMMaterialService>
    {
        public MMS_BOMMaterialController(IMMS_BOMMaterialService service)
        : base(service)
        {
        }
    }
}

