/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MMS_BOMDetailedController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/MMS_BOMDetailed")]
    [PermissionTable(Name = "MMS_BOMDetailed")]
    public partial class MMS_BOMDetailedController : ApiBaseController<IMMS_BOMDetailedService>
    {
        public MMS_BOMDetailedController(IMMS_BOMDetailedService service)
        : base(service)
        {
        }
    }
}

