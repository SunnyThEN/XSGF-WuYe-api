/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_PBomBillMain_JT",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using CSR_JD.Repositories;
using CSR_JD.Services;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using MMS.Repositories;
using WOC.Repositories;
using Infrastructure;
using System.Linq;
using MESTOP.Core.DBManager;

namespace WOC.Controllers
{
    public partial class WOC_PBomBillMain_JTController
    {
        private readonly IWOC_PBomBillMain_JTService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_PBomBillMain_JTController(
            IWOC_PBomBillMain_JTService service,
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

            var pbom = WOC_PBomBillMain_JTRepository.Instance.FindFirst(x => x.ProductName.Contains("膜"));
           if(pbom is not null)
            {

                var ReceiptMain = pbom.MapTo<WOC_ReceiptMain_JT>();
                ReceiptMain.MreceiptMId=Guid.NewGuid();
                if (ReceiptMain is not null)
                {
                    ReceiptMain.AuditStatus = 0;
                    ReceiptMain.SubmitStatus = 0;
                    WOC_ReceiptMain_JTRepository.Instance.Add(ReceiptMain, true);
                }//主表新增
                var orderLists = WOC_PBomBillChild_JTRepository.Instance.Find(x => x.FID == pbom.FID);//子表循环

                int ordermo = 0;
                if (orderLists is not null && orderLists.Count > 0)
                {
                    foreach (var orderList in orderLists)
                    {
                        var ReceiptChild = orderList.MapTo<WOC_ReceiptChild_JT>();
                        ReceiptChild.MreceiptCId = Guid.NewGuid();
                        ReceiptChild.MreceiptMId = ReceiptMain.MreceiptMId;
                        if (ReceiptChild is not null) WOC_ReceiptChild_JTRepository.Instance.Add(ReceiptChild, true);//子表新增
                        //if()
                        //{

                        //    orderLists.r(orderList);
                        //    ordermo = 1;
                        //}

                    }
                    //var orderLs = WOC_PBomBillChild_JTRepository.Instance.Find(x => x.FID == pbom.FID && !x.MaterialName.Contains("膜"));
                    string fentryIds = string.Join(",", orderLists.Where(x => !x.MaterialName.Contains("膜")).Select(x => x.FENTRYID).ToList());


                    //string fentryIds = string.Join(",", orderLs.Select(x => x.FENTRYID).ToList());



                    var order = WOC_ReceiptMain_JTRepository.Instance.FindFirst(x => x.FID == pbom.FID);
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

                        if (order.AuditStatus == 1)//领料成功
                        {
                            string sqla = "update  [MES.TOP].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.shipmentReferCode + "', shipmentReferStatus=1  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var a = DBServerProvider.SqlDapper.ExcuteNonQuery(sqla, null);

                            //select *  from JTDATA.AIS2024NINESKY.dbo.T_BD_STAFF_l WHERE FNAME='吴艳平' 
                            string sqlpickL = "update [MES.TOPold].[dbo].[T_PRD_PICKMTRL] set fpickerId=106167,fcreatorid=129143,FAPPROVERID=100694   where FBILLNO= '" + order.shipmentReferCode + "'  ";

                            var  pickL = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlpickL, null);
                        }
                        else
                        {
                            string sqlb = "update  [MES.TOP].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.Remark.Substring(0,50) + "', shipmentReferStatus=2  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var b = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlb, null);

                        }
                        string sql = "update  WOC_ReceiptMain_JT set  shipmentReferCode='" + order.shipmentReferCode + "', Remark='" + order.Remark + "' ,SubmitStatus=" + order.SubmitStatus + ",AuditStatus=" + order.AuditStatus + " where  MreceiptMId='" + order.MreceiptMId + "'";

                        var s = DBServerProvider.SqlDapper.ExcuteNonQuery(sql, null);
                    }
                }
            }


