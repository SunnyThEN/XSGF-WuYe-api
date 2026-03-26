/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_PBomBillMain_DF",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using CSR_JD.Services;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using WOC.Repositories;
using Infrastructure;
using System.Linq;
using MESTOP.Core.DBManager;
using StackExchange.Redis;
using WOC.IRepositories;

namespace WOC.Controllers
{
    public partial class WOC_PBomBillMain_DFController
    {
        private readonly IWOC_PBomBillMain_DFService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_PBomBillMain_DFController(
            IWOC_PBomBillMain_DFService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("PRD_PPBOMPush")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> PRD_PPBOMPush()
        {
            //用料清单列表

            //WOC_MaterialReceiptMainRepository.Instance.DbContext.ContextId("E42F8000-F668-4523-8A31-217BC7BD52D7").Find(x => 1 == 1);

            var pbom = WOC_PBomBillMain_DFRepository.Instance.FindFirst(x => 1 == 1);
            if(pbom is not null)
            {

                var ReceiptMain = pbom.MapTo<WOC_ReceiptMain_DF>();
                ReceiptMain.MreceiptMId = Guid.NewGuid();
                if (ReceiptMain is not null) 
                {
                    ReceiptMain.AuditStatus = 0;
                    ReceiptMain.SubmitStatus = 0;
                    WOC_ReceiptMain_DFRepository.Instance.Add(ReceiptMain, true); 
                }//主表新增
                var orderLists = WOC_PBomBillChild_DFRepository.Instance.Find(x => x.FID == pbom.FID );//子表循环
                int ordermo = 0;
                if (orderLists is not null&& orderLists.Count>0)
                {
                    foreach (var orderList in orderLists)
                    {
                        var ReceiptChild = orderList.MapTo<WOC_ReceiptChild_DF>();
                        ReceiptChild.MreceiptCId = Guid.NewGuid();
                        ReceiptChild.MreceiptMId = ReceiptMain.MreceiptMId;
                        if (ReceiptChild is not null)   WOC_ReceiptChild_DFRepository.Instance.Add(ReceiptChild, true);//子表新增

                        //if (orderList.MaterialName.Contains("膜"))
                        //{

                        //    orderLists.Remove(orderList);
                        //    ordermo = 1;
                        //}
                    }
                    //string fentryIds = string.Join(",", orderLists.Select(x => x.FENTRYID).ToList());
                    //var orderLs = WOC_PBomBillChild_DFRepository.Instance.Find(x => x.FID == pbom.FID &&); 

                    string fentryIds = string.Join(",", orderLists.Where(x => !x.MaterialName.Contains("膜")).Select(x => x.FENTRYID).ToList());


                    WOC_ReceiptMain_DF order = await  WOC_ReceiptMain_DFRepository.Instance.FindFirstAsync(x => x.FID == pbom.FID);
                    if (order != null)
                    {
                        Rreturn_Class returnclass = new Rreturn_Class();
                        //if (ordermo == 1)
                        //{
                        //    List<string> FBILLNO = new List<string>();
                        //    FBILLNO.Add("");
                        //    returnclass = CSR_JD_OtherWebApiService.Instance.PRD_PPBOMPush(FBILLNO, fentryIds).Result;
                        //}
                        //else
                        //{
                        List<string> FBILLNO = new List<string>();
                            FBILLNO.Add(order.FBILLNO);
                            returnclass = CSR_JD_OtherWebApiService.Instance.PRD_PPBOMPush(FBILLNO, fentryIds).Result;
                        //}
                       
                    //List<string> FBILLNO = new List<string>();
                    //FBILLNO.Add(order.FBILLNO);
                    //returnclass = CSR_JD_OtherWebApiService.Instance.PRD_PPBOMPush(FBILLNO, fentryIds).Result;
                    order.AuditStatus = 0;
                    order.SubmitStatus = 0;
                    if (returnclass.msg == "200")
                    {
                        order.shipmentReferCode = returnclass.Numbers;



                        Rreturn_Class returnclass2 = new Rreturn_Class();
                        List<string> MtrlNO = new List<string>();
                        MtrlNO.Add(returnclass.Numbers);
                        returnclass2 = CSR_JD_OtherWebApiService.Instance.PRD_PickMtrlSubmit(MtrlNO).Result;
                        if (returnclass2.msg == "200")
                        {
                            order.SubmitStatus = 1;
                            Rreturn_Class returnclass3 = new Rreturn_Class();
                            List<string> MtrlNO2 = new List<string>();
                            MtrlNO2.Add(returnclass.Numbers);
                            returnclass3 = CSR_JD_OtherWebApiService.Instance.PRD_PickMtrlAudit(MtrlNO2).Result;
                            if (returnclass3.msg == "200")
                            {
                                order.AuditStatus = 1;
                        
                            }
                            else
                            {

                                order.Remark = returnclass3.msg;

                            }
                        }
                        else
                        {

                            order.Remark = returnclass2.msg;

                        }
                    }
                    else
                    {
                        order.Remark = returnclass.msg;
                     
                    }
                        if (order.AuditStatus==1)//领料成功
                        { 
                            string sqla = "update  [MESJSJT].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.shipmentReferCode + "', shipmentReferStatus=1  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var a = DBServerProvider.SqlDapper.ExcuteNonQuery(sqla, null);

                            //select *  from JTDATA.AIS2024NINESKY.dbo.T_BD_STAFF_l WHERE FNAME='王晓茜' 
                            string sqlpickL = "update [MES.TOPold].[dbo].[T_PRD_PICKMTRL] set fpickerId=105233,fcreatorid=100698,FAPPROVERID=100694   where FBILLNO= '" + order.shipmentReferCode + "'  ";

                            var pickL = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlpickL, null);
                        }
                        else
                        {
                            string sqlb = "update  [MESJSJT].[dbo].[WOC_Dispatch_WorkOrder] set   shipmentReferCode='" + order.Remark.Substring(0, 50) + "', shipmentReferStatus=2  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var b = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlb, null);

                        }

                        string sql = "update  WOC_ReceiptMain_DF set  shipmentReferCode='" + order.shipmentReferCode + "', Remark='" + order.Remark + "' ,SubmitStatus=" + order.SubmitStatus + ",AuditStatus=" + order.AuditStatus + " where  MreceiptMId='" + order.MreceiptMId+"'";

                        var s = DBServerProvider.SqlDapper.ExcuteNonQuery(sql, null);
                        //WOC_ReceiptMain_DFRepository.Instance.Update(order, true);
                    }

                }
            }

            return "";
        }
    }
}
