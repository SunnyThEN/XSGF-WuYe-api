/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("QCM_BatchJug",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.Utilities;
using WOC.Repositories;

namespace QCM.Controllers
{
    public partial class QCM_BatchJugController
    {
        private readonly IQCM_BatchJugService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public QCM_BatchJugController(
            IQCM_BatchJugService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("BatchAdd")]
        [ApiActionPermission]
        [AllowAnonymous]
        public ActionResult BatchAdd([FromBody] object batchList)
        {
             List<QCM_BatchJug> batch = batchList as List<QCM_BatchJug>;
            foreach (var item in batch)
            {
                QCM_BatchJugRepository.Instance.Add(item, true);
            }
            return JsonNormal(WebResponseContent.Instance.OK());
        }

        [HttpPost, Route("BatchUpdate")]
        [ApiActionPermission]
        [AllowAnonymous]
        public  async Task<ActionResult> BatchUpdate([FromBody] List<QCM_BatchJug> batchList)
        {
            foreach (var item in batchList)
            {
                QCM_BatchJugRepository.Instance.Update(item, true);
                var flowInfo =await WOC_Dispatch_WorkFlowRepository.Instance.FindFirstAsync(x => x.NEWFLOT == item.NEWFLOT);
                flowInfo.ProcessStatus = "4";
                WOC_Dispatch_WorkFlowRepository.Instance.Detached(flowInfo);
                WOC_Dispatch_WorkFlowRepository.Instance.Update(flowInfo, x => new { x.ProcessStatus }, true);
            }
            return JsonNormal(WebResponseContent.Instance.OK());
        }

    }
}
