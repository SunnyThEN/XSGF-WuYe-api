/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_ReportB",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.Filters;
using MESTOP.Core.Extensions;
using System.Linq;
using CSR_JD.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections;
using Infrastructure;
using System.Data;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using WOC.Repositories;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

namespace JRM.Controllers
{
    public partial class JRM_ReportBController
    {
        private readonly IJRM_ReportBService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_ReportBController(
            IJRM_ReportBService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return GetJrm_ReportBRootData(loadData);
            //return GetTreeTableRootData(loadData).Result;

        }

        [HttpPost, Route("GetJrm_ReportBRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetJrm_ReportBRootData([FromBody] PageDataOptions options)
        { 
            var queryB2 = JRM_ReportBRepository.Instance.FindAsIQueryable(x => 1==1);
            
                  
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


                var query1 = queryB2.GroupBy(x => new { x.ProcessName,x.ProcessCode })
                  .Select(g => new JRM_ReportB
                  {
                      PLevel = 1,
                      mainId = "AAA" + g.Key.ProcessName,
                      FLOTCount = g.Count(),
                      WeightUnit = g.Sum(x => x.WeightUnit),
                      FMWeight = g.Sum(x => x.FMWeight),
                      OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                      OutLengthUnit = g.Sum(x => x.OutLengthUnit),
                      ProductYield = (g.Sum(x => x.OutWeightUnit) / (g.Sum(x => x.WeightUnit) + g.Sum(x => x.FMWeight) + 0.000001)).Value.ToString("P2"),

                      ProcessName = g.Key.ProcessName,
                      ProcessCode = g.Key.ProcessCode
                  }).ToList(); 
            var query = new List<JRM_ReportB>();
                query.AddRange(query1);

            var roleRepository = queryB2.GroupBy(x => new {  x.WorkStationName, x.ProcessName, x.ProcessCode })
                .Select(g => new JRM_ReportB
                {
                    PLevel = 2,
                    ParentId = "AAA" + g.Key.ProcessName,
                    mainId = "BBB" + g.Key.ProcessName + g.Key.WorkStationName,
                    WorkStationName = g.Key.WorkStationName,
                    FLOTCount = g.Count(),
                    WeightUnit = g.Sum(x => x.WeightUnit),
                    OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                    OutLengthUnit = g.Sum(x => x.OutLengthUnit),
                   
                    ProcessName = g.Key.ProcessName,
                    ProcessCode = g.Key.ProcessCode
                }).OrderBy(x => x.ProcessCode);  

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
                s.ProcessCode,
     
                hasChildren = roleRepository.Any(x => x.ParentId == s.mainId)
            }
            ).ToList().OrderBy(x=>x.ProcessCode); 
            return JsonNormal(new { total = query.Count(), rows });
        }

        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> getChildrenData([FromBody] PageDataOptions options)
        {


            var queryB2 = await JRM_ReportBRepository.Instance.FindAsync(x=>1==1);
         
            var query = new List<JRM_ReportB>();
            var query9 = new List<JRM_ReportB>();
            options = options ?? new PageDataOptions();
            var roleReps = queryB2;/* await WOC_Dispatch_WorkFlowRepository.Instance.FindAsync(x => "0,4,5,7,9".Contains(x.ProcessStatus));*/
            var roleRep = roleReps.MapToList<JRM_ReportB>();
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
                        queryB2 = queryB2.Where(s =>s.TeamGroup !=null&& s.TeamGroup.Contains(x.Value)).ToList();
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
                .Select(g => new JRM_ReportB
                 {
                     PLevel = 2,
                     ParentId = "AAA" + g.Key.ProcessName,
                     mainId = "BBB" + g.Key.ProcessName + g.Key.WorkStationName, 
                     WorkStationName = g.Key.WorkStationName,
                     FLOTCount = g.Count(),
                     WeightUnit = g.Sum(x => x.WeightUnit),
                    FMWeight = g.Sum(x => x.FMWeight),
                    OutWeightUnit = g.Sum(x => x.OutWeightUnit),
                     OutLengthUnit = g.Sum(x => x.OutLengthUnit),
                     ProductYield=     (g.Sum(x => x.OutWeightUnit)/(g.Sum(x => x.WeightUnit)+ g.Sum(x => x.FMWeight)+0.000001 *100 )).Value.ToString("P2") ,
                     ProcessName = g.Key.ProcessName
                 }).Where(x => x.ParentId == options.Value.ToString()).MapToList<JRM_ReportB>();
                query = new List<JRM_ReportB>();
                query.AddRange(query1);


            var query3 = queryB2.MapToList<JRM_ReportB>();
      
            query3.ForEach(x =>
            {
                x.ParentId = "BBB" + x.ProcessName + x.WorkStationName;
                x.mainId = x.PID.ToString();
                x.PLevel = 3;
            });
          

            if (query.Count > 0)
            {
                var query4 = query3.Where(x => "AAA" + x.ProcessName  == options.Value.ToString()).ToList();
                roleRep = query4.ToList();
            }
            query3 = query3.Where(x => "BBB" + x.ProcessName + x.WorkStationName == options.Value.ToString()).ToList();
          
 
              
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
                               s.ProductYield,
                               s.TeamGroup,
                               hasChildren = roleRepository.Any(x => x.ParentId == s.mainId) 
                           }).ToList();
            return JsonNormal(new { rows });
        }

    }
}
