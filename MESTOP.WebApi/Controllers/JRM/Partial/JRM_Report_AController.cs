/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_Report_A",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using WOC.Repositories;
using Microsoft.AspNetCore.Authorization;
using Autofac.Core;
using JRM.Repositories;
using Castle.Core.Internal;
using MESTOP.Core.DBManager;
using MESTOP.Core.Extensions;
using System.Linq;
using System.Xml.XPath;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MESTOP.Core.BaseProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualBasic;
using Nancy;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using StackExchange.Redis;
using OfficeOpenXml.Style;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Update.Internal;
using SkiaSharp;
using JRM.Services;
using System.Data;
using MESTOP.Core.Utilities;

namespace JRM.Controllers
{
    public partial class JRM_Report_AController
    {
        private readonly IJRM_Report_AService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_Report_AController(
            IJRM_Report_AService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("board_tuihuo")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult>   board_tuihuo()
        {
           var da =await _service.dashboad("退火");
            return Json(da); 
        }

        [HttpPost, Route("board_tuozhi")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> board_tuozhi()
        {
            var da = await _service.dashboad("脱脂");
            return Json(da);
        }

        [HttpPost, Route("board_zongjian")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> board_zongjian()
        {
            var da = await _service.dashboad("纵剪");
            return Json(da);
        }



        [HttpPost, Route("board_pingzheng")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> board_pingzheng()
        {
            var da = await _service.dashboad("平整");
            return Json(da);
        }


        [HttpPost, Route("board_dunhua")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<IActionResult> board_dunhua()
        {
            var da = await _service.dashboad("钝化");
            return Json(da);
        }

     

        [HttpPost, Route("GetTreeTableRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetTreeTableRootData([FromBody] PageDataOptions options)
        {
      
            var queryA = JRM_Report_ARepository.Instance.Find(x =>1==1).ToList();

            options = options ?? new PageDataOptions();

            List<SearchParameters> searchParametersList = new List<SearchParameters>();
            if (!string.IsNullOrEmpty(options.Wheres))
            {
                try
                {
                    searchParametersList = options.Wheres.DeserializeObject<List<SearchParameters>>();
                }
                catch { }
            }
            var processValue = string.Empty;
            var workstationValue = string.Empty;
            if (searchParametersList.Count > 0)
            {
                for (int i = 0; i < searchParametersList.Count; i++)
                {
                    SearchParameters x = searchParametersList[i];
                    x.DisplayType = x.DisplayType.GetDBCondition();


                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "NEWFLOT")
                    {
                        var FINDFLOT = JRM_Report_ARepository.Instance.FindFirst(s => s.NEWFLOT.Contains(x.Value) || s.FLOT_TEXT.Contains(x.Value) || s.MainFlot.Contains(x.Value));
                        if (FINDFLOT is not null)
                        {
                            queryA = queryA.Where(s => s.MainFlot == FINDFLOT.MainFlot).ToList();

                            queryA.Where(s => s.FLOTNumber == FINDFLOT.MainFlot).ToList().ForEach(x => { x.FLOTNumber = null; });
                        }
                    }
                }
            }




            var roleRepository = queryA.OrderBy(x => x.ParentWorkOrderCode)
           .ThenBy(x => x.NEWFLOT).ThenBy(x => x.Sort).AsQueryable();

            string fs = options.Wheres;



            var rows = queryA.Where(x => x.FatherFlot == null).AsQueryable().
            TakeOrderByPage(options.Page, options.Rows)
            .OrderBy(x => x.ParentWorkOrderCode).ThenBy(x => x.NEWFLOT)
            .ThenBy(x => x.Sort)

            .Select(s => new
            { 
                s.PID,
                s.WID,
                s.MWOId,
                s.Sort,
                s.ProcessStepId,
                s.ProcessName,
                s.ProcessCode,
                s.ParentWorkOrderCode,
                s.WorkOrderCode,
                s.ProductCode,
                s.ProductName,
                s.ProcessFlowCode,
                s.ProcessFlowName,
                s.WORequiredQty,
                s.PlanStartTime,
                s.PlanEndTime,
                s.WOStatus,
                s.RealStartTime,
                s.RealEndTime,
                s.OrgCode,
                s.OrgName,
                s.Orderlevel,
                s.BOMVersion,
                s.FLOT,
                s.FENTRYID,
                s.WorkStationCode,
                s.WorkStationName,
                s.operatorworkers,
                s.Reportingworkers,
                s.ProcessStatus,
                s.TeamGroup,
                s.Isinspection,
                s.Participants,
                s.OutThicknessUnit,
                s.OutLengthUnit,
                s.OutWidthUnit,
                s.OutWeightUnit,
                s.ThicknessUnit,
                s.LengthUnit,
                s.WidthUnit,
                s.WeightUnit,
                s.NEWFLOT,
                s.isSplitting,
                s.FLOT_TEXT,
                s.MaterialDesc,
                s.MaterialCode,
                s.MaterialName,
                s.MaterialGrade,
                s.QualityStatus,
                s.NextProcess,
                s.PreviousProcess,
                s.ProcessRequest,
                s.WorkOrderDesc,
                s.ParentId,
                s.FeedSort,
                s.FLOTNumber,
                s.isProducts,
                s.Result,
                s.isFinalJug,
                s.ProductDesc,
                s.F_PASF_VOLUME,
                s.F_PASF_NEWPREFIX,
                s.ERpId,
                s.DefectName,
                s.Remark,
                s.RequestNo,
                s.IsInWarehouse,
                s.isInSubmit,
                s.isInAudit,
                s.CoatingName,
                s.ThicknessTol,
                s.WidthTol,
                s.Meters,
                s.Burr,
                s.YieldStr,
                s.TensileStr,
                s.BreakElo,
                s.SurfaceRou_Up,
                s.SurfaceRou_Down,
                s.SurfaceGlo,
                s.VickersHar,
                s.RockwellHar,
                s.NickelThk,
                s.Iron_NickelThk,
                s.SaltSpr,
                s.PeelStr,
                s.HeatSealStr,
                s.YieldToStrRat,
                s.FilmThk,
                s.BasebandThk,
                s.ChromiumThk,
                s.HR30T,
                s.HRB,
                s.HR30N,
                s.HNC,
                s.HV,
                s.LowRoller,
                s.UpRoller,
                s.YieldStrReL,
                s.YieldStrReH,
                s.YieldStrRp02,
                s.SingleRollMet,
                s.SingleRollWid,
                s.SingleRollWe,
                s.Elo,
                s.EloA80,
                s.EloA50,
                s.GrossWeight,
                s.StockCode,
                s.ERPRemark,
                s.StockName,
                s.Annex,
                s.CreateDate,
                s.CreateID,
                s.Creator,
                s.Modifier,
                s.ModifyDate,
                s.ModifyID,
                s.WorkChildOrderDesc,
                s.TThickness,
                s.TWidth,
                s.MThickness,
                s.MWidth,
                s.Inspectors,
                s.InspectDate,
                s.FPRODUCTTYPE,
                s.isSave,
                s.ReportAudit,
                s.ReportReviewer,
                s.MaterialOutDesc,
                s.MarkNumber,
                s.MainFlot,
                s.FlotLevel,
                s.FatherFlot,
                hasChildren = roleRepository.Any(x => x.FatherFlot == s.PID)
            }).ToList();
            
            return JsonNormal(new { total = queryA.Count(), rows });
        }


        /// <summary>
        ///treetable 获取子节点数据
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("getTreeTableChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> GetTreeTableChildrenData(Guid PID)
        {
            //点击节点时，加载子节点数据
            var query = JRM_Report_ARepository.Instance.FindAsIQueryable(x => true);
            var rows = await query.OrderBy(x => x.ParentWorkOrderCode)
            .ThenBy(x => x.NEWFLOT).ThenBy(x => x.Sort).Where(x => x.FatherFlot == PID) 
              .Select(s => new
              {
                  s.PID,
                  s.WID,
                  s.MWOId,
                  s.Sort,
                  s.ProcessStepId,
                  s.ProcessName,
                  s.ProcessCode,
                  s.ParentWorkOrderCode,
                  s.WorkOrderCode,
                  s.ProductCode,
                  s.ProductName,
                  s.ProcessFlowCode,
                  s.ProcessFlowName,
                  s.WORequiredQty,
                  s.PlanStartTime,
                  s.PlanEndTime,
                  s.WOStatus,
                  s.RealStartTime,
                  s.RealEndTime,
                  s.OrgCode,
                  s.OrgName,
                  s.Orderlevel,
                  s.BOMVersion,
                  s.FLOT,
                  s.FENTRYID,
                  s.WorkStationCode,
                  s.WorkStationName,
                  s.operatorworkers,
                  s.Reportingworkers,
                  s.ProcessStatus,
                  s.TeamGroup,
                  s.Isinspection,
                  s.Participants,
                  s.OutThicknessUnit,
                  s.OutLengthUnit,
                  s.OutWidthUnit,
                  s.OutWeightUnit,
                  s.ThicknessUnit,
                  s.LengthUnit,
                  s.WidthUnit,
                  s.WeightUnit,
                  s.NEWFLOT,
                  s.isSplitting,
                  s.FLOT_TEXT,
                  s.MaterialDesc,
                  s.MaterialCode,
                  s.MaterialName,
                  s.MaterialGrade,
                  s.QualityStatus,
                  s.NextProcess,
                  s.PreviousProcess,
                  s.ProcessRequest,
                  s.WorkOrderDesc,
                  s.ParentId,
                  s.FeedSort,
                  s.FLOTNumber,
                  s.isProducts,
                  s.Result,
                  s.isFinalJug,
                  s.ProductDesc,
                  s.F_PASF_VOLUME,
                  s.F_PASF_NEWPREFIX,
                  s.ERpId,
                  s.DefectName,
                  s.Remark,
                  s.RequestNo,
                  s.IsInWarehouse,
                  s.isInSubmit,
                  s.isInAudit,
                  s.CoatingName,
                  s.ThicknessTol,
                  s.WidthTol,
                  s.Meters,
                  s.Burr,
                  s.YieldStr,
                  s.TensileStr,
                  s.BreakElo,
                  s.SurfaceRou_Up,
                  s.SurfaceRou_Down,
                  s.SurfaceGlo,
                  s.VickersHar,
                  s.RockwellHar,
                  s.NickelThk,
                  s.Iron_NickelThk,
                  s.SaltSpr,
                  s.PeelStr,
                  s.HeatSealStr,
                  s.YieldToStrRat,
                  s.FilmThk,
                  s.BasebandThk,
                  s.ChromiumThk,
                  s.HR30T,
                  s.HRB,
                  s.HR30N,
                  s.HNC,
                  s.HV,
                  s.LowRoller,
                  s.UpRoller,
                  s.YieldStrReL,
                  s.YieldStrReH,
                  s.YieldStrRp02,
                  s.SingleRollMet,
                  s.SingleRollWid,
                  s.SingleRollWe,
                  s.Elo,
                  s.EloA80,
                  s.EloA50,
                  s.GrossWeight,
                  s.StockCode,
                  s.ERPRemark,
                  s.StockName,
                  s.Annex,
                  s.CreateDate,
                  s.CreateID,
                  s.Creator,
                  s.Modifier,
                  s.ModifyDate,
                  s.ModifyID,
                  s.WorkChildOrderDesc,
                  s.TThickness,
                  s.TWidth,
                  s.MThickness,
                  s.MWidth,
                  s.Inspectors,
                  s.InspectDate,
                  s.FPRODUCTTYPE,
                  s.isSave,
                  s.ReportAudit,
                  s.ReportReviewer,
                  s.MaterialOutDesc,
                  s.MarkNumber,
                  s.MainFlot,
                  s.FlotLevel,
                  s.FatherFlot,
                  hasChildren = query.Any(x => x.FatherFlot == s.PID)
             })
       .ToListAsync();
            return JsonNormal(new { rows });
        }


        [HttpPost, Route("FindFatherFOTS")]
        [ApiActionPermission]
        [AllowAnonymous]
 
        public async Task<string> FindFatherFOTS()
        {
            try { 
            var findorder = await JRM_Report_ARepository.Instance.FindAsync(x=>x.MainFlot == null&&x.ProcessName!= "吹膜");
           foreach( var order in     findorder )
            {
                order.MainFlot= await   _service.FindFatherFlot(order.FLOTNumber);

                if (!order.MainFlot.IsNullOrEmpty()) 
                {


                        string strsql1 = "UPDATE  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] SET MainFlot='" + order.MainFlot + "' WHERE NEWFLOT= '" + order.NEWFLOT + "' or FLOT_TEXT='" + order.FLOT_TEXT + "' ";
                        var sq11Count = DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql1, null);


                        string strsql2 = "UPDATE  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] SET MainFlot='"+order.MainFlot+"' WHERE NEWFLOT= '"+ order.NEWFLOT + "' or FLOT_TEXT='"+ order.FLOT_TEXT + "' ";
                        var sq12Count = DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql2, null); 



                    }

            }

          
           //成材率 计算
          // var tuozhi= await WOC_Dispatch_WorkFlowRepository.Instance.FindAsync(x => !x.MainFlot.IsNullOrEmpty() && x.ProcessName == "一次脱脂");
          //foreach( var order in tuozhi )
          //      {

          //          var pingzheng = await WOC_Dispatch_WorkFlowRepository.Instance.FindAsync(x => !x.MainFlot.IsNullOrEmpty() && x.NEWFLOT.Contains(order.NEWFLOT));



          //      }


            }
            catch( Exception ex )
            {
                string ss=ex.Message;
            }
            return "d";
        }

        //-----------------------------结算所有母卷的重量和长度
        [HttpPost, Route("SettlementOutWeight")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<string> SettlementOutWeight()
        {
            string ss = "ok";
            try
            {
                string sqlParticipantsString = @"  update [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] set ParticipantsString=
    COALESCE((select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,0,5)),'')
  + COALESCE(','+(select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,6,4)),'')
  + COALESCE(','+(select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,11,4)),'')
  + COALESCE(','+(select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,16,4)),'')
  + COALESCE(','+(select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,21,4)),'')
    + COALESCE(','+(select UserTrueName from   sys_user   where User_Id= SUBSTRING(Participants,26,4)),'')  where ParticipantsString is null";
                var sqlPart = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqlParticipantsString, null);

               //找到 母卷下子卷//纵剪
                    string strsql1 = "UPDATE  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] SET FatherFlot=ParentId WHERE ParentId IS NOT  NULL";
                    var sq11Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql1, null);
                 
                    string strsql2 = "UPDATE  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] SET FatherFlot=ParentId WHERE ParentId IS NOT  NULL";
                    var sq12Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql2, null);
//
                    string strsql3 = "update T2 set T2.FatherFlot=T1.FatherFlot FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T1.NEWFLOT=T2.NEWFLOT AND T1.FatherFlot is not null";
                    var sq13Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql3, null);

