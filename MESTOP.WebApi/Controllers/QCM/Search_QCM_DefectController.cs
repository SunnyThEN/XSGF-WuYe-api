/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_QCM_DefectController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/Search_QCM_Defect")]
    [PermissionTable(Name = "Search_QCM_Defect")]
    public partial class Search_QCM_DefectController : ApiBaseController<ISearch_QCM_DefectService>
    {
        public Search_QCM_DefectController(ISearch_QCM_DefectService service)
        : base(service)
        {
        }
    }
}

