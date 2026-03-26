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
    [Entity(TableCnName = "分切成品检",TableName = "QCM_FinalIpc_FS",DetailTable =  new Type[] { typeof(QCM_FinalIpc_FSItem)},DetailTableCnName = "分卷信息",DBServer = "ServiceDbContext")]
    public partial class QCM_FinalIpc_FS:ServiceEntity
    {
        /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

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
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
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
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
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
       ///
       /// </summary>
       [Display(Name ="ProcessFlowCode")]
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
       ///计划号需求
       /// </summary>
       [Display(Name ="计划号需求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkOrderDesc { get; set; }

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
       ///计划号状态
       /// </summary>
       [Display(Name ="计划号状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///实际开工时间
       /// </summary>
       [Display(Name ="实际开工时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealStartTime { get; set; }

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
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///生产日期
       /// </summary>
       [Display(Name ="生产日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

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
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkChildOrderDesc")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkChildOrderDesc { get; set; }

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
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///机组编码
       /// </summary>
       [Display(Name ="机组编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationName { get; set; }

       /// <summary>
       ///操作人
       /// </summary>
       [Display(Name ="操作人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string operatorworkers { get; set; }

       /// <summary>
       ///参与人
       /// </summary>
       [Display(Name ="参与人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Reportingworkers { get; set; }

       /// <summary>
       ///工序状态
       /// </summary>
       [Display(Name ="工序状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TeamGroup")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string TeamGroup { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Isinspection")]
       [Column(TypeName="int")]
       public int? Isinspection { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Participants")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Participants { get; set; }

       /// <summary>
       ///出料厚度
       /// </summary>
       [Display(Name ="出料厚度")]
       [Column(TypeName="float")]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///出料长度
       /// </summary>
       [Display(Name ="出料长度")]
       [Column(TypeName="float")]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///出料宽度
       /// </summary>
       [Display(Name ="出料宽度")]
       [Column(TypeName="float")]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///出料重量
       /// </summary>
       [Display(Name ="出料重量")]
       [Column(TypeName="float")]
       public float? OutWeightUnit { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="isSplitting")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       public string isSplitting { get; set; }

       /// <summary>
       ///来料规格
       /// </summary>
       [Display(Name ="来料规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string MaterialCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string MaterialName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialGrade")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="QualityStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       public string QualityStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NextProcess")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? NextProcess { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PreviousProcess")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? PreviousProcess { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessRequest")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string ProcessRequest { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FeedSort")]
       [Column(TypeName="int")]
       public int? FeedSort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOTNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isProducts")]
       [Column(TypeName="int")]
       public int? isProducts { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///是否检验
       /// </summary>
       [Display(Name ="是否检验")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isFinalJug { get; set; }

       /// <summary>
       ///产品规格
       /// </summary>
       [Display(Name ="产品规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       public int? F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string F_PASF_NEWPREFIX { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ERpId")]
       [Column(TypeName="int")]
       public int? ERpId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DefectName")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string DefectName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Remark")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Remark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RequestNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string RequestNo { get; set; }

       /// <summary>
       ///是否入库
       /// </summary>
       [Display(Name ="是否入库")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsInWarehouse { get; set; }

       /// <summary>
       ///入库递交
       /// </summary>
       [Display(Name ="入库递交")]
       [Column(TypeName="int")]
       public int? isInSubmit { get; set; }

       /// <summary>
       ///入库审核
       /// </summary>
       [Display(Name ="入库审核")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isInAudit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CoatingName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string CoatingName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ThicknessTol")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string ThicknessTol { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WidthTol")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string WidthTol { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Meters")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Meters { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Burr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Burr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string YieldStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TensileStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string TensileStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BreakElo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string BreakElo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceRou_Up")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SurfaceRou_Up { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceRou_Down")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SurfaceRou_Down { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SurfaceGlo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SurfaceGlo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="VickersHar")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string VickersHar { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RockwellHar")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string RockwellHar { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NickelThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string NickelThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Iron_NickelThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Iron_NickelThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SaltSpr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SaltSpr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeelStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string PeelStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HeatSealStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HeatSealStr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldToStrRat")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string YieldToStrRat { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FilmThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string FilmThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BasebandThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string BasebandThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ChromiumThk")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string ChromiumThk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HR30T")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HR30T { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HRB")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HRB { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HR30N")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HR30N { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HNC")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HNC { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="HV")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string HV { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LowRoller")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string LowRoller { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UpRoller")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string UpRoller { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrReL")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string YieldStrReL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrReH")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string YieldStrReH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="YieldStrRp02")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string YieldStrRp02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollMet")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SingleRollMet { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollWid")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SingleRollWid { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SingleRollWe")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string SingleRollWe { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Elo")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Elo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EloA80")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string EloA80 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EloA50")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string EloA50 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="GrossWeight")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string GrossWeight { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StockCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string StockCode { get; set; }

       /// <summary>
       ///ERP信息
       /// </summary>
       [Display(Name ="ERP信息")]
       [MaxLength(3000)]
       [Column(TypeName="nvarchar(3000)")]
       public string ERPRemark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StockName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string StockName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Annex")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Annex { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TThickness")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string TThickness { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TWidth")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string TWidth { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MThickness")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string MThickness { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWidth")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string MWidth { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Inspectors")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Inspectors { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="InspectDate")]
       [Column(TypeName="datetime")]
       public DateTime? InspectDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCTTYPE")]
       [Column(TypeName="int")]
       public int? FPRODUCTTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isSave")]
       [Column(TypeName="int")]
       public int? isSave { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReportAudit")]
       [Column(TypeName="int")]
       public int? ReportAudit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReportReviewer")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ReportReviewer { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialOutDesc")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string MaterialOutDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MarkNumber")]
       [Column(TypeName="int")]
       public int? MarkNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid PID { get; set; }

       /// <summary>
       ///检验日期
       /// </summary>
       [Display(Name ="检验日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CheckDate { get; set; }

       [Display(Name ="分卷信息")]
       [ForeignKey("PID")]
       public List<QCM_FinalIpc_FSItem> QCM_FinalIpc_FSItem { get; set; }


       
    }
}