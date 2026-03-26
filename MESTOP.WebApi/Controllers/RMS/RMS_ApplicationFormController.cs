/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹RMS_ApplicationFormController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using RMS.IServices;
namespace RMS.Controllers
{
    [Route("api/RMS_ApplicationForm")]
    [PermissionTable(Name = "RMS_ApplicationForm")]
    public partial class RMS_ApplicationFormController : ApiBaseController<IRMS_ApplicationFormService>
    {
        public RMS_ApplicationFormController(IRMS_ApplicationFormService service)
        : base(service)
        {
        }
    }
}

