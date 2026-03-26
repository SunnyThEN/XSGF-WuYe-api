/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_SplitInfoController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_SplitInfo")]
    [PermissionTable(Name = "JRM_SplitInfo")]
    public partial class JRM_SplitInfoController : ApiBaseController<IJRM_SplitInfoService>
    {
        public JRM_SplitInfoController(IJRM_SplitInfoService service)
        : base(service)
        {
        }
    }
}

