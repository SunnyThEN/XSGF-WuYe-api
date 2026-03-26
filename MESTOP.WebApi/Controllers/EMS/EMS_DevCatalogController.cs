/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_DevCatalogController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_DevCatalog")]
    [PermissionTable(Name = "EMS_DevCatalog")]
    public partial class EMS_DevCatalogController : ApiBaseController<IEMS_DevCatalogService>
    {
        public EMS_DevCatalogController(IEMS_DevCatalogService service)
        : base(service)
        {
        }
    }
}

