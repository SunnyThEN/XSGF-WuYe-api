using Newtonsoft.Json;
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
    [Entity(TableCnName = "主工单管理",TableName = "WOC_WorkOrder",DBServer = "ServiceDbContext")]
    public partial class WOC_WorkOrder:ServiceEntity
    {
        /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WorkOrderType { get; set; }

       /// <summary>
       ///产出品物料编码
       /// </summary>
       [Display(Name ="产出品物料编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///子工序流程
       /// </summary>
       [Display(Name ="子工序流程")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///主工序流程
       /// </summary>
       [Display(Name ="主工序流程")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MainProcessFlowCode { get; set; }

       /// <summary>
       ///产出品物料名称
       /// </summary>
       [Display(Name ="产出品物料名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///工单层级
       /// </summary>
       [Display(Name ="工单层级")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///BOM版本号
       /// </summary>
       [Display(Name ="BOM版本号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
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
       ///实际开工时间
       /// </summary>
       [Display(Name ="实际开工时间")]
       [Column(TypeName="datetime")]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///实际结束时间
       /// </summary>
       [Display(Name ="实际结束时间")]
       [Column(TypeName="datetime")]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///已派工数量
       /// </summary>
       [Display(Name ="已派工数量")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///未派工数量
       /// </summary>
       [Display(Name ="未派工数量")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///已产出OK数量
       /// </summary>
       [Display(Name ="已产出OK数量")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///已产出NG数量
       /// </summary>
       [Display(Name ="已产出NG数量")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///未产出数量
       /// </summary>
       [Display(Name ="未产出数量")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UnOutPutWIPQty { get; set; }

       /// <summary>
       /// 
       /// </summary>
       [Display(Name =" ")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? poststatus { get; set; }

       /// <summary>
       ///工单下发状态
       /// </summary>
       [Display(Name ="工单下发状态")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrderWMsPost { get; set; }

       /// <summary>
       ///工单下发任务号
       /// </summary>
       [Display(Name ="工单下发任务号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrdertaskNo { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMVersion")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipIsOk")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EquipIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeopleIsOk")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PeopleIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialIsOk")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaterialIsOk { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [MaxLength(250)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NG2OKQty")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? NG2OKQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferCode")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferStatus")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? shipmentReferStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskStatus")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string taskStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentWMSsPost")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentWMSsPost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmenttaskNo")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmenttaskNo { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string OrgName { get; set; }

       /// <summary>
       ///ERP工单类型
       /// </summary>
       [Display(Name ="ERP工单类型")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string BillTypeName { get; set; }

       /// <summary>
       ///批次
       /// </summary>
       [Display(Name ="批次")]
       [Column(TypeName="int")]
       public int? FLOT { get; set; }

       /// <summary>
       ///车间名称
       /// </summary>
       [Display(Name ="车间名称")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string WorkShopName { get; set; }

       /// <summary>
       ///车间编码
       /// </summary>
       [Display(Name ="车间编码")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///产出品物料简码
       /// </summary>
       [Display(Name ="产出品物料简码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="postNumber")]
       [Column(TypeName="int")]
       public int? postNumber { get; set; }

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
       ///子工序流程编码
       /// </summary>
       [Display(Name ="子工序流程编码")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOrderFlag")]
       [Column(TypeName="int")]
       public int? FOrderFlag { get; set; }

       /// <summary>
       ///令号
       /// </summary>
       [Display(Name ="令号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string orderNumber { get; set; }

       /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string batchNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string FLOT_TEXT { get; set; }

       
    }
}
