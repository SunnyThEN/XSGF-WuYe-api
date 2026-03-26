/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PMS_ItemVerController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PMS.IServices;
namespace PMS.Controllers
{
    [Route("api/PMS_ItemVer")]
    [PermissionTable(Name = "PMS_ItemVer")]
    public partial class PMS_ItemVerController : ApiBaseController<IPMS_ItemVerService>
    {
        public PMS_ItemVerController(IPMS_ItemVerService service)
        : base(service)
        {
        }
    }
}

