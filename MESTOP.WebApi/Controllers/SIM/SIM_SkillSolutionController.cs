/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹SIM_SkillSolutionController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using SIM.IServices;
namespace SIM.Controllers
{
    [Route("api/SIM_SkillSolution")]
    [PermissionTable(Name = "SIM_SkillSolution")]
    public partial class SIM_SkillSolutionController : ApiBaseController<ISIM_SkillSolutionService>
    {
        public SIM_SkillSolutionController(ISIM_SkillSolutionService service)
        : base(service)
        {
        }
    }
}

