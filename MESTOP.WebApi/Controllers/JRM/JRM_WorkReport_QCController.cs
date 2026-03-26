/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_WorkReport_QCController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_WorkReport_QC")]
    [PermissionTable(Name = "JRM_WorkReport_QC")]
    public partial class JRM_WorkReport_QCController : ApiBaseController<IJRM_WorkReport_QCService>
    {
        public JRM_WorkReport_QCController(IJRM_WorkReport_QCService service)
        : base(service)
        {
        }
    }
}

