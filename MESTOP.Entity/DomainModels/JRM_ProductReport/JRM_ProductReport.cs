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
    [Entity(TableCnName = "生产填报",TableName = "JRM_ProductReport",DetailTable =  new Type[] { typeof(JRM_ProductReportSub),typeof(JRM_ProductReport_FM)},DetailTableCnName = "分卷明细,覆膜明细",DBServer = "ServiceDbContext")]
    public partial class JRM_ProductReport:ServiceEntity
    {
        /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///来料编码
       /// </summary>
       [Display(Name ="来料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///来料名称
       /// </summary>
       [Display(Name ="来料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///来料规格
       /// </summary>
       [Display(Name ="来料规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///组织
       /// </summary>
       [Display(Name ="组织")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///班组
       /// </summary>
       [Display(Name ="班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TeamGroup { get; set; }

       /// <summary>
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

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
       ///当前工序
       /// </summary>
       [Display(Name ="当前工序")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序状态
       /// </summary>
       [Display(Name ="工序状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///实际开工时间
       /// </summary>
       [Display(Name ="实际开工时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///实际结束时间
       /// </summary>
       [Display(Name ="实际结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///计划工艺
       /// </summary>
       [Display(Name ="计划工艺")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///参与人
       /// </summary>
       [Display(Name ="参与人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Participants { get; set; }

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
       ///出料重量
       /// </summary>
       [Display(Name ="出料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///操作员
       /// </summary>
       [Display(Name ="操作员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string operatorworkers { get; set; }

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
       ///原卷号ID
       /// </summary>
       [Display(Name ="原卷号ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///ERP工单ID
       /// </summary>
       [Display(Name ="ERP工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///自检操作员
       /// </summary>
       [Display(Name ="自检操作员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Reportingworkers { get; set; }

       /// <summary>
       ///出料厚度
       /// </summary>
       [Display(Name ="出料厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///来料厚度
       /// </summary>
       [Display(Name ="来料厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ThicknessUnit { get; set; }

       /// <summary>
       ///来料长度
       /// </summary>
       [Display(Name ="来料长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? LengthUnit { get; set; }

       /// <summary>
       ///来料宽度
       /// </summary>
       [Display(Name ="来料宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WidthUnit { get; set; }

       /// <summary>
       ///来料重量
       /// </summary>
       [Display(Name ="来料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///是否原卷
       /// </summary>
       [Display(Name ="是否原卷")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string isSplitting { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? WID { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="ProcessCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WORequiredQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PlanStartTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PlanEndTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///机组编码
       /// </summary>
       [Display(Name ="机组编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Isinspection")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Isinspection { get; set; }

       /// <summary>
       ///桶芯
       /// </summary>
       [Display(Name ="桶芯")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="FLOTNumber")]
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
       ///产品规格
       /// </summary>
       [Display(Name ="产品规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///膜名称
       /// </summary>
       [Display(Name ="膜名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CoatingName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isFinalJug")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isFinalJug { get; set; }

       /// <summary>
       ///附件
       /// </summary>
       [Display(Name ="附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Annex { get; set; }

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
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

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
       [Display(Name ="Modifier")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

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
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isSave")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isSave { get; set; }

       /// <summary>
       ///产出规格
       /// </summary>
       [Display(Name ="产出规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialOutDesc { get; set; }

       /// <summary>
       ///材质
       /// </summary>
       [Display(Name ="材质")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///报工检验员
       /// </summary>
       [Display(Name ="报工检验员")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ReprotInspector { get; set; }

       /// <summary>
       ///去向
       /// </summary>
       [Display(Name ="去向")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_DESTINATION { get; set; }

       /// <summary>
       ///桶芯
       /// </summary>
       [Display(Name ="桶芯")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_BARRELCORES { get; set; }

       /// <summary>
       ///工时
       /// </summary>
       [Display(Name ="工时")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string workhour { get; set; }

       /// <summary>
       ///手动输入工时
       /// </summary>
       [Display(Name ="手动输入工时")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Manualworkhour { get; set; }

       /// <summary>
       ///不良现象
       /// </summary>
       [Display(Name ="不良现象")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string DefectName { get; set; }

       /// <summary>
       ///不良备注
       /// </summary>
       [Display(Name ="不良备注")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       [Display(Name ="分卷明细")]
       [ForeignKey("PID")]
       public List<JRM_ProductReportSub> JRM_ProductReportSub { get; set; }


       [Display(Name ="覆膜明细")]
       [ForeignKey("PID")]
       public List<JRM_ProductReport_FM> JRM_ProductReport_FM { get; set; }


       
    }
}