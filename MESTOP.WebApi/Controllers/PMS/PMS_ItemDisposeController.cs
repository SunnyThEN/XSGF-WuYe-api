/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PMS_ItemDisposeController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PMS.IServices;
namespace PMS.Controllers
{
    [Route("api/PMS_ItemDispose")]
    [PermissionTable(Name = "PMS_ItemDispose")]
    public partial class PMS_ItemDisposeController : ApiBaseController<IPMS_ItemDisposeService>
    {
        public PMS_ItemDisposeController(IPMS_ItemDisposeService service)
        : base(service)
        {
        }
    }
}

