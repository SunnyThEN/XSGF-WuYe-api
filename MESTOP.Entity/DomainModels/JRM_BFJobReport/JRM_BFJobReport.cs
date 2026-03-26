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
    [Entity(TableCnName = "吹膜报工",TableName = "JRM_BFJobReport",DetailTable =  new Type[] { typeof(JRM_BFJobReportItem)},DetailTableCnName = "吹塑明细",DBServer = "ServiceDbContext")]
    public partial class JRM_BFJobReport:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid PID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Sort")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessStepId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

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
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///计划号状态
       /// </summary>
       [Display(Name ="计划号状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///产品编码
       /// </summary>
       [Display(Name ="产品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///产品规格
       /// </summary>
       [Display(Name ="产品规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

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
       ///组织
       /// </summary>
       [Display(Name ="组织")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///操作员
       /// </summary>
       [Display(Name ="操作员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string operatorworkers { get; set; }

       /// <summary>
       ///机组编码
       /// </summary>
       [Display(Name ="机组编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///工序状态
       /// </summary>
       [Display(Name ="工序状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///班组
       /// </summary>
       [Display(Name ="班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TeamGroup { get; set; }

       /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialName { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="QualityStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

       /// <summary>
       ///参与人
       /// </summary>
       [Display(Name ="参与人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Participants { get; set; }

       /// <summary>
       ///出料厚度
       /// </summary>
       [Display(Name ="出料厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///出料长度
       /// </summary>
       [Display(Name ="出料长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///出料宽度
       /// </summary>
       [Display(Name ="出料宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isSplitting")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string isSplitting { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Isinspection")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Isinspection { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reportingworkers")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Reportingworkers { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NextProcess")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? NextProcess { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PreviousProcess")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? PreviousProcess { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///工序要求
       /// </summary>
       [Display(Name ="工序要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessRequest { get; set; }

       /// <summary>
       ///工单要求
       /// </summary>
       [Display(Name ="工单要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkOrderDesc { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WeightUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WidthUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WidthUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LengthUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? LengthUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ThicknessUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ThicknessUnit { get; set; }

       /// <summary>
       ///出料总量
       /// </summary>
       [Display(Name ="出料总量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FeedSort")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FeedSort { get; set; }

       /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isProducts")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProducts { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string F_PASF_NEWPREFIX { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

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
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       [Display(Name ="吹塑明细")]
       [ForeignKey("PID")]
       public List<JRM_BFJobReportItem> JRM_BFJobReportItem { get; set; }


       
    }
}