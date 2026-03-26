/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("QCM_SelfTestList",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using QCM.IServices;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using QCM.Repositories;
using MESTOP.Core.Extensions;
using MESTOP.Core.Utilities;

namespace QCM.Controllers
{
    public partial class QCM_SelfTestListController
    {
        private readonly IQCM_SelfTestListService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public QCM_SelfTestListController(
            IQCM_SelfTestListService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("DelDetail")]
        [ApiActionPermission]
        [AllowAnonymous]
        public ActionResult DelDetail(string ParentId)
        {
            QCM_SelfTestListRepository.Instance.Delete(x => x.DynaID == ParentId.ToGuid(), true);
            return Json(WebResponseContent.Instance.OK());
        }

        [HttpPost, Route("UpdateMain")]
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<object> UpdateMain(string ParentId)
        {
            var MainInfo = await QCM_SelfTestRepository.Instance.FindAsyncFirst(x => x.DynaID == ParentId.ToGuid());
            if (MainInfo.SIPQCChecklistCodeStatus < 3)//子表保存时，查看主表状态，若状态值小于3则置为3
                MainInfo.SIPQCChecklistCodeStatus = 3;
            QCM_SelfTestRepository.Instance.Update(MainInfo, x => new { x.SIPQCChecklistCodeStatus }, true);
            return Json(WebResponseContent.Instance.OK());
        }
    }

}
