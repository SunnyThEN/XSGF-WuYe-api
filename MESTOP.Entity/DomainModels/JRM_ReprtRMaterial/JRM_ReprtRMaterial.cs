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
    [Entity(TableCnName = "JRM_ReprtRMaterial",TableName = "JRM_ReprtRMaterial",DBServer = "ServiceDbContext")]
    public partial class JRM_ReprtRMaterial:ServiceEntity
    {
        /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

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
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

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
       ///牌号
       /// </summary>
       [Display(Name ="牌号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///工序描述
       /// </summary>
       [Display(Name ="工序描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessRequest { get; set; }

       /// <summary>
       ///工单描述
       /// </summary>
       [Display(Name ="工单描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkOrderDesc { get; set; }

       /// <summary>
       ///母卷号
       /// </summary>
       [Display(Name ="母卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///是否退库
       /// </summary>
       [Display(Name ="是否退库")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsInWarehouse { get; set; }

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
       [Display(Name ="ProcessStepId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductName")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

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
       [Display(Name ="ProcessFlowName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

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
       [Display(Name ="WOStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

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
       [Display(Name ="OrgCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgName")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgName { get; set; }

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
       [Display(Name ="BOMVersion")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="operatorworkers")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string operatorworkers { get; set; }

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
       [Display(Name ="ProcessStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TeamGroup")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TeamGroup { get; set; }

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
       [Display(Name ="Participants")]
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
       ///出料重量
       /// </summary>
       [Display(Name ="出料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

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
       [Display(Name ="MaterialDesc")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="QualityStatus")]
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
       [Display(Name ="isProducts")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProducts { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Result")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isFinalJug")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isFinalJug { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductDesc")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="ERpId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ERpId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DefectName")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string DefectName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Remark")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RequestNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string RequestNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isInSubmit")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isInSubmit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isInAudit")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isInAudit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CoatingName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string CoatingName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ThicknessTol")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ThicknessTol { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WidthTol")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WidthTol { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Meters")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Meters { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Burr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Burr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TensileStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TensileStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BreakElo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string BreakElo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceGlo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceGlo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="VickersHar")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string VickersHar { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RockwellHar")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string RockwellHar { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NickelThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string NickelThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Iron_NickelThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Iron_NickelThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SaltSpr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SaltSpr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeelStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string PeelStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HeatSealStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HeatSealStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldToStrRat")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldToStrRat { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FilmThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string FilmThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BasebandThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string BasebandThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ChromiumThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ChromiumThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HR30T")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HR30T { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HRB")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HRB { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HR30N")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HR30N { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HNC")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HNC { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HV")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HV { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LowRoller")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string LowRoller { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UpRoller")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string UpRoller { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrReL")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrReL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrReH")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrReH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrRp02")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrRp02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollMet")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollMet { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollWid")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollWid { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollWe")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollWe { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Elo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Elo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EloA80")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EloA80 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EloA50")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EloA50 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="GrossWeight")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string GrossWeight { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StockCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string StockCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ERPRemark")]
       [MaxLength(3000)]
       [Column(TypeName="nvarchar(3000)")]
       [Editable(true)]
       public string ERPRemark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StockName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string StockName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Annex")]
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
       [Display(Name ="ProductYield")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ProductYield { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceRou_Down")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Down { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceRou_Up")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Up { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_BARRELCORES")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_BARRELCORES { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_DESTINATION")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_DESTINATION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_QUADES")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_QUADES { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_QUALEVEL")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string F_PASF_QUALEVEL { get; set; }

       
    }
}