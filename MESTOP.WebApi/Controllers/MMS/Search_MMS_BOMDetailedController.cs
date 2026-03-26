/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_MMS_BOMDetailedController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/Search_MMS_BOMDetailed")]
    [PermissionTable(Name = "Search_MMS_BOMDetailed")]
    public partial class Search_MMS_BOMDetailedController : ApiBaseController<ISearch_MMS_BOMDetailedService>
    {
        public Search_MMS_BOMDetailedController(ISearch_MMS_BOMDetailedService service)
        : base(service)
        {
        }
    }
}

