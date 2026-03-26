/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_ReportC",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using JRM.IServices;
using JRM.Repositories;
using MESTOP.Core.Enums;
using MESTOP.Core.Extensions;
using MESTOP.Core.Filters;
using System.Linq;
using Infrastructure;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.FormulaParsing.Utilities;
using WOC.Repositories;

namespace JRM.Controllers
{
    public partial class JRM_ReportCController
    {
        private readonly IJRM_ReportCService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_ReportCController(
            IJRM_ReportCService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return GetJRM_ReportCRootData(loadData);
            //return GetTreeTableRootData(loadData).Result;

        }

        [HttpPost, Route("GetJRM_ReportCRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetJRM_ReportCRootData([FromBody] PageDataOptions options)
        {
            var queryB2 = JRM_ReportCRepository.Instance.FindAsIQueryable(x => 1 == 1);


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


                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "ProcessName")
                    {
                        queryB2 = queryB2.Where(s => s.ProcessName.Contains(x.Value));
                    }

                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "TeamGroup")
                    {
                        queryB2 = queryB2.Where(s => s.TeamGroup.Contains(x.Value));
                    }

                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "WorkStationName")
                    {
                        queryB2 = queryB2.Where(s => s.WorkStationName == x.Value);
                    }
                    if (x.DisplayType == ">=" && x.Name == "RealEndTime" && !string.IsNullOrEmpty(x.Value))
                    {
                        queryB2 = queryB2.Where(s => s.RealEndTime >= x.Value.ToDateTime().Value.AddHours(+8).AddMinutes(+30));
                    }
                    if (x.DisplayType == "<=" && x.Name == "RealEndTime" && !string.IsNullOrEmpty(x.Value))
                    {
                        queryB2 = queryB2.Where(s => s.RealEndTime <= x.Value.ToDateTime().Value.AddHours(+32).AddMinutes(+30));
                    }
                }
            }

           
            float firstrate = 0;
            var query1 = queryB2.GroupBy(x => new { x.WorkStationName })
              .Select(g => new JRM_ReportC
              {
                  PLevel = 1,
                  mainId = "AAA" + g.Key.WorkStationName,
                  FLOTCount = g.Count(),
                  WeightUnit = g.Sum(x => x.WeightUnit),
                  FMWeight = g.Sum(x => x.FMWeight),
                  OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                  OutLengthUnit = g.Sum(x => x.OutLengthUnit),
                  ProductYield = (g.Sum(x => x.OutWeightUnit) / (g.Sum(x => x.WeightUnit) + g.Sum(x => x.FMWeight) + 0.000001)).Value.ToString("P2"),

                   //FirstYieldRate = (g.Average(x=>  Convert.ToDecimal( x.FirstYieldRate))/100 ).ToString("P2"),
                  // WorkStationCode= g.Key.WorkStationCode,
                  WorkStationName = g.Key.WorkStationName

              }).ToList();
            var query = new List<JRM_ReportC>();
            query.AddRange(query1);

            

            

            //foreach ( var qer in query)
            //{
            //    var zjsum = queryB2.ToList().FindAll(x => (x.Result == 4 || x.Result == 2 || x.Result == 8) && x.ProcessName == qer.ProcessName&& x.WorkStationName==qer.WorkStationName);
            //    var zzpz = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.ProcessName == "纵剪"&& zjsum.Select(s=>s.NEWFLOT).Contains(x.NEWFLOT)&&(x.Result==2||x.Result==4)).Sum(x=>x.OutWeightUnit);

            //    qer.FirstYieldRate = (zjsum.Sum(x => x.OutWeightUnit) / zzpz).Value.ToString("P2");


            //}



            var roleRepository = queryB2.GroupBy(x => new { x.WorkStationName, x.ProcessName })
                .Select(g => new JRM_ReportC
                {
                    PLevel = 2,
                    ParentId = "AAA" + g.Key.WorkStationName,
                    mainId = "BBB" + g.Key.WorkStationName + g.Key.ProcessName,
                    WorkStationName = g.Key.WorkStationName,
                    FLOTCount = g.Count(),
                    WeightUnit = g.Sum(x => x.WeightUnit),
                    OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                    OutLengthUnit = g.Sum(x => x.OutLengthUnit),

                    ProcessName = g.Key.ProcessName
                });

            string fs = options.Wheres;



            var rows = query.AsQueryable().
            TakeOrderByPage(options.Page, options.Rows)
            .OrderBy(x => x.WorkOrderCode)
            .Select(s => new
            {
                Id = s.mainId,
                s.mainId,
                s.ParentId,
                s.WorkOrderCode,
                s.FLOTNumber,
                s.NEWFLOT,
                s.ProductCode,
                s.ProductName,
                s.ProcessName,
                s.FLOTCount,
                s.FMWeight,
                s.PLevel,
                s.RealEndTime,
                s.RealStartTime,
                s.WorkStationCode,
                s.WorkStationName,
                s.OutWeightUnit,
                s.OutWidthUnit,
                s.OutLengthUnit,
                s.OutThicknessUnit,
                s.WeightUnit,
                s.WidthUnit,
                s.LengthUnit,
                s.ThicknessUnit,
                s.ProcessStatus,
                s.PID,
                s.ProductYield,
                s.TeamGroup,
                s.FirstPsRate,
                s.SecPsRate,
                s.FirstYieldRate,

                hasChildren = roleRepository.Any(x => x.ParentId == s.mainId)
            }
            ).ToList();
            return JsonNormal(new { total = query.Count(), rows });
        }

        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> getChildrenData([FromBody] PageDataOptions options)
        {


            var queryB2 = await JRM_ReportCRepository.Instance.FindAsync(x => 1 == 1);

            var query = new List<JRM_ReportC>();
            var query9 = new List<JRM_ReportC>();
            options = options ?? new PageDataOptions();
            var roleReps = queryB2;/* await WOC_Dispatch_WorkFlowRepository.Instance.FindAsync(x => "0,4,5,7,9".Contains(x.ProcessStatus));*/
            var roleRep = roleReps.MapToList<JRM_ReportC>();
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


                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "ProcessName")
                    {
                        queryB2 = queryB2.Where(s => s.ProcessName.Contains(x.Value)).ToList();
                    }

                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "TeamGroup")
                    {
                        queryB2 = queryB2.Where(s => s.TeamGroup != null && s.TeamGroup.Contains(x.Value)).ToList();
                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "WorkStationName")
                    {
                        queryB2 = queryB2.Where(s => s.WorkStationName == x.Value).ToList();

                    }
                    if (x.DisplayType == ">=" && x.Name == "RealEndTime" && !string.IsNullOrEmpty(x.Value))
                    {
                        queryB2 = queryB2.Where(s => s.RealEndTime >= x.Value.ToDateTime().Value.AddHours(+8).AddMinutes(+30)).ToList();
                    }
                    if (x.DisplayType == "<=" && x.Name == "RealEndTime" && !string.IsNullOrEmpty(x.Value))
                    {
                        queryB2 = queryB2.Where(s => s.RealEndTime <= x.Value.ToDateTime().Value.AddHours(+32).AddMinutes(+30)).ToList();
                    }

                }
            }

        
            var query1 = queryB2.GroupBy(x => new { x.WorkStationName, x.ProcessName })
            .Select(g => new JRM_ReportC
            {
                PLevel = 2,
                ParentId = "AAA" + g.Key.WorkStationName,
                mainId = "BBB"  + g.Key.WorkStationName + g.Key.ProcessName,
                WorkStationName = g.Key.WorkStationName,
                FLOTCount = g.Count(),
                WeightUnit = g.Sum(x => x.WeightUnit),
                FMWeight = g.Sum(x => x.FMWeight),
                OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                OutLengthUnit = g.Sum(x => x.OutLengthUnit),
              
                ProductYield = (g.Sum(x => x.OutWeightUnit) / (g.Sum(x => x.WeightUnit) + g.Sum(x => x.FMWeight) + 0.0000000001 * 100)).Value.ToString("P2"),
                ProcessName = g.Key.ProcessName
            }).Where(x => x.ParentId == options.Value.ToString()).MapToList<JRM_ReportC>();
            query = new List<JRM_ReportC>();
            query.AddRange(query1);


            var query3 = queryB2.MapToList<JRM_ReportC>();

            query3.ForEach(x =>
            {
                x.ParentId = "BBB"  + x.WorkStationName + x.ProcessName;
                x.mainId = x.PID.ToString();
                x.PLevel = 3;
            });


            if (query.Count > 0)
            {
                var query4 = query3.Where(x => "AAA" + x.WorkStationName == options.Value.ToString()).ToList();
                roleRep = query4.ToList();
            }
            query3 = query3.Where(x => "BBB"  + x.WorkStationName + x.ProcessName == options.Value.ToString()).ToList();



            query.AddRange(query3);


            var roleRepository = roleRep.AsQueryable();
            var rows = query
                           .Select(s => new
                           {
                               Id = s.mainId,
                               s.mainId,
                               s.ParentId,
                               s.WorkOrderCode,
                               s.FLOTNumber,
                               s.NEWFLOT,
                               s.ProductCode,
                               s.ProductName,
                               s.ProcessName,
                               s.RealEndTime,
                               s.RealStartTime,
                               s.WorkStationCode,
                               s.FLOTCount,
                               s.WorkStationName,
                               s.OutWeightUnit,
                               s.PLevel,
                               s.OutWidthUnit,
                               s.OutLengthUnit,
                               s.OutThicknessUnit,
                               s.WeightUnit,
                               s.WidthUnit,
                               s.LengthUnit,
                               s.ThicknessUnit,
                               s.FMWeight,
                               s.FirstPsRate,
                               s.SecPsRate,
                               s.FirstYieldRate,
                               s.ProductYield,
                               s.TeamGroup,
                               hasChildren = roleRepository.Any(x => x.ParentId == s.mainId)
                           }).ToList();
            return JsonNormal(new { rows });
        }

    }
}
