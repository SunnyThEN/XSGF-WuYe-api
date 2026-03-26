/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_WorkOrderFather_Temp",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using MESTOP.Core.Utilities;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using Infrastructure;
using WOC.Repositories;
using MESTOP.Core.DBManager;
using MESTOP.Core.Extensions;
using static CSR_JD.Services.CSR_JD_OtherWebApiService;
using System.Linq.Expressions;
using WOC.IRepositories;
using CSR_JD.Repositories;
using MMS.Repositories;
using System.Linq;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace WOC.Controllers
{
    public partial class WOC_WorkOrderFather_TempController
    {
        private readonly IWOC_WorkOrderFather_TempService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_WorkOrderFather_TempController(
            IWOC_WorkOrderFather_TempService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("Addlist")]
        [ApiActionPermission]
        [AllowAnonymous]
        public ActionResult Addlist([FromBody] WOC_WorkOrderFather_Temp wOC_WorkOrder)
        {

            var childlist = wOC_WorkOrder.WOC_WorkOrderChild_Temp;//子表
            var workflowlist = wOC_WorkOrder.WOC_WorkOrderFatherWorkFlow_Temp;//工序状态
                                                                              //WOC_WorkOrder s = new WOC_WorkOrder();
                                                                         //s = wOC_WorkOrder.MapTo<WOC_WorkOrder>;

           var order = WOC_WorkOrderFather_TempRepository.Instance.FindFirst(x => x.FID == wOC_WorkOrder.FID && wOC_WorkOrder.WOStatus == 2);
            if (order != null)
            {
                order.WOStatus = 3;

                WOC_WorkOrderFather_TempRepository.Instance.Update(order);
            }
            //else
            //{
            //    return JsonNormal(WebResponseContent.Instance.Error("不能重复递交数据"));
            //}
            //if(s is not null)    WOC_WorkOrderRepository.Instance.Add(s, true);
            try
            {
                if (childlist != null)
                {
                    int ci = 0;

 
             
                    foreach (var child in childlist)  //子表循环 子工单表
                    {
                        var woder = WOC_Dispatch_WorkOrderRepository.Instance.FindFirst(x => x.MWOId == child.MWOId && x.WorkOrderCode == child.WorkOrderCode);
                       
                       
                        if (woder is null)
                        {
                            ci++;
                            child.WorkOrderDesc = wOC_WorkOrder.WorkOrderDesc;
                            child.PlanStartTime = wOC_WorkOrder.PlanStartTime;
                            child.PlanEndTime = wOC_WorkOrder.PlanEndTime;
                            float ml = 0;  //获取长度
                            int F_PASF_VOLUME = 0; string F_PASF_NEWPREFIX = "";
                    
                            CSR_JD_MaterialLenth materiall = new CSR_JD_MaterialLenth();
                            MMS_Material mdesc = new MMS_Material();
                            float auxWidth = 0;
                            // T_PRD_PPBOMENTRYRepository.Instance.FindFirst(x => x.FENTRYID == child.MWOId);
                            // var materialstr= T_PRD_PPBOMENTRY_CRepository.Instance.FindFirst(x => x.FENTRYID == child.MWOId  );

                           var  sqlstr=  "select *   FROM [MES.TOPold].[dbo].[CSR_JD_PBomBillViewChild] where WorkOrderCode='" + child.WorkOrderCode + "' and FNEEDQTY > 0  and FSTDQTY > 0 and  MaterialName not like '%膜%'";
                           
                            var materialstr = DBServerProvider.SqlDapper.QueryFirst<CSR_JD_PBomBillViewChild>(sqlstr, null);

                            // CSR_JD_PBomBillViewChildRepository.Instance.FindFirst(x => x.WorkOrderCode == child.WorkOrderCode && x.FNEEDQTY > 0 && x.FSTDQTY > 0 && !x.MaterialName.Contains("膜"));
                            if (materialstr is not null)
                            {

                                materiall = CSR_JD_MaterialLenthRepository.Instance.FindFirst(x => x.FLOTID == materialstr.FLOT);
                                if (materiall is not null)
                                {
                                    float.TryParse(materiall.F_PASF_LENTH, out ml);//获取长度
                                }
                                var auxWidthUnit = T_PRD_PPBOMAUXRepository.Instance.FindFirst(x => x.FENTRYID == materialstr.FENTRYID);
                                if (auxWidthUnit is not null && auxWidthUnit.FDATAVALUE != null)
                                {

                                    float.TryParse(auxWidthUnit.FDATAVALUE, out auxWidth);//获取来料宽度
                                }

                                //获取物料描述
                                mdesc = MMS_MaterialRepository.Instance.FindFirst(x => x.MaterialCode == materialstr.MaterialCode);

                                if (auxWidth == 0 && mdesc.WidthUnit != null)
                                {

                                    auxWidth = mdesc.WidthUnit.Value;
                                }

                            }


                            //获取产出品规格

                            string ProductDesc = string.Empty;
                            var prodesc = MMS_MaterialRepository.Instance.FindFirst(x => x.MaterialCode == child.ProductCode);
                            if (prodesc is not null) ProductDesc = prodesc.MaterialDesc;//产品规格

                            string processName = "纵剪分切冷轧吹膜";

                            if (workflowlist != null)//工序子表
                            {
                                var childadd = child.MapTo<WOC_Dispatch_WorkOrder>();
                                childadd.WID = System.Guid.NewGuid();
                           
                                var jrmmax = workflowlist.Max(x => x.Sort);
                                var jrmin = workflowlist.Min(x => x.Sort);

                            
                                foreach (var flow in workflowlist)//主工单
                                {
                             
                                    var FlowRep = WOC_Dispatch_WorkFlowRepository.Instance.FindFirst(x => x.MWOId == child.MWOId && x.ProcessCode == flow.ProcessCode && x.Sort == flow.Sort);
                                    if (FlowRep == null)//找到相同工序
                                    {

                                        //  var DispatchCard_WorkFlow = WOC_DispatchCard_WorkFlow_TempRepository.Instance.FindFirst(x => x.MWOId == child.MWOId && x.ProcessCode == flow.ProcessCode);//子工单
                                        //复制一个工艺 

                                        WOC_Dispatch_WorkFlow flowadd = child.MapTo<WOC_Dispatch_WorkFlow>();
                                      
                                        flowadd.Sort=flow.Sort;

                                        flowadd.F_PASF_VOLUME = child.F_PASF_VOLUME;
                                        flowadd.F_PASF_NEWPREFIX = child.F_PASF_NEWPREFIX;

                                        flowadd.WorkStationCode=flow.WorkStationCode;
                                        flowadd.WorkStationName=flow.WorkStationName;
                                        flowadd.ProcessRequest=flow.ProcessRequest;
                                        //----------------------必填项------------------
                                        flowadd.ProcessStepId = flow.ProcessStepId;
                                        flowadd.ProcessName = flow.ProcessName;
                                        flowadd.ProcessCode = flow.ProcessCode;
                                        flowadd.ProcessStatus = "1";
                                        flowadd.WOStatus = "3";
                                        flowadd.ProductCode = childadd.ProductCode;
                                        flowadd.WorkOrderCode = childadd.WorkOrderCode;
                                        flowadd.WORequiredQty=childadd.WORequiredQty;
                                        flowadd.MWOId = childadd.MWOId;
                                        flowadd.isSplitting = "1";
                                        //-------------------------------------------
                                        flowadd.ProductDesc = ProductDesc; 
                                            flowadd.PID = System.Guid.NewGuid();
                                            flowadd.WID = childadd.WID;
                                            flowadd.LengthUnit = ml;
                                            flowadd.isInSubmit = 0;
                                            flowadd.IsInWarehouse = 0;
                                            flowadd.isFinalJug = 0;
                                            flowadd.isInAudit = 0;  
                                            if (mdesc is not null)
                                            {
                                                flowadd.MaterialCode = mdesc.MaterialCode;
                                                flowadd.MaterialName = mdesc.MaterialName;
                                                flowadd.MaterialDesc = mdesc.MaterialDesc;
                                            flowadd.WidthUnit = auxWidth;
                                                flowadd.ThicknessUnit = mdesc.ThicknessUnit;
                                            } 
                                            if (jrmmax == flowadd.Sort) flowadd.isProducts = 1;
                                            flowadd.OutThicknessUnit = flowadd.ThicknessUnit;
                                            flowadd.OutWidthUnit = flowadd.WidthUnit; 
                                            if (materialstr is not null)
                                            {
                                                flowadd.WeightUnit = materialstr.FMUSTQTY.GetFloat();
                                                flowadd.FLOT = materialstr.FLOT;
                                                flowadd.FLOT_TEXT = materialstr.FLOT_TEXT;
                                                flowadd.FLOTNumber = materialstr.FLOT_TEXT; 
                                            }
                                            if (flowadd.ProcessName.Contains("退火") && flow.Sort == jrmin)
                                            {
                                                flowadd.OutThicknessUnit = prodesc.ThicknessUnit;
                                                flowadd.OutWidthUnit = auxWidth;
                                                flowadd.OutLengthUnit = ml;
                                                flowadd.OutWeightUnit = materialstr.FMUSTQTY.GetFloat();
                                                flowadd.isSplitting = "1";
                                                flowadd.ProcessStatus = "6";
                                            } 
                                            if (processName.Contains(flowadd.ProcessName) && prodesc is not null)
                                            {
                                                flowadd.OutThicknessUnit = prodesc.ThicknessUnit;
                                                flowadd.OutWidthUnit = prodesc.WidthUnit;
                                        }
                                        try { 
                                            WOC_Dispatch_WorkFlowRepository.Instance.Add(flowadd, true);
                                        }
                                        catch (Exception ex)
                                        {
                                            string e=ex.Message;
                                        }
                                            var flowfather = WOC_WorkOrderFatherWorkFlow_TempRepository.Instance.FindFirst(x => x.FID == child.FID && x.ProcessCode == flow.ProcessCode);
                                            if (flowfather is not null && ci == 1)
                                            {
                                                flowfather.WorkStationCode = flow.WorkStationCode;
                                                flowfather.WorkStationName = flow.WorkStationName;
                                                WOC_WorkOrderFatherWorkFlow_TempRepository.Instance.Update(flowfather, true);

                                            }
                                   
                                    }
                                }

                                childadd.WOStatus = "3";
                                if (materialstr is not null) childadd.FLOT_TEXT = materialstr.FLOT_TEXT;

                                WOC_Dispatch_WorkOrderRepository.Instance.Add(childadd, true);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return JsonNormal(WebResponseContent.Instance.Error("递交的数据错误"));
            }
            return JsonNormal(WebResponseContent.Instance.OK("递交成功"));
        }


        [HttpPost, Route("updateWOStatus")]
        [ApiActionPermission]
        public ActionResult updateWOStatus([FromBody] WOC_WorkOrderFather_Temp wOC_WorkOrder)
        {
            var wocfather = WOC_WorkOrderFather_TempRepository.Instance.FindFirst(x => x.FID == wOC_WorkOrder.FID);
            if (wocfather is not null)
            {
                wocfather.WOStatus = wOC_WorkOrder.WOStatus;
                WOC_WorkOrderFather_TempRepository.Instance.Update(wocfather, true);

                var wocchild = WOC_Dispatch_WorkOrderRepository.Instance.Find(x => x.ParentWorkOrderCode == wocfather.ParentWorkOrderCode);
                foreach (var childchild in wocchild)
                {

                    childchild.WOStatus = wOC_WorkOrder.WOStatus.ToString();
                    WOC_Dispatch_WorkOrderRepository.Instance.Update(childchild, true);
                }

            }



            return JsonNormal(WebResponseContent.Instance.OK("递交成功"));
        }
        //[HttpPost, Route("Add")]
        //public override ActionResult Add([FromBody] SaveModel saveModel)
        //{



        //    return base.Add(saveModel);
        //}



    }
    //public class addlist
    //{

    //  public  WOC_WorkOrderFather_Temp maintable { get; set; }


    //    public List<WOC_WorkOrderChild_Temp> orderlist { get; set; }


    //    public List<WOC_WorkOrderFatherWorkFlow_Temp>  flowlist { get; set; }

    //}

}
