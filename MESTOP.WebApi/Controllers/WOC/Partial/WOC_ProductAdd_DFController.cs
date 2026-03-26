/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_ProductAdd_DF",Enums.ActionPermissionOptions.Search)]
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
using Microsoft.AspNetCore.Authorization;
using WOC.Repositories;
using WOC.Services;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.ConditionalFormatting;
using MESTOP.Core.BaseProvider;
using CSR_JD.Repositories;
using static CSR_JD.Services.FINSTOCK;

namespace WOC.Controllers
{
    public partial class WOC_ProductAdd_DFController
    {
        private readonly IWOC_ProductAdd_DFService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_ProductAdd_DFController(
            IWOC_ProductAdd_DFService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost, Route("PRD_InWare")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> PRD_InWare()
        {
            //用料清单列表

            //WOC_MaterialReceiptMainRepository.Instance.DbContext.ContextId("E42F8000-F668-4523-8A31-217BC7BD52D7").Find(x => 1 == 1);

            //var product = WOC_ProductAdd_DFRepository.Instance.FindFirst(x => x.IsInWarehouse == 0|| x.IsInWarehouse ==null);
            var product = WOC_ProductAdd_DFRepository.Instance.FindFirst(x => (x.IsInWarehouse == 0 || x.IsInWarehouse == null) && (x.MarkNumber == 0 || x.MarkNumber == null));
            if (product is not null) 
            { 
                await WOC_ProductAdd_DFService.Instance.InWare(product);
            }
            else 
            { 
            ////问题1 包含徐刚站线重新入库
            //var upall = WOC_ProductAdd_DFRepository.Instance.Find(x => x.IsInWarehouse == 2&& x.isInSubmit == null && x.ERPRemark.Contains("徐刚"));
            //if (upall.Count > 0)
            //{
            //    upall.ForEach(x => { x.ERPRemark = ""; x.MarkNumber = 0; x.IsInWarehouse = 0; });
            //        WOC_ProductAdd_DFRepository.Instance.UpdateRange(upall, x => new { x.ERPRemark, x.MarkNumber, x.IsInWarehouse }, true);
            //}
            }

            return "";
        }


        [HttpPost, Route("DFMoClose")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> DFMoClose()
        {
            //用料清单列表


            var molist = await T_PRD_MOENTRY_ARepository.Instance.FindAsync(x => x.FSTATUS == "4"|| x.FSTATUS == "5");// 4开工


            foreach (var mo in molist)
            {
                var PWorkOrder = await T_PRD_MORepository.Instance.FindAsyncFirst(x => x.FID == mo.FID&&x.FPRDORGID==100727);// 4开工
                //if (PWorkOrder is not null)
                //{
                //    WOC_ProductAdd_DFService.Instance.DFMoForceClose(mo.FENTRYID, PWorkOrder.FBILLNO);
                //}

                if (PWorkOrder is not null)
                {
                    var womc = await T_PRD_MOENTRYRepository.Instance.FindAsyncFirst(x => x.FID == mo.FID && x.FENTRYID == mo.FENTRYID);// 4开工
                    if (womc is not null)
                    {

                        string Fseq = "00" + womc.FSEQ.ToString();
                        var Fleght = Fseq.Length - 3;
                        var workordercode = PWorkOrder.FBILLNO + "-" + Fseq.Substring(Fleght);
                        WOC_ProductAdd_DFService.Instance.DFMoForceClose(mo.FENTRYID, PWorkOrder.FBILLNO, workordercode);
                    }


                }
            }


            return "";


        }
    }
}
