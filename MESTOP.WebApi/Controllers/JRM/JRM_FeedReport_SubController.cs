/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_FeedReport_SubController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_FeedReport_Sub")]
    [PermissionTable(Name = "JRM_FeedReport_Sub")]
    public partial class JRM_FeedReport_SubController : ApiBaseController<IJRM_FeedReport_SubService>
    {
        public JRM_FeedReport_SubController(IJRM_FeedReport_SubService service)
        : base(service)
        {
        }
    }
}

