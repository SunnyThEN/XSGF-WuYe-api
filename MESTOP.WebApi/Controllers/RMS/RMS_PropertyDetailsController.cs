/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹RMS_PropertyDetailsController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using RMS.IServices;
namespace RMS.Controllers
{
    [Route("api/RMS_PropertyDetails")]
    [PermissionTable(Name = "RMS_PropertyDetails")]
    public partial class RMS_PropertyDetailsController : ApiBaseController<IRMS_PropertyDetailsService>
    {
        public RMS_PropertyDetailsController(IRMS_PropertyDetailsService service)
        : base(service)
        {
        }
    }
}

