/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹SIM_SkillSolutionFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using SIM.IServices;
namespace SIM.Controllers
{
    [Route("api/SIM_SkillSolutionFile")]
    [PermissionTable(Name = "SIM_SkillSolutionFile")]
    public partial class SIM_SkillSolutionFileController : ApiBaseController<ISIM_SkillSolutionFileService>
    {
        public SIM_SkillSolutionFileController(ISIM_SkillSolutionFileService service)
        : base(service)
        {
        }
    }
}

