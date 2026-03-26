/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹RMS_OwnerDetailsController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using RMS.IServices;
namespace RMS.Controllers
{
    [Route("api/RMS_OwnerDetails")]
    [PermissionTable(Name = "RMS_OwnerDetails")]
    public partial class RMS_OwnerDetailsController : ApiBaseController<IRMS_OwnerDetailsService>
    {
        public RMS_OwnerDetailsController(IRMS_OwnerDetailsService service)
        : base(service)
        {
        }
    }
}

