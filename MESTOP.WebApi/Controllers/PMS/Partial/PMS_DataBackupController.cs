/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PMS_DataBackup",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PMS.IServices;
using MESTOP.Core.Filters;

namespace PMS.Controllers
{
    public partial class PMS_DataBackupController
    {
        private readonly IPMS_DataBackupService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PMS_DataBackupController(
            IPMS_DataBackupService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        //备份数据库方法
        [HttpPost, Route("BackDataBase")]
        [ApiActionPermission]
        public IActionResult BackDataBase(string sqldateName,int PId)
        {

            var msg = _service.BackDataBase( sqldateName, PId);
            return Json(msg);

        }
        //还原数据库方法

        [HttpPost, Route("RestoreDataBaseService")]
        [ApiActionPermission]
        public IActionResult RestoreDataBaseService(int DataBaseID)
        {
            var msg = _service.RestoreDataBaseService(DataBaseID);
            return Json(msg);



        }
    }
}
