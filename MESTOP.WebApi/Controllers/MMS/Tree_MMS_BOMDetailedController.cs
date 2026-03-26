/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Tree_MMS_BOMDetailedController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using MMS.IServices;
namespace MMS.Controllers
{
    [Route("api/Tree_MMS_BOMDetailed")]
    [PermissionTable(Name = "Tree_MMS_BOMDetailed")]
    public partial class Tree_MMS_BOMDetailedController : ApiBaseController<ITree_MMS_BOMDetailedService>
    {
        public Tree_MMS_BOMDetailedController(ITree_MMS_BOMDetailedService service)
        : base(service)
        {
        }
    }
}

