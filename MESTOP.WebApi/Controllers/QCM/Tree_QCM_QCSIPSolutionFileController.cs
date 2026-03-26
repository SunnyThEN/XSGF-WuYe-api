/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Tree_QCM_QCSIPSolutionFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/Tree_QCM_QCSIPSolutionFile")]
    [PermissionTable(Name = "Tree_QCM_QCSIPSolutionFile")]
    public partial class Tree_QCM_QCSIPSolutionFileController : ApiBaseController<ITree_QCM_QCSIPSolutionFileService>
    {
        public Tree_QCM_QCSIPSolutionFileController(ITree_QCM_QCSIPSolutionFileService service)
        : base(service)
        {
        }
    }
}

