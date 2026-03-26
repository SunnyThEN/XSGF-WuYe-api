/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JDWOC_WorkOrderController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using CSR_JD.IServices;
namespace CSR_JD.Controllers
{
    [Route("api/JDWOC_WorkOrder")]
    [PermissionTable(Name = "JDWOC_WorkOrder")]
    public partial class JDWOC_WorkOrderController : ApiBaseController<IJDWOC_WorkOrderService>
    {
        public JDWOC_WorkOrderController(IJDWOC_WorkOrderService service)
        : base(service)
        {
        }
    }
}

