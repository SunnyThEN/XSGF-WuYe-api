/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_BreakupWorkOrderMain",Enums.ActionPermissionOptions.Search)]
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
using WOC.Repositories;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using FCM.Repositories;
using System.Linq;
using MESTOP.Core.Extensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Infrastructure;

namespace WOC.Controllers
{
    public partial class WOC_BreakupWorkOrderMainController
    {
        private readonly IWOC_BreakupWorkOrderMainService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_BreakupWorkOrderMainController(
            IWOC_BreakupWorkOrderMainService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("BreakupWO")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult BreakupWO([FromBody]  WOC_BreakupWorkOrderMain BreakupWOMain)
        {
            try {
                //休假列表
            //var wolist=    WOC_BreakupWorkOrderChildRepository.Instance.Find(x => x.MWOId==BreakupWOMain.MWOId);


                var HolidayList = FCM_HolidayRepository.Instance.Find(x => x.StartDate >= BreakupWOMain.PlanStartTime && x.StartDate <= BreakupWOMain.PlanEndTime);
           //每日工时列表
            var FCM_Shift= FCM_ShiftRepository.Instance.FindAsIQueryable(x => x.ShiftId == BreakupWOMain.FCM_ShiftId.ToGuid()).FirstOrDefault();
            var TimeList = FCM_ShiftListRepository.Instance.Find(x =>x.ShiftId == BreakupWOMain.FCM_ShiftId.ToGuid());
            

            float? DayManHour = 0;
            if(FCM_Shift  is not null) DayManHour = FCM_Shift.DayManHour;//每日工时
                                                     // 排序
            var isAsc = BreakupWOMain.isAsc;
                                                                                                                                                                                                                                                                                                                     
            var newbkwomain = new WOC_BreakupWorkOrderMain();
            newbkwomain = BreakupWOMain;  
            var newbkwomainlist = new List<WOC_BreakupWorkOrderChild>();

                if (isAsc == "0")
                {
                    DateTime? dtnew=null;
                    foreach (var bkchild in BreakupWOMain.WOC_BreakupWorkOrderChild.OrderBy(x => x.SortNo))
                    {
                        newbkwomain.WOC_BreakupWorkOrderChild.Remove(bkchild);
                        var DayProdQty = bkchild.MaterialWorkTime * DayManHour;//每日产能
                        var SubQty = bkchild.WORequiredQty * bkchild.MasterQTY;//部件需求总量=工单需求数量*BOM需求数量
                        var SubProTime = SubQty / DayProdQty;//需要时间
                        var SubProDay = Math.Floor(SubProTime.Value);//需要
                        var wkhour = Math.Ceiling( Math.Round(DayManHour.Value * (SubProTime.Value- SubProDay), 2));
                      
                     
                        var newhour = string.Empty;
                        if(dtnew==null)
                        {
                            
                           var TimeFast= TimeList.OrderBy(x => x.StartTime).First().StartTime; 
                           
                            if (TimeFast is not null)
                            {
                                
                                var dt = BreakupWOMain.PlanStartTime+ TimeSpan.Parse(TimeFast);
                               
                                bkchild.PlanStartTime =dt;
                            } 
                            else
                            {
                                bkchild.PlanStartTime = BreakupWOMain.PlanStartTime;
                            }  
                        }
                        else
                        {
                        bkchild.PlanStartTime = dtnew;
                        }
                        var EndT1 = TimeSpan.Parse(TimeList.OrderByDescending(x => x.EndTime).First().EndTime);
                        var EndT2 = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        var newendtime = TimeSpan.Parse("1.00:00:00") - EndT1 + EndT2;

                        //var newendtime = TimeSpan.Parse(TimeL[0].StartTime) + TimeSpan.Parse("1.00:00:00") - TimeSpan.Parse(TimeL[tm].EndTime);


                        var PlanEndTime = bkchild.PlanStartTime.Value.AddHours(SubProDay*24+ wkhour);
                        var endtime= TimeSpan.Parse(PlanEndTime.Hour+":"+ PlanEndTime.Minute+":"+PlanEndTime.Second);
                        //var StartT  = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        //var EndT = TimeSpan.Parse(TimeList.OrderByDescending(x => x).First().StartTime);
                        //int tmQ = 0;
                        var TimeL=TimeList.OrderBy(x => x.StartTime).ToList();
                        //TimeSpan Tspan= new TimeSpan(0);
                        for (int tm =0;tm< TimeL.Count();tm++)
                        {
                            if(tm>0&& endtime > TimeSpan.Parse(TimeL[tm].StartTime))
                            {
                                TimeSpan Tspan =  TimeSpan.Parse(TimeL[tm].StartTime) - TimeSpan.Parse(TimeL[tm - 1].EndTime);
                                PlanEndTime = PlanEndTime + Tspan;
                                endtime = endtime + Tspan;
                            }
                            if ((tm==TimeL.Count()-1)&&endtime> TimeSpan.Parse(TimeL[tm].EndTime))
                            {
                                //var newendtime = TimeSpan.Parse(TimeL[0].StartTime)+TimeSpan.Parse("1.00:00:00")  - TimeSpan.Parse(TimeL[tm].EndTime);
                                PlanEndTime = PlanEndTime + newendtime;
                                var nendtime = TimeSpan.Parse(PlanEndTime.Hour + ":" + PlanEndTime.Minute + ":" + PlanEndTime.Second);
                                for (int t = 0; t < TimeL.Count(); t++)
                                {
                                    if (t > 0 && nendtime > TimeSpan.Parse(TimeL[t].StartTime))
                                    {
                                        TimeSpan Tspan = TimeSpan.Parse(TimeL[t].StartTime) - TimeSpan.Parse(TimeL[t - 1].EndTime);
                                        PlanEndTime = PlanEndTime + Tspan;
                                   
                                    }
                                }

                            }
                        }

                        var stratime = TimeSpan.Parse(bkchild.PlanStartTime.Value.Hour + ":" + bkchild.PlanStartTime.Value.Minute + ":" + bkchild.PlanStartTime.Value.Second);

                        if (stratime == EndT1)
                        {
                            bkchild.PlanStartTime = bkchild.PlanStartTime+ newendtime;
                        }

                        bkchild.PlanEndTime = PlanEndTime;
                        dtnew = bkchild.PlanEndTime;
                        newbkwomainlist.Add(bkchild);
                    }
                    newbkwomain.WOC_BreakupWorkOrderChild.AddRange(newbkwomainlist);
                }

                if (isAsc == "1")
                {
                    DateTime? dtnew = null;
                    foreach (var bkchild in BreakupWOMain.WOC_BreakupWorkOrderChild.OrderByDescending(x => x.SortNo))
                    {
                        newbkwomain.WOC_BreakupWorkOrderChild.Remove(bkchild);
                        var DayProdQty = bkchild.MaterialWorkTime * DayManHour;//每日产能
                        var SubQty = bkchild.WORequiredQty * bkchild.MasterQTY;//部件需求总量=工单需求数量*BOM需求数量
                        var SubProTime = SubQty / DayProdQty;//需要时间
                        var SubProDay = Math.Floor(SubProTime.Value);//需要
                        //var wkhour = Math.Round(DayManHour.Value * SubProTime.Value, 0);
                        //var addhour = 0;
                        //var newhour = string.Empty;  
                     
                        var wkhour = Math.Ceiling(Math.Round(DayManHour.Value * (SubProTime.Value - SubProDay), 2));



                        if (dtnew == null)
                        {
                            var TimeFast = TimeList.OrderByDescending(x => x.EndTime).First().EndTime;

                            if (TimeFast is not null)
                            {

                                var dt = BreakupWOMain.PlanEndTime + TimeSpan.Parse(TimeFast);

                                
                                bkchild.PlanEndTime = dt;
                            }
                            else
                            {
                                bkchild.PlanEndTime = BreakupWOMain.PlanEndTime;
                            }
                        
                        }
                        else
                        {
                            bkchild.PlanEndTime = dtnew;
                        }
                        var EndT1 = TimeSpan.Parse(TimeList.OrderByDescending(x => x.EndTime).First().EndTime);
                        var EndT2 = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        var newendtime = TimeSpan.Parse("1.00:00:00")- EndT1 + EndT2;
                       

                        var PlanStartTime = bkchild.PlanEndTime.Value.AddHours(SubProDay*-24- wkhour);
                        var startime = TimeSpan.Parse(PlanStartTime.Hour + ":" + PlanStartTime.Minute + ":" + PlanStartTime.Second);
                        //var StartT  = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        //var EndT = TimeSpan.Parse(TimeList.OrderByDescending(x => x).First().StartTime);
                        //int tmQ = 0;
                        var TimeL = TimeList.OrderByDescending(x => x.EndTime).ToList();
                        //TimeSpan Tspan= new TimeSpan(0);
                        for (int tm = 0; tm < TimeL.Count(); tm++)
                        {
                             //var newendtime = TimeSpan.Parse("1.00:00:00") - TimeSpan.Parse(TimeL[0].EndTime)+TimeSpan.Parse(TimeL[tm].StartTime);


                            if (tm > 0 && startime < TimeSpan.Parse(TimeL[tm].EndTime))
                            {
                                TimeSpan Tspan = TimeSpan.Parse(TimeL[tm].EndTime) - TimeSpan.Parse(TimeL[tm - 1].StartTime);
                                PlanStartTime = PlanStartTime + Tspan;
                                startime = startime + Tspan;
                            }
                            if ((tm == TimeL.Count() - 1) && startime < TimeSpan.Parse(TimeL[tm].StartTime))
                            { 
                               PlanStartTime = PlanStartTime - newendtime;
                                var nendtime = TimeSpan.Parse(PlanStartTime.Hour + ":" + PlanStartTime.Minute + ":" + PlanStartTime.Second);
                                for (int t = 0; t < TimeL.Count(); t++)
                                {
                                    if (t > 0 && nendtime < TimeSpan.Parse(TimeL[t].EndTime))
                                    {
                                        TimeSpan Tspan = TimeSpan.Parse(TimeL[tm].EndTime) - TimeSpan.Parse(TimeL[tm - 1].StartTime);
                                        PlanStartTime = PlanStartTime + Tspan;

                                    }
                                }

                            }
                        }

                        var endtime = TimeSpan.Parse(bkchild.PlanEndTime.Value.Hour + ":" + bkchild.PlanEndTime.Value.Minute + ":" + bkchild.PlanEndTime.Value.Second);

                        if (endtime == EndT2)
                        {
                            bkchild.PlanEndTime = bkchild.PlanEndTime - newendtime;
                        }
                        bkchild.PlanStartTime = PlanStartTime;

                        dtnew = bkchild.PlanStartTime;
                        newbkwomainlist.Add(bkchild);
                    }
        
                    newbkwomain.WOC_BreakupWorkOrderChild.AddRange(newbkwomainlist.OrderBy(x => x.SortNo));
                }
                if (isAsc == "2")
                {
                    DateTime? dtnew = null;
                    foreach (var bkchild in BreakupWOMain.WOC_BreakupWorkOrderChild.OrderBy(x => x.SortNo))
                    {
                        newbkwomain.WOC_BreakupWorkOrderChild.Remove(bkchild);
                        var DayProdQty = bkchild.MaterialWorkTime * DayManHour;//每日产能
                        var SubQty = bkchild.WORequiredQty * bkchild.MasterQTY;//部件需求总量=工单需求数量*BOM需求数量
                        var SubProTime = SubQty / DayProdQty;//需要时间
                        var SubProDay = Math.Floor(SubProTime.Value);//需要
                        var wkhour = Math.Ceiling(Math.Round(DayManHour.Value * (SubProTime.Value - SubProDay), 2));


                        var newhour = string.Empty;
                        if (dtnew == null)
                        {

                            var TimeFast = TimeList.OrderBy(x => x.StartTime).First().StartTime;

                            if (TimeFast is not null)
                            {

                                var dt = BreakupWOMain.PlanStartTime + TimeSpan.Parse(TimeFast);

                                bkchild.PlanStartTime = dt;
                            }
                            else
                            {
                                bkchild.PlanStartTime = BreakupWOMain.PlanStartTime;
                            }
                        }
                        else
                        {
                            bkchild.PlanStartTime = dtnew;
                        }
                        var EndT1 = TimeSpan.Parse(TimeList.OrderByDescending(x => x.EndTime).First().EndTime);
                        var EndT2 = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        var newendtime = TimeSpan.Parse("1.00:00:00") - EndT1 + EndT2;

                        //var newendtime = TimeSpan.Parse(TimeL[0].StartTime) + TimeSpan.Parse("1.00:00:00") - TimeSpan.Parse(TimeL[tm].EndTime);


                        var PlanEndTime = bkchild.PlanStartTime.Value.AddHours(SubProDay * 24 + wkhour);
                        var endtime = TimeSpan.Parse(PlanEndTime.Hour + ":" + PlanEndTime.Minute + ":" + PlanEndTime.Second);
                        //var StartT  = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        //var EndT = TimeSpan.Parse(TimeList.OrderByDescending(x => x).First().StartTime);
                        //int tmQ = 0;
                        var TimeL = TimeList.OrderBy(x => x.StartTime).ToList();
                        //TimeSpan Tspan= new TimeSpan(0);
                        for (int tm = 0; tm < TimeL.Count(); tm++)
                        {
                            if (tm > 0 && endtime > TimeSpan.Parse(TimeL[tm].StartTime))
                            {
                                TimeSpan Tspan = TimeSpan.Parse(TimeL[tm].StartTime) - TimeSpan.Parse(TimeL[tm - 1].EndTime);
                                PlanEndTime = PlanEndTime + Tspan;
                                endtime = endtime + Tspan;
                            }
                            if ((tm == TimeL.Count() - 1) && endtime > TimeSpan.Parse(TimeL[tm].EndTime))
                            {
                                //var newendtime = TimeSpan.Parse(TimeL[0].StartTime)+TimeSpan.Parse("1.00:00:00")  - TimeSpan.Parse(TimeL[tm].EndTime);
                                PlanEndTime = PlanEndTime + newendtime;
                                var nendtime = TimeSpan.Parse(PlanEndTime.Hour + ":" + PlanEndTime.Minute + ":" + PlanEndTime.Second);
                                for (int t = 0; t < TimeL.Count(); t++)
                                {
                                    if (t > 0 && nendtime > TimeSpan.Parse(TimeL[t].StartTime))
                                    {
                                        TimeSpan Tspan = TimeSpan.Parse(TimeL[t].StartTime) - TimeSpan.Parse(TimeL[t - 1].EndTime);
                                        PlanEndTime = PlanEndTime + Tspan;

                                    }
                                }

                            }
                        }

                        var stratime = TimeSpan.Parse(bkchild.PlanStartTime.Value.Hour + ":" + bkchild.PlanStartTime.Value.Minute + ":" + bkchild.PlanStartTime.Value.Second);

                        if (stratime == EndT1)
                        {
                            bkchild.PlanStartTime = bkchild.PlanStartTime + newendtime;
                        }

                        bkchild.PlanEndTime = PlanEndTime;
                        dtnew = bkchild.PlanStartTime.Value.AddHours(BreakupWOMain.Interval);
                        newbkwomainlist.Add(bkchild);
                    }
                    newbkwomain.WOC_BreakupWorkOrderChild.AddRange(newbkwomainlist);
                }
                if (isAsc == "3")
                {
                    DateTime? dtnew = null;
                    foreach (var bkchild in BreakupWOMain.WOC_BreakupWorkOrderChild.OrderByDescending(x => x.SortNo))
                    {
                        newbkwomain.WOC_BreakupWorkOrderChild.Remove(bkchild);
                        var DayProdQty = bkchild.MaterialWorkTime * DayManHour;//每日产能
                        var SubQty = bkchild.WORequiredQty * bkchild.MasterQTY;//部件需求总量=工单需求数量*BOM需求数量
                        var SubProTime = SubQty / DayProdQty;//需要时间
                        var SubProDay = Math.Floor(SubProTime.Value);//需要
                                                                     //var wkhour = Math.Round(DayManHour.Value * SubProTime.Value, 0);
                                                                     //var addhour = 0;
                                                                     //var newhour = string.Empty;  

                        var wkhour = Math.Ceiling(Math.Round(DayManHour.Value * (SubProTime.Value - SubProDay), 2));



                        if (dtnew == null)
                        {
                            var TimeFast = TimeList.OrderByDescending(x => x.EndTime).First().EndTime;

                            if (TimeFast is not null)
                            {

                                var dt = BreakupWOMain.PlanEndTime + TimeSpan.Parse(TimeFast);


                                bkchild.PlanEndTime = dt;
                            }
                            else
                            {
                                bkchild.PlanEndTime = BreakupWOMain.PlanEndTime;
                            }

                        }
                        else
                        {
                            bkchild.PlanEndTime = dtnew;
                        }
                        var EndT1 = TimeSpan.Parse(TimeList.OrderByDescending(x => x.EndTime).First().EndTime);
                        var EndT2 = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        var newendtime = TimeSpan.Parse("1.00:00:00") - EndT1 + EndT2;


                        var PlanStartTime = bkchild.PlanEndTime.Value.AddHours(SubProDay * -24 - wkhour);
                        var startime = TimeSpan.Parse(PlanStartTime.Hour + ":" + PlanStartTime.Minute + ":" + PlanStartTime.Second);
                        //var StartT  = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                        //var EndT = TimeSpan.Parse(TimeList.OrderByDescending(x => x).First().StartTime);
                        //int tmQ = 0;
                        var TimeL = TimeList.OrderByDescending(x => x.EndTime).ToList();
                        //TimeSpan Tspan= new TimeSpan(0);
                        for (int tm = 0; tm < TimeL.Count(); tm++)
                        {
                            //var newendtime = TimeSpan.Parse("1.00:00:00") - TimeSpan.Parse(TimeL[0].EndTime)+TimeSpan.Parse(TimeL[tm].StartTime);


                            if (tm > 0 && startime < TimeSpan.Parse(TimeL[tm].EndTime))
                            {
                                TimeSpan Tspan = TimeSpan.Parse(TimeL[tm].EndTime) - TimeSpan.Parse(TimeL[tm - 1].StartTime);
                                PlanStartTime = PlanStartTime + Tspan;
                                startime = startime + Tspan;
                            }
                            if ((tm == TimeL.Count() - 1) && startime < TimeSpan.Parse(TimeL[tm].StartTime))
                            {
                                PlanStartTime = PlanStartTime - newendtime;
                                var nendtime = TimeSpan.Parse(PlanStartTime.Hour + ":" + PlanStartTime.Minute + ":" + PlanStartTime.Second);
                                for (int t = 0; t < TimeL.Count(); t++)
                                {
                                    if (t > 0 && nendtime < TimeSpan.Parse(TimeL[t].EndTime))
                                    {
                                        TimeSpan Tspan = TimeSpan.Parse(TimeL[tm].EndTime) - TimeSpan.Parse(TimeL[tm - 1].StartTime);
                                        PlanStartTime = PlanStartTime + Tspan;

                                    }
                                }

                            }
                        }

                        var endtime = TimeSpan.Parse(bkchild.PlanEndTime.Value.Hour + ":" + bkchild.PlanEndTime.Value.Minute + ":" + bkchild.PlanEndTime.Value.Second);

                        if (endtime == EndT2)
                        {
                            bkchild.PlanEndTime = bkchild.PlanEndTime - newendtime;
                        }
                        bkchild.PlanStartTime = PlanStartTime;
                        dtnew = bkchild.PlanEndTime.Value.AddHours(BreakupWOMain.Interval*-1);
                        //dtnew = bkchild.PlanEndTime;
                        newbkwomainlist.Add(bkchild);
                    }

                    newbkwomain.WOC_BreakupWorkOrderChild.AddRange(newbkwomainlist.OrderBy(x => x.SortNo));
                }

                return JsonNormal(newbkwomain);
            }
            catch(Exception ex)
            {
                return JsonNormal(ex.Message);
            }
         
            //var MainWF= PPM_WorkFlowRepository.Instance.Find(x=>x.ProcessFlowCode==saveDataModel.MainProcessFlowCode);
            //return null;
        }

        [HttpPost, Route("WOC_BreakupWorkOrder")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult WOC_BreakupWorkOrder([FromBody] WOC_BreakupWorkOrderMain BreakupWOMain)
        {


            WOC_WorkOrder wkorder = BreakupWOMain.MapTo<WOC_WorkOrder>();
            

            foreach (var dwonow in BreakupWOMain.WOC_BreakupWorkOrderChild)
            {
              
                try
                {   var childwo = WOC_BreakupWorkOrderChildRepository.Instance.Find(x => x.WorkOrderCode == dwonow.WorkOrderCode && x.ProcessFlowCode == dwonow.ProcessFlowCode).FirstOrDefault();

    
                    wkorder.ParentId = childwo.MWOId;
                    wkorder.MWOId = 0;
                    wkorder.ParentWorkOrderCode= childwo.ParentWorkOrderCode;
                    wkorder.MainProcessFlowCode = childwo.ParentProcessFlowCode;
                    wkorder.ProcessFlowCode = childwo.ProcessFlowCode;
                    wkorder.ProcessFlowName = childwo.ProcessFlowName;
                    wkorder.ProductName = childwo.ProductName;
                    wkorder.ProductCode = childwo.ProductCode;
                    wkorder.ProductShortCode = childwo.ProductShortCode;
                    wkorder.Orderlevel = 2;
                    wkorder.WORequiredQty = dwonow.WORequiredQty * dwonow.MasterQTY;
                   
                             var pw = ("00" + dwonow.SortNo);
                    wkorder.WorkOrderCode = BreakupWOMain.WorkOrderCode + "-" + pw.Substring(pw.Length - 3);//;
                        wkorder.PlanEndTime = dwonow.PlanEndTime;
                    wkorder.PlanStartTime = dwonow.PlanStartTime;
                        var findwo = WOC_WorkOrderRepository.Instance.Find(x => x.WorkOrderCode == wkorder.WorkOrderCode &&x.PlanStartTime==wkorder.PlanStartTime && x.PlanEndTime == wkorder.PlanEndTime && x.ProcessFlowCode == wkorder.ProcessFlowCode&&x.Orderlevel==2).FirstOrDefault();
                        if(findwo is null)
                        { 
                        WOC_WorkOrderRepository.Instance.Add(wkorder, true);
                        }
                    
                    //if(dwonow.isAscDay==1)
                    //{
                    //    var TimeList = FCM_ShiftListRepository.Instance.Find(x => x.ShiftId == BreakupWOMain.FCM_ShiftId.ToGuid());

                       
                    //    var EndT1 = TimeSpan.Parse(TimeList.OrderBy(x => x.StartTime).First().StartTime);
                    //    var EndT2 = TimeSpan.Parse(TimeList.OrderByDescending(x => x.EndTime).First().EndTime);

                    //    DateTime d1 = dwonow.PlanStartTime.Value;
                    //    DateTime d2 = dwonow.PlanEndTime.Value;
                    //       var hdays=      d2.Subtract(d1).Days+1;

                    //    var Addendtime = EndT2 - TimeSpan.Parse(d1.Hour + ":" + d1.Minute + ":" + d1.Second);
                    //    var Addstarttime = TimeSpan.Parse(d1.Hour + ":" + d1.Minute + ":" + d1.Second)- EndT1;
                    //    wkorder.PlanEndTime = dwonow.PlanEndTime;
                    //    for (int m=1; m<=hdays;m++)
                    //    {
                    //        wkorder.MWOId = 0;
                    //        var pw = ("00" + i);
                    //        wkorder.WorkOrderCode = BreakupWOMain.WorkOrderCode + "-" + pw.Substring(pw.Length - 3);//;
                    //        if (m == 1)
                    //        {
                    //            wkorder.PlanStartTime = d1;
                    //        }
                    //        else
                    //        {
                    //            wkorder.PlanStartTime = d1.AddDays(m) - Addstarttime;
                    //        } 
                    //        if (m == hdays) { wkorder.PlanEndTime = d2; }
                    //        else
                    //        {
                    //            wkorder.PlanEndTime = d1.AddDays(m) + Addendtime;
                    //        }
                    //        var findwo = WOC_WorkOrderRepository.Instance.Find(x => x.WorkOrderCode == wkorder.WorkOrderCode && x.PlanStartTime == wkorder.PlanStartTime && x.PlanEndTime == wkorder.PlanEndTime && x.ProcessFlowCode == wkorder.ProcessFlowCode && x.Orderlevel == 2).FirstOrDefault();
                    //        if (findwo is null)
                    //        {
                    //            WOC_WorkOrderRepository.Instance.Add(wkorder, true);
                    //        }
                    //        i = i + m;

                    //    }
                             
                            
                   
                    //}
                }
                catch (Exception e)
                {
                    return Json(WebResponseContent.Instance.Error(e.Message));

                }



            }
            return Json(WebResponseContent.Instance.OK());
        }
    }
}
