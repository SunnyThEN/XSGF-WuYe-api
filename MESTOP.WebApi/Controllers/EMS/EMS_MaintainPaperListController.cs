/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_MaintainPaperListController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_MaintainPaperList")]
    [PermissionTable(Name = "EMS_MaintainPaperList")]
    public partial class EMS_MaintainPaperListController : ApiBaseController<IEMS_MaintainPaperListService>
    {
        public EMS_MaintainPaperListController(IEMS_MaintainPaperListService service)
        : base(service)
        {
        }
    }
}

