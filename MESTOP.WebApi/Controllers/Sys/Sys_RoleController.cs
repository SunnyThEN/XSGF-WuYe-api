using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using MESTOP.Entity.AttributeManager;
using MESTOP.Entity.DomainModels;
using MESTOP.Sys.IServices;

namespace MESTOP.Sys.Controllers
{
    [Route("api/Sys_Role")]
    [PermissionTable(Name = "Sys_Role")]
    public partial class Sys_RoleController : ApiBaseController<ISys_RoleService>
    {
        public Sys_RoleController(ISys_RoleService service)
        : base("System", "System", "Sys_Role", service)
        {

        }
    }
}


