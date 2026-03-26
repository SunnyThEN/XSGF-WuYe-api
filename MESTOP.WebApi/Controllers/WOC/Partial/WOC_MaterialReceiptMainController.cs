      /*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_MaterialReceiptMain",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using MESTOP.Core.Filters;
using MESTOP.Core.Utilities;
using Microsoft.AspNetCore.Authorization;
using WOC.Repositories;
using CSR_JD.Services;
using System.Net;
using StackExchange.Redis;
using MESTOP.Core.DBManager;
using CSR_JD.Repositories;
using MESTOP.Core.BaseProvider;
using MMS.Repositories;
using OfficeOpenXml.Style;
using CSR_JD.IRepositories;
using System.Linq;
using Infrastructure;

namespace WOC.Controllers
{
    public partial class WOC_MaterialReceiptMainController
    {
        private readonly IWOC_MaterialReceiptMainService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_MaterialReceiptMainController(
            IWOC_MaterialReceiptMainService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

 


        [HttpPost, Route("PRD_PickMtrlSubmit")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        public async Task<object> PRD_PickMtrlSubmit([FromBody] WOC_MaterialReceiptMain row)
        {
          
            var Recpipt = await WOC_MaterialReceiptMainRepository.Instance.FindAsyncFirst(x => x.MreceiptMId == row.MreceiptMId);
            if (Recpipt == null)
            {
                return WebResponseContent.Instance.Error("未找到领料单");
            }
            try
            {
                List<string> MtrlNO = new List<string>();
                MtrlNO.Add(Recpipt.shipmentReferCode);
                var returnclass = await CSR_JD_OtherWebApiService.Instance.PRD_PickMtrlSubmit(MtrlNO);

                if (returnclass.msg == "200")
                {
                    row.shipmentReferCode = Recpipt.shipmentReferCode;
                    row.AuditFBILLNO = returnclass.Numbers;
                    row.SubmitStatus = 1;
                    WOC_MaterialReceiptMainRepository.Instance.Update(row, true);


                }
                else
                {
                    return WebResponseContent.Instance.Error(returnclass.msg);
                }
            }
            catch (Exception ex)
            {
                return WebResponseContent.Instance.Error(ex.Message);
            }
            return WebResponseContent.Instance.OK();
        }


        [HttpPost, Route("PRD_PickMtrlAudit")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        public async Task<object> PRD_PickMtrlAudit([FromBody] WOC_MaterialReceiptMain row)
        {
            //PRD_PickMtrlSubmit
            //PRD_PickMtrlAudit
            var Recpipt = await WOC_MaterialReceiptMainRepository.Instance.FindAsyncFirst(x => x.MreceiptMId == row.MreceiptMId);
            if (Recpipt == null)
            {
                return WebResponseContent.Instance.Error("未找到领料单");
            }
            try
            {
                List<string> MtrlNO = new List<string>();
                MtrlNO.Add(Recpipt.shipmentReferCode);
                var returnclass = await CSR_JD_OtherWebApiService.Instance.PRD_PickMtrlAudit(MtrlNO);

                if (returnclass.msg == "200")
                {
                    row.shipmentReferCode = Recpipt.shipmentReferCode;
                    row.AuditStatus = 1;
                    WOC_MaterialReceiptMainRepository.Instance.Update(row, true);


                }
                else
                {
                    return WebResponseContent.Instance.Error(returnclass.msg);
                }
            }
            catch (Exception ex)
            {
                return WebResponseContent.Instance.Error(ex.Message);
            }
            return WebResponseContent.Instance.OK();
        }
    }
}
