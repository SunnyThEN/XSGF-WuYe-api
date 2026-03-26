/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PMS_DataBackupController编写
 */
using Microsoft.AspNetCore.Mvc;
using MESTOP.Core.Controllers.Basic;
using MESTOP.Entity.AttributeManager;
using PMS.IServices;
namespace PMS.Controllers
{
    [Route("api/PMS_DataBackup")]
    [PermissionTable(Name = "PMS_DataBackup")]
    public partial class PMS_DataBackupController : ApiBaseController<IPMS_DataBackupService>
    {
        public PMS_DataBackupController(IPMS_DataBackupService service)
        : base(service)
        {
        }
    }
}

