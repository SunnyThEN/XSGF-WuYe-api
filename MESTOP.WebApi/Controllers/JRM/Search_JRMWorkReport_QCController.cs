/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Search_JRMWorkReport_QCController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/Search_JRMWorkReport_QC")]
    [PermissionTable(Name = "Search_JRMWorkReport_QC")]
    public partial class Search_JRMWorkReport_QCController : ApiBaseController<ISearch_JRMWorkReport_QCService>
    {
        public Search_JRMWorkReport_QCController(ISearch_JRMWorkReport_QCService service)
        : base(service)
        {
        }
    }
}

