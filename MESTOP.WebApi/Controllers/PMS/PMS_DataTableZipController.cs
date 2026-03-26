/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PMS_DataTableZipController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PMS.IServices;
namespace PMS.Controllers
{
    [Route("api/PMS_DataTableZip")]
    [PermissionTable(Name = "PMS_DataTableZip")]
    public partial class PMS_DataTableZipController : ApiBaseController<IPMS_DataTableZipService>
    {
        public PMS_DataTableZipController(IPMS_DataTableZipService service)
        : base(service)
        {
        }
    }
}

