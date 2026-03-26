/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("JRM_ReportOK",Enums.ActionPermissionOptions.Search)]
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
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Configuration;
using MESTOP.Core.ManageUser;
using MESTOP.Sys.Repositories;
using JRM.Repositories;
using System.Linq;
using MESTOP.Core.Extensions;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Microsoft.EntityFrameworkCore;

namespace JRM.Controllers
{
    public partial class JRM_ReportOKController
    {
        private readonly IJRM_ReportOKService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public JRM_ReportOKController(
            IJRM_ReportOKService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        ///// <summary>
        ///// treetable 获取子节点数据(2021.05.02)
        ///// </summary>
        ///// <param name="loadData"></param>
        ///// <returns></returns>
        //[ApiActionPermission(ActionPermissionOptions.Search)]
        //[HttpPost, Route("GetPageData")]
        //public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        //{
        //    return GetTreeTableRootData(loadData).Result;
        //}

        ///// <summary>
        ///// treetable 获取一级(根)节点数据
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost, Route("getTreeTableRootData")]
        //[ApiActionPermission(ActionPermissionOptions.Search)]
        //public async Task<ActionResult> GetTreeTableRootData([FromBody] PageDataOptions options)
        //{
        //    //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置

        //    var query = JRM_ReportOKRepository.Instance.FindAsIQueryable(x => x.ParentId == null);

        //    var queryChild = JRM_ReportOKRepository.Instance.FindAsIQueryable(x => true);
        //    var rows = await query.TakeOrderByPage(options.Page, options.Rows)
        //        .OrderBy(x => x.PID).Select(s => new
        //        {
        //            s.PID,
        //            s.WID,
        //            s.MWOId,
        //            s.Sort,
        //            s.ProcessStepId,
        //            s.ProcessName,
        //            s.ProcessCode,
        //            s.ParentWorkOrderCode,
        //            s.WorkOrderCode,
        //            s.ProductCode,
        //            s.ProductName,
        //            s.ProcessFlowCode,
        //            s.ProcessFlowName,
        //            s.WORequiredQty,
        //            s.PlanStartTime,
        //            s.PlanEndTime,
        //            s.WOStatus,
        //            s.RealStartTime,
        //            s.RealEndTime,
        //            s.OrgCode,
        //            s.OrgName,
        //            s.Orderlevel,
        //            s.BOMVersion,
        //            s.FLOT,
        //            s.FENTRYID,
        //            s.WorkStationCode,
        //            s.WorkStationName,
        //            s.operatorworkers,
        //            s.Reportingworkers,
        //            s.ProcessStatus,
        //            s.TeamGroup,
        //            s.Isinspection,
        //            s.Participants,
        //            s.OutThicknessUnit,
        //            s.OutLengthUnit,
        //            s.OutWidthUnit,
        //            s.OutWeightUnit,
        //            s.ThicknessUnit,
        //            s.LengthUnit,
        //            s.WidthUnit,
        //            s.WeightUnit,
        //            s.NEWFLOT,
        //            s.isSplitting,
        //            s.FLOT_TEXT,
        //            s.MaterialDesc,
        //            s.MaterialCode,
        //            s.MaterialName,
        //            s.MaterialGrade,
        //            s.QualityStatus,
        //            s.NextProcess,
        //            s.PreviousProcess,
        //            s.ProcessRequest,
        //            s.WorkOrderDesc,
        //            s.ParentId,
        //            s.FeedSort,
        //            s.FLOTNumber,
        //            s.isProducts,
        //            s.Result,
        //            s.isFinalJug,
        //            s.ProductDesc,
        //            s.ProductYield,
        //            hasChildren = queryChild.Any(x => x.ParentId == s.PID)
        //        }).ToListAsync();
        //    return JsonNormal(new { total = await query.CountAsync(), rows });
        //}

        ///// <summary>
        /////treetable 获取子节点数据
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost, Route("getTreeTableChildrenData")]
        //[ApiActionPermission(ActionPermissionOptions.Search)]
        //public async Task<ActionResult> GetTreeTableChildrenData(Guid PID)
        //{
        //    //点击节点时，加载子节点数据
        //    var roleRepository = JRM_ReportOKRepository.Instance.FindAsIQueryable(x => true);
        //    var rows = await roleRepository
        //        .Select(s => new
        //        {
        //            s.PID,
        //            s.WID,
        //            s.MWOId,
        //            s.Sort,
        //            s.ProcessStepId,
        //            s.ProcessName,
        //            s.ProcessCode,
        //            s.ParentWorkOrderCode,
        //            s.WorkOrderCode,
        //            s.ProductCode,
        //            s.ProductName,
        //            s.ProcessFlowCode,
        //            s.ProcessFlowName,
        //            s.WORequiredQty,
        //            s.PlanStartTime,
        //            s.PlanEndTime,
        //            s.WOStatus,
        //            s.RealStartTime,
        //            s.RealEndTime,
        //            s.OrgCode,
        //            s.OrgName,
        //            s.Orderlevel,
        //            s.BOMVersion,
        //            s.FLOT,
        //            s.FENTRYID,
        //            s.WorkStationCode,
        //            s.WorkStationName,
        //            s.operatorworkers,
        //            s.Reportingworkers,
        //            s.ProcessStatus,
        //            s.TeamGroup,
        //            s.Isinspection,
        //            s.Participants,
        //            s.OutThicknessUnit,
        //            s.OutLengthUnit,
        //            s.OutWidthUnit,
        //            s.OutWeightUnit,
        //            s.ThicknessUnit,
        //            s.LengthUnit,
        //            s.WidthUnit,
        //            s.WeightUnit,
        //            s.NEWFLOT,
        //            s.isSplitting,
        //            s.FLOT_TEXT,
        //            s.MaterialDesc,
        //            s.MaterialCode,
        //            s.MaterialName,
        //            s.MaterialGrade,
        //            s.QualityStatus,
        //            s.NextProcess,
        //            s.PreviousProcess,
        //            s.ProcessRequest,
        //            s.WorkOrderDesc,
        //            s.ParentId,
        //            s.FeedSort,
        //            s.FLOTNumber,
        //            s.isProducts,
        //            s.Result,
        //            s.isFinalJug,
        //            s.ProductDesc,
        //            s.ProductYield,
        //            hasChildren = roleRepository.Any(x => x.ParentId == s.PID)
        //        }).ToListAsync();
        //    return JsonNormal(new { rows });
        //}
    }
}
