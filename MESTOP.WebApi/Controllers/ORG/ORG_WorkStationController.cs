/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ORG_WorkStationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using ORG.IServices;
namespace ORG.Controllers
{
    [Route("api/ORG_WorkStation")]
    [PermissionTable(Name = "ORG_WorkStation")]
    public partial class ORG_WorkStationController : ApiBaseController<IORG_WorkStationService>
    {
        public ORG_WorkStationController(IORG_WorkStationService service)
        : base(service)
        {
        }
    }
}

