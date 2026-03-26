using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using MESTOP.Entity.DomainModels;
using MESTOP.Sys.IServices;

namespace MESTOP.Sys.Controllers
{
    [Route("api/menu")]
    [ApiController, JWTAuthorize()]
    public partial class Sys_MenuController : ApiBaseController<ISys_MenuService>
    {
        private ISys_MenuService _service { get; set; }
        public Sys_MenuController(ISys_MenuService service) :
            base("System", "System", "Sys_Menu", service)
        {
            _service = service;
        } 
    }
}
