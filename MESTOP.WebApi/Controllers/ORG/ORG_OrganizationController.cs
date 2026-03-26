/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ORG_OrganizationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using ORG.IServices;
namespace ORG.Controllers
{
    [Route("api/ORG_Organization")]
    [PermissionTable(Name = "ORG_Organization")]
    public partial class ORG_OrganizationController : ApiBaseController<IORG_OrganizationService>
    {
        public ORG_OrganizationController(IORG_OrganizationService service)
        : base(service)
        {
        }
    }
}

