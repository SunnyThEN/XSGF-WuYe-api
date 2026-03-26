/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹JRM_ProductionReport1Controller编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using JRM.IServices;
namespace JRM.Controllers
{
    [Route("api/JRM_ProductionReport1")]
    [PermissionTable(Name = "JRM_ProductionReport1")]
    public partial class JRM_ProductionReport1Controller : ApiBaseController<IJRM_ProductionReport1Service>
    {
        public JRM_ProductionReport1Controller(IJRM_ProductionReport1Service service)
        : base(service)
        {
        }
    }
}

