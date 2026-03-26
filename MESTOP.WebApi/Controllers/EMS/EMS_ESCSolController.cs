/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EMS_ESCSolController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using EMS.IServices;
namespace EMS.Controllers
{
    [Route("api/EMS_ESCSol")]
    [PermissionTable(Name = "EMS_ESCSol")]
    public partial class EMS_ESCSolController : ApiBaseController<IEMS_ESCSolService>
    {
        public EMS_ESCSolController(IEMS_ESCSolService service)
        : base(service)
        {
        }
    }
}

