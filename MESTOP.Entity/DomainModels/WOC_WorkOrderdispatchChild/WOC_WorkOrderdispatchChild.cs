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
    [Entity(TableCnName = "派工单子表",TableName = "WOC_WorkOrderdispatchChild",DBServer = "SysDbContext")]
    public partial class WOC_WorkOrderdispatchChild:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="CWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int CWOId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MWOId { get; set; }

       /// <summary>
       ///主工单号
       /// </summary>
       [Display(Name ="主工单号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子工单号
       /// </summary>
       [Display(Name ="子工单号")]
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
       ///产出品简码
       /// </summary>
       [Display(Name ="产出品简码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///生产组织
       /// </summary>
       [Display(Name ="生产组织")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///产出OK品数量
       /// </summary>
       [Display(Name ="产出OK品数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///产出NG数量
       /// </summary>
       [Display(Name ="产出NG数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///未产出数量
       /// </summary>
       [Display(Name ="未产出数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UnOutPutWIPQty { get; set; }

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
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

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
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EquipIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeopleIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PeopleIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaterialIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UndispatchedQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DispatchedQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

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
       [Display(Name ="poststatus")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? poststatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskNo")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string taskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="postNumber")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? postNumber { get; set; }

       /// <summary>
       ///领料单编码
       /// </summary>
       [Display(Name ="领料单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///领料单状态
       /// </summary>
       [Display(Name ="领料单状态")]
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
       [Display(Name ="Order_Cancellation")]
       [JsonIgnore]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Order_Cancellation { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Order_Distribution")]
       [JsonIgnore]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Order_Distribution { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealStartTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealEndTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///主工序流程编码
       /// </summary>
       [Display(Name ="主工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MainProcessFlowCode { get; set; }

       
    }
}
