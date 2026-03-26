/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹RMS_PaymentDetailsController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using RMS.IServices;
namespace RMS.Controllers
{
    [Route("api/RMS_PaymentDetails")]
    [PermissionTable(Name = "RMS_PaymentDetails")]
    public partial class RMS_PaymentDetailsController : ApiBaseController<IRMS_PaymentDetailsService>
    {
        public RMS_PaymentDetailsController(IRMS_PaymentDetailsService service)
        : base(service)
        {
        }
    }
}

