/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MESTOP.Entity.SystemModels;

namespace MESTOP.Entity.DomainModels
{
    [Entity(TableCnName = "工位派工清单",TableName = "WOC_Dispatch_WorkStationList",DBServer = "SysDbContext")]
    public partial class WOC_Dispatch_WorkStationList:SysEntity
    {
        /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///工序流程
       /// </summary>
       [Display(Name ="工序流程")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///计划开始时间
       /// </summary>
       [Display(Name ="计划开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///计划结束时间
       /// </summary>
       [Display(Name ="计划结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductShortCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="poststatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? poststatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="postNumber")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? postNumber { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkStationId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? WorkStationId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       public int? MWOId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WID")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? WID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Sort")]
       [Column(TypeName="int")]
       public int? Sort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessStepId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? ProcessStepId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DispatchedQty")]
       [Column(TypeName="float")]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UndispatchedQty")]
       [Column(TypeName="float")]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutPutOKWIPQty")]
       [Column(TypeName="float")]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutPutNGWIPQty")]
       [Column(TypeName="float")]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UnOutPutWIPQty")]
       [Column(TypeName="float")]
       public float? UnOutPutWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WOStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       public int? ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOrderFlag")]
       [Column(TypeName="int")]
       public int? FOrderFlag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealStartTime")]
       [Column(TypeName="datetime")]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealEndTime")]
       [Column(TypeName="datetime")]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipIsOk")]
       [Column(TypeName="int")]
       public int? EquipIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeopleIsOk")]
       [Column(TypeName="int")]
       public int? PeopleIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialIsOk")]
       [Column(TypeName="int")]
       public int? MaterialIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NG2OKQty")]
       [Column(TypeName="float")]
       public float? NG2OKQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferStatus")]
       [Column(TypeName="int")]
       public int? shipmentReferStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskNo")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string taskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Order_Cancellation")]
       [Column(TypeName="nvarchar(max)")]
       public string Order_Cancellation { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Order_Distribution")]
       [Column(TypeName="nvarchar(max)")]
       public string Order_Distribution { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskStatus")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string taskStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrderWMsPost")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string OrderWMsPost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentWMSsPost")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string shipmentWMSsPost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrdertaskNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string OrdertaskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmenttaskNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string shipmenttaskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMVersion")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MainProcessFlowCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MainProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BillTypeName")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string BillTypeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       public int? FLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkShopName")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string WorkShopName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkShopCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderType")]
       [Column(TypeName="int")]
       public int? WorkOrderType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="orderNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string orderNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="batchNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string batchNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SID")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid SID { get; set; }

       
    }
}