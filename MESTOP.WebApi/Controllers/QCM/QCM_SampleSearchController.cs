/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹QCM_SampleSearchController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using QCM.IServices;
namespace QCM.Controllers
{
    [Route("api/QCM_SampleSearch")]
    [PermissionTable(Name = "QCM_SampleSearch")]
    public partial class QCM_SampleSearchController : ApiBaseController<IQCM_SampleSearchService>
    {
        public QCM_SampleSearchController(IQCM_SampleSearchService service)
        : base(service)
        {
        }
    }
}

