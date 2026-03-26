/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Tree_ORG_OrganizationController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using ORG.IServices;
namespace ORG.Controllers
{
    [Route("api/Tree_ORG_Organization")]
    [PermissionTable(Name = "Tree_ORG_Organization")]
    public partial class Tree_ORG_OrganizationController : ApiBaseController<ITree_ORG_OrganizationService>
    {
        public Tree_ORG_OrganizationController(ITree_ORG_OrganizationService service)
        : base(service)
        {
        }
    }
}

