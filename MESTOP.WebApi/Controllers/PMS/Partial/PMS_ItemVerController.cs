/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PMS_ItemVer",Enums.ActionPermissionOptions.Search)]
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
using System.IO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace PMS.Controllers
{
    public partial class PMS_ItemVerController
    {
        private readonly IPMS_ItemVerService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PMS_ItemVerController(
            IPMS_ItemVerService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        //--------------------------压缩文件夹方法--------------FHS
        [HttpPost, Route("CompressDirectory")]
        //[ApiActionPermission]
        //[AllowAnonymous]
        public IActionResult CompressDirectory(int ItemID)
        {

            var msg = _service.CompressDirectory(ItemID);
            return Json(msg);
        }

        //文件上传FHS
        [HttpPost, Route("UploadFile")]
        //[ApiActionPermission]
        //[AllowAnonymous]
        public IActionResult UploadFile(string fileNamePath, string uriString)
        {

            var msg = _service.UploadFile(fileNamePath, uriString);
            return Json(msg);
        }

        public override IActionResult Upload(IEnumerable<IFormFile> fileInput)
        {
            return base.Upload(fileInput);
        }

        //压缩包解压方法FHS
        [HttpPost, Route("UnZip")]
        [ApiActionPermission]
        //[AllowAnonymous]
        public IActionResult UnZip([FromBody] PMS_ItemVer pMS_Item)
        {
            var msg = _service.UnZip((int)pMS_Item.VerId);
            return Json(msg);
        }

        //文件下载FHS
        [HttpPost, Route("DownloadFile")]
        [ApiActionPermission]
        //[AllowAnonymous]
        public IActionResult DownloadFile(string DownloadPath, string DownGoPath)
        {

            _service.DownloadFile(DownloadPath, DownGoPath);
            return null;
        }

        //文件分层--SFH
        [HttpPost, Route("FileDivided")]
        [ApiActionPermission]
        //[AllowAnonymous]
        public IActionResult FileDivided(string dirPath, int ItemId, string ItemType,int level, string ItemEng,string UploadPath,int? PId)
        {
            _service.AddFile(UploadPath);
            var msg =  _service.FileDivided(dirPath, ItemId, ItemType, level, ItemEng, PId);
            
            return Json(msg);
        }
    }
}
