/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_FeedWorkStationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_FeedWorkStation")]
    [PermissionTable(Name = "JRM_FeedWorkStation")]
    public partial class JRM_FeedWorkStationController : ApiBaseController<IJRM_FeedWorkStationService>
    {
        public JRM_FeedWorkStationController(IJRM_FeedWorkStationService service)
        : base(service)
        {
        }
    }
}

