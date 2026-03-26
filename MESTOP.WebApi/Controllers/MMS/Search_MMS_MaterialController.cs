/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_MMS_MaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/Search_MMS_Material")]
    [PermissionTable(Name = "Search_MMS_Material")]
    public partial class Search_MMS_MaterialController : ApiBaseController<ISearch_MMS_MaterialService>
    {
        public Search_MMS_MaterialController(ISearch_MMS_MaterialService service)
        : base(service)
        {
        }
    }
}

