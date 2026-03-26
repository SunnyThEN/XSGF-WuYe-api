/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_FeedReport_SubAddController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_FeedReport_SubAdd")]
    [PermissionTable(Name = "JRM_FeedReport_SubAdd")]
    public partial class JRM_FeedReport_SubAddController : ApiBaseController<IJRM_FeedReport_SubAddService>
    {
        public JRM_FeedReport_SubAddController(IJRM_FeedReport_SubAddService service)
        : base(service)
        {
        }
    }
}