            string sqldf = @" SELECT T1.*  FROM [MES.TOP].[dbo].[WOC_PBomBillMain_DF]  T1 inner join (SELECT  WorkOrderCode  FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] WHERE   Sort <= 10 AND  ProcessName LIKE '%退火%'   GROUP BY  WorkOrderCode ) T2 ON T1.WorkOrderCode = T2.WorkOrderCode";
            var orderResultDF = await  DBServerProvider.SqlDapper.QueryListAsync<WOC_PBomBillMain_DF>(sqldf, null);
            if (orderResultDF.Count()>0)
            {
                foreach(var pbomDF in orderResultDF)
                { 
                var ReceiptMain = pbomDF.MapTo<WOC_ReceiptMain_DF>();
                ReceiptMain.MreceiptMId = Guid.NewGuid();
                if (ReceiptMain is not null)
                {
                    ReceiptMain.AuditStatus = 0;
                    ReceiptMain.SubmitStatus = 0;
                    WOC_ReceiptMain_DFRepository.Instance.Add(ReceiptMain, true);
                }//主表新增
                var orderLists = WOC_PBomBillChild_DFRepository.Instance.Find(x => x.FID == pbomDF.FID);//子表循环
                    var pbomDFFID = pbomDF.FID;
                int ordermo = 0;
                if (orderLists is not null && orderLists.Count > 0)
                {
                    foreach (var orderList in orderLists)
                    {
                        var ReceiptChild = orderList.MapTo<WOC_ReceiptChild_DF>();
                        ReceiptChild.MreceiptCId = Guid.NewGuid();
                        ReceiptChild.MreceiptMId = ReceiptMain.MreceiptMId;
                        if (ReceiptChild is not null) WOC_ReceiptChild_DFRepository.Instance.Add(ReceiptChild, true);//子表新增
                       
                    }
   
                    string fentryIds = string.Join(",", orderLists.Where(x => !x.MaterialName.Contains("膜")).Select(x => x.FENTRYID).ToList());
               
                    var order = WOC_ReceiptMain_DFRepository.Instance.FindFirst(x => x.FID == pbomDFFID);
                       
                    if (order != null)
                    {
                        Rreturn_Class returnclass = new Rreturn_Class(); 
                        List<string> FBILLNO = new List<string>();
                        FBILLNO.Add(order.FBILLNO);
                        returnclass = CSR_JD_OtherWebApiService.Instance.PRD_PPBOMPush(FBILLNO, fentryIds).Result;
                
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

                        if (order.AuditStatus == 1)//领料成功
                        {
                            string sqla = "update  [MESJSJT].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.shipmentReferCode + "', shipmentReferStatus=1  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var a = DBServerProvider.SqlDapper.ExcuteNonQuery(sqla, null);
                        }
                        else
                        {
                            string sqlb = "update  [MESJSJT].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.Remark.Substring(0, 50) + "', shipmentReferStatus=2  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                            var b = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlb, null);

                        }
                        string sqlc= "update  WOC_ReceiptMain_DF set  shipmentReferCode='" + order.shipmentReferCode + "', Remark='" + order.Remark + "' ,SubmitStatus=" + order.SubmitStatus + ",AuditStatus=" + order.AuditStatus + " where  MreceiptMId='" + order.MreceiptMId + "'";

                        var s = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlc, null);
                            }
                      
                    }
                 }

            }




            string sqljt = @" SELECT T1.*  FROM [MES.TOP].[dbo].[WOC_PBomBillMain_JT]  T1 inner join (SELECT  WorkOrderCode  FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] WHERE   Sort <= 10 AND  ProcessName LIKE '%退火%'  GROUP BY  WorkOrderCode ) T2 ON T1.WorkOrderCode = T2.WorkOrderCode";
            var orderResultJT = await DBServerProvider.SqlDapper.QueryListAsync<WOC_PBomBillMain_JT>(sqljt, null);
            if (orderResultJT.Count() > 0)
            {
                foreach (var pbomJT in orderResultJT)
                {
                    var ReceiptMain = pbomJT.MapTo<WOC_ReceiptMain_JT>();
                    ReceiptMain.MreceiptMId = Guid.NewGuid();
                    if (ReceiptMain is not null)
                    {
                        ReceiptMain.AuditStatus = 0;
                        ReceiptMain.SubmitStatus = 0;
                        WOC_ReceiptMain_JTRepository.Instance.Add(ReceiptMain, true);
                    }//主表新增
                    var orderLists = WOC_PBomBillChild_JTRepository.Instance.Find(x => x.FID == pbomJT.FID);//子表循环

                    var pbomJTFID = pbomJT.FID;

                    int ordermo = 0;
                    if (orderLists is not null && orderLists.Count > 0)
                    {
                        foreach (var orderList in orderLists)
                        {
                            var ReceiptChild = orderList.MapTo<WOC_ReceiptChild_JT>();
                            ReceiptChild.MreceiptCId = Guid.NewGuid();
                            ReceiptChild.MreceiptMId = ReceiptMain.MreceiptMId;
                            if (ReceiptChild is not null) WOC_ReceiptChild_JTRepository.Instance.Add(ReceiptChild, true);//子表新增

                        }

                        string fentryIds = string.Join(",", orderLists.Where(x => !x.MaterialName.Contains("膜")).Select(x => x.FENTRYID).ToList());

                        var order = WOC_ReceiptMain_JTRepository.Instance.FindFirst(x => x.FID == pbomJTFID);
                        if (order != null)
                        {
                            Rreturn_Class returnclass = new Rreturn_Class();
                            List<string> FBILLNO = new List<string>();
                            FBILLNO.Add(order.FBILLNO);
                            returnclass = CSR_JD_OtherWebApiService.Instance.PRD_PPBOMPush(FBILLNO, fentryIds).Result;

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

                            if (order.AuditStatus == 1)//领料成功
                            {
                                string sqla = "update  [MES.TOP].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.shipmentReferCode + "', shipmentReferStatus=1  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                                var a = DBServerProvider.SqlDapper.ExcuteNonQuery(sqla, null);
                            }
                            else
                            {
                                string sqlb = "update  [MES.TOP].[dbo].[WOC_Dispatch_WorkOrder] set  shipmentReferCode='" + order.Remark.Substring(0, 50) + "', shipmentReferStatus=2  where  WorkOrderCode='" + order.WorkOrderCode + "'";

                                var b = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlb, null);

                            }


                            string sqlc = "update  WOC_ReceiptMain_JT set  shipmentReferCode='" + order.shipmentReferCode + "', Remark='" + order.Remark + "' ,SubmitStatus=" + order.SubmitStatus + ",AuditStatus=" + order.AuditStatus + " where  MreceiptMId='" + order.MreceiptMId + "'";

                            var s = DBServerProvider.SqlDapper.ExcuteNonQuery(sqlc, null);
                        }
                    }
                }

            }


            return "";
        }
    }
}