                    string strsql4 = "update T2 set T2.FatherFlot=T1.FatherFlot FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T1.NEWFLOT=T2.NEWFLOT AND T1.FatherFlot is not null";
                    var sq14Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql4, null);

                    string strsql5 = "update T2 set T2.FatherFlot=T1.FatherFlot FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T1.NEWFLOT=T2.NEWFLOT AND T1.FatherFlot is not null";
                    var sq15Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql5, null);

                    string strsql6 = "update T2 set T2.FatherFlot=T1.FatherFlot FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T1.NEWFLOT=T2.NEWFLOT AND T1.FatherFlot is not null";
                    var sq16Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(strsql6, null);

                
///修正产出 来料母卷数据
                string DFsql = "UPDATE T1 SET  T1.OutWeightUnit=T2.SUMweight,T1.OutLengthUnit=T2.SUMlenght  FROM  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 " +
                    " INNER JOIN  (SELECT ParentId,ROUND(sum(OutWeightUnit),3) AS SUMweight,ROUND(SUM(OutLengthUnit),3) AS SUMlenght,ProcessName  FROM" +
                    "  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow]  where ParentId is not null and  ProcessStatus in (4,5,0,7,9)  AND  (Result <> 3 OR Result IS NULL)  group by ParentId,ProcessName) T2 " +
                    " ON T2.ParentId=T1.PID and T2.ProcessName=T1.ProcessName and T1.OutWeightUnit!=T2.SUMweight ";
                var DFCount = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(DFsql, null);

                string JTsql = "UPDATE T1 SET  T1.OutWeightUnit=T2.SUMweight,T1.OutLengthUnit=T2.SUMlenght  FROM  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 " +
            " INNER JOIN  (SELECT ParentId,ROUND(sum(OutWeightUnit),3) AS SUMweight,ROUND(SUM(OutLengthUnit),3) AS SUMlenght,ProcessName  FROM " +
            "  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow]  where ParentId is not null and  ProcessStatus in (4,5,0,7,9)  AND  (Result <> 3 OR Result IS NULL)  group by ParentId,ProcessName) T2 " +
            " ON T2.ParentId=T1.PID   and T2.ProcessName=T1.ProcessName and T1.OutWeightUnit!=T2.SUMweight ";
                var JTCount = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(JTsql, null);


                string JTsql2 = " UPDATE T2 SET T2.FatherWorkOrderCode = T1.WorkOrderCode  FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T2.ParentId = T1.PID  AND T2.ParentId IS NOT NULL " +
                       " AND T2.ProcessStatus in (4, 5, 0, 9)  and T2.ProcessName = T1.ProcessName  AND(T2.Result<> 3 OR T2.Result IS NULL)";
                var JT2Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(JTsql2, null);
                string DFsql2 = " UPDATE T2 SET T2.FatherWorkOrderCode = T1.WorkOrderCode  FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T2 ON T2.ParentId = T1.PID  AND T2.ParentId IS NOT NULL " +
                     " AND T2.ProcessStatus in (4, 5, 0, 9)  and T2.ProcessName = T1.ProcessName  AND(T2.Result<> 3 OR T2.Result IS NULL)";
                var DF2Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(DFsql2, null);

 
                string JTsql3 = "UPDATE B1 SET  B1.WeightUnit= ROUND((B2.WeightUnit-B2.R3WeightUnit) * B1.OutWeightUnit / B2.OutWeightUnit, 0)  FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] B1 INNER JOIN  " +
             " ( select t1.PID ,t1.NEWFLOT,t1.OutWeightUnit,   t1.WeightUnit, (case  when t2.OutWeightUnit  is   null then  0 else t2.OutWeightUnit end )   AS R3WeightUnit " +
             " FROM [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 left join ( select ParentId,NEWFLOT, OutWeightUnit from [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] where Result=3 ) T2  ON " +
             " T1.PID=T2.ParentId  ) B2  ON B1.ParentId=B2.PID AND  B1.ProcessStatus in (0, 4, 5, 7, 9) AND(B1.Result<>3 OR B1.Result IS NULL) AND B1.ParentId is not null AND B1.OutWeightUnit != 0 ";

                var JT3Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(JTsql3, null);
              
                string DFsql3 = "UPDATE B1 SET  B1.WeightUnit= ROUND((B2.WeightUnit-B2.R3WeightUnit) * B1.OutWeightUnit / B2.OutWeightUnit, 0)  FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] B1 INNER JOIN  " +
                   " ( select t1.PID ,t1.NEWFLOT,t1.OutWeightUnit,   t1.WeightUnit, (case  when t2.OutWeightUnit  is   null then  0 else t2.OutWeightUnit end )   AS R3WeightUnit " +
                   " FROM [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 left join ( select ParentId,NEWFLOT, OutWeightUnit from [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] where Result=3 ) T2  ON " +
                   " T1.PID=T2.ParentId  ) B2  ON B1.ParentId=B2.PID AND  B1.ProcessStatus in (0, 4, 5, 7, 9) AND(B1.Result<>3 OR B1.Result IS NULL) AND B1.ParentId is not null AND B1.OutWeightUnit != 0 ";
                var DF3Count = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(DFsql3, null);

                string upwdf = "update [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] set[OutThicknessUnit] =ROUND(OutThicknessUnit,3),ThicknessUnit=ROUND(ThicknessUnit,3),OutWeightUnit=ROUND(OutWeightUnit,3),WeightUnit=ROUND(WeightUnit,3),OutWidthUnit=ROUND(OutWidthUnit,3),WidthUnit=ROUND(WidthUnit,3)  where RealEndTime>DATEADD(DAY, -3, GETDATE())";
                var sqlexcdf = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(upwdf, null);
                string upwjt = "update [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] set[OutThicknessUnit] =ROUND(OutThicknessUnit,3),ThicknessUnit=ROUND(ThicknessUnit,3),OutWeightUnit=ROUND(OutWeightUnit,3),WeightUnit=ROUND(WeightUnit,3),OutWidthUnit=ROUND(OutWidthUnit,3),WidthUnit=ROUND(WidthUnit,3)  where RealEndTime>DATEADD(DAY, -3, GETDATE()) ";
                var sqlexcjt = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(upwjt, null);


                string upfmAsql = "update t1 set T1.FMWeight=  cast (round(T2.ReceiveQty,3) as float)  from WOC_Dispatch_WorkFlow T1 inner join JRM_ProductReportFM T2 on  T1.WorkOrderCode=T2.WorkOrderCode where T1.ProcessStatus in (0,4,5,9,7) and T1.ParentId  is   null  AND T1.FMWeight is NULL";
                var sqlexfm = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(upfmAsql, null);
                
                string upfmBsql = "UPDATE T1 SET T1.FMWeight=ROUND(T2.FMWeight*(T1.OutWeightUnit/T2.OutWeightUnit),3)  from WOC_Dispatch_WorkFlow T1 inner join WOC_Dispatch_WorkFlow T2 ON  T1.ParentId=T2.PID  AND    (T1.Result<>3 OR T1.Result IS NULL)  AND   T1.ProcessName='覆膜'  AND T1.FMWeight is NULL ";
                var sqlexfmB = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(upfmBsql, null);


                string yield = "update [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] set  ProductYield=CAST(ROUND(OutWeightUnit/(WeightUnit+ CASE  WHEN FMWeight IS NOT NULL THEN FMWeight ELSE 0.00000001 END ),4)*100 AS VARCHAR(10)) +'%' where IsInWarehouse=1 and ProductYield is null";
                var sqlyield = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(yield, null);


                string yielddf = "update MESJSJT.[dbo].[WOC_Dispatch_WorkFlow] set  ProductYield=CAST(ROUND(OutWeightUnit/(WeightUnit+0.00001),4)*100 AS VARCHAR(10)) +'%' where   IsInWarehouse=1 and ProductYield is null";
                var sqlyielddf = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(yielddf, null);

            }

            catch (Exception ex)
            {
                ss = ex.Message;
            }
            return ss;
        }


        [HttpPost, Route("Setrate")]
        [ApiActionPermission]
        [AllowAnonymous]

        public async Task<string> Setrate()
        {
            string ss = "ok";
            try
            {
                //一次成材率
                string  sqA = @"UPDATE  T1  SET  FirstYieldRate=  CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'  from [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN   (select  (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit) end) AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName   FROM  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (2,4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2 ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND T1.ProcessName=T2.ProcessName and T1.ProcessName!='纵剪' and T1.isProducts=1 INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT";
                var sqAex =await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqA, null);


                string sqB = @"UPDATE  T1  SET  FirstYieldRate=  CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'  from [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 INNER JOIN  (select   (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit) end)  AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName   FROM  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (2,4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2 ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND T1.ProcessName=T2.ProcessName and T1.ProcessName!='纵剪' and T1.isProducts=1 INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT";
                var sqBex = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqB, null);

               //二次合格率
                string sqC = @"UPDATE  T1  SET  SecPsRate=    CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'   from [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 
  INNER JOIN (select  (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit)end)  AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName   
  FROM  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (2,4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2 ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND 
  T1.ProcessName=T2.ProcessName  and T1.ProcessName!='纵剪' and T1.isProducts=1 and T1.Result in (2)	INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT ";
                var sqCex = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqC, null);


                string sqD = @" UPDATE  T1  SET  SecPsRate=    CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'    from [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1
	 INNER JOIN  (select  (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit)end) AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName 
	 FROM  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (2,4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2	ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND 
	 T1.ProcessName=T2.ProcessName and T1.ProcessName!='纵剪' and T1.isProducts=1 and T1.Result in (2) INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT";
                var sqDex = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqD, null);


                //一次合格率
                string sqE = @"UPDATE  T1  SET  FirstPsRate=   CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'   from [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T1
	 INNER JOIN  (select  (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit)end) AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName 
	 FROM  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2	ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND 
	 T1.ProcessName=T2.ProcessName and T1.ProcessName!='纵剪' and T1.isProducts=1 and T1.Result in (4,8)   INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT";
                var sqEex = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqC, null);


                string sqF = @"  UPDATE  T1  SET  FirstPsRate=     CAST(ROUND(T2.FOutWeightUnit/T3.OutWeightUnit,4)*100 AS varchar(10))+'%'   from [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow] T1 
INNER JOIN (select  (case when processname ='覆膜' then  sum(OutWeightUnit)-sum(FMWeight) else  sum(OutWeightUnit)end)  AS FOutWeightUnit ,left(NEWFLOT,12) AS FNEWFLOT,ProcessName   
FROM  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow]   WHERE Result in (4,8)  group by left(NEWFLOT,12),left(WorkOrderCode,12),ProcessName) T2 ON T2.FNEWFLOT= LEFT(T1.NEWFLOT,12) AND 
T1.ProcessName=T2.ProcessName  and T1.ProcessName!='纵剪' and T1.isProducts=1 and T1.Result in (4,8)	INNER JOIN [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow] T3 ON 	T3.ProcessStatus=4 AND T3.ProcessName='纵剪' AND T2.FNEWFLOT=T3.NEWFLOT";
                var sqFex = await DBServerProvider.SqlDapper.ExcuteNonQueryAsync(sqD, null);

            }
            catch  (Exception ex)
            {
                ss = ex.Message;
            }

            return ss;
         }

    }
}
