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
    [Entity(TableCnName = "分卷工序",TableName = "WOC_ProcessWorkFlow",DBServer = "ServiceDbContext")]
    public partial class WOC_ProcessWorkFlow:ServiceEntity
    {
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
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

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
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

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
       ///工单需求
       /// </summary>
       [Display(Name ="工单需求")]
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
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///实际开始时间
       /// </summary>
       [Display(Name ="实际开始时间")]
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
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
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
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///卷号ID
       /// </summary>
       [Display(Name ="卷号ID")]
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
       ///操作工人
       /// </summary>
       [Display(Name ="操作工人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string operatorworkers { get; set; }

       /// <summary>
       ///报工人
       /// </summary>
       [Display(Name ="报工人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Reportingworkers { get; set; }

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
       ///检验
       /// </summary>
       [Display(Name ="检验")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Isinspection { get; set; }

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
       ///出料重量
       /// </summary>
       [Display(Name ="出料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
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
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///是否分卷
       /// </summary>
       [Display(Name ="是否分卷")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string isSplitting { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="QualityStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

       /// <summary>
       ///上个工序
       /// </summary>
       [Display(Name ="上个工序")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? NextProcess { get; set; }

       /// <summary>
       ///下个工序
       /// </summary>
       [Display(Name ="下个工序")]
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
       ///装炉顺序
       /// </summary>
       [Display(Name ="装炉顺序")]
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
       ///是否成品
       /// </summary>
       [Display(Name ="是否成品")]
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
       ///纵剪数量
       /// </summary>
       [Display(Name ="纵剪数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? F_PASF_VOLUME { get; set; }

       /// <summary>
       ///纵剪卷号前缀
       /// </summary>
       [Display(Name ="纵剪卷号前缀")]
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
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///检验结果
       /// </summary>
       [Display(Name ="检验结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///不良现象
       /// </summary>
       [Display(Name ="不良现象")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string DefectName { get; set; }

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
       [Display(Name ="IsInWarehouse")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsInWarehouse { get; set; }

       /// <summary>
       ///入库递交
       /// </summary>
       [Display(Name ="入库递交")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isInSubmit { get; set; }

       /// <summary>
       ///入库审核
       /// </summary>
       [Display(Name ="入库审核")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isInAudit { get; set; }

       /// <summary>
       ///厚度公差
       /// </summary>
       [Display(Name ="厚度公差")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ThicknessTol { get; set; }

       /// <summary>
       ///宽度公差
       /// </summary>
       [Display(Name ="宽度公差")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WidthTol { get; set; }

       /// <summary>
       ///米数
       /// </summary>
       [Display(Name ="米数")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Meters { get; set; }

       /// <summary>
       ///毛刺
       /// </summary>
       [Display(Name ="毛刺")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Burr { get; set; }

       /// <summary>
       ///屈服强度
       /// </summary>
       [Display(Name ="屈服强度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStr { get; set; }

       /// <summary>
       ///抗拉强度
       /// </summary>
       [Display(Name ="抗拉强度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TensileStr { get; set; }

       /// <summary>
       ///断后伸长率
       /// </summary>
       [Display(Name ="断后伸长率")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string BreakElo { get; set; }

       /// <summary>
       ///表面光泽度
       /// </summary>
       [Display(Name ="表面光泽度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceGlo { get; set; }

       /// <summary>
       ///维氏硬度
       /// </summary>
       [Display(Name ="维氏硬度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string VickersHar { get; set; }

       /// <summary>
       ///洛氏硬度
       /// </summary>
       [Display(Name ="洛氏硬度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string RockwellHar { get; set; }

       /// <summary>
       ///镍层厚度
       /// </summary>
       [Display(Name ="镍层厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string NickelThk { get; set; }

       /// <summary>
       ///铁镍合金层厚度
       /// </summary>
       [Display(Name ="铁镍合金层厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Iron_NickelThk { get; set; }

       /// <summary>
       ///盐雾
       /// </summary>
       [Display(Name ="盐雾")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SaltSpr { get; set; }

       /// <summary>
       ///剥离强度
       /// </summary>
       [Display(Name ="剥离强度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string PeelStr { get; set; }

       /// <summary>
       ///热封强度
       /// </summary>
       [Display(Name ="热封强度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HeatSealStr { get; set; }

       /// <summary>
       ///屈强比
       /// </summary>
       [Display(Name ="屈强比")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldToStrRat { get; set; }

       /// <summary>
       ///膜厚度
       /// </summary>
       [Display(Name ="膜厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string FilmThk { get; set; }

       /// <summary>
       ///基带厚度
       /// </summary>
       [Display(Name ="基带厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string BasebandThk { get; set; }

       /// <summary>
       ///铬层厚度
       /// </summary>
       [Display(Name ="铬层厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ChromiumThk { get; set; }

       /// <summary>
       ///HR30T
       /// </summary>
       [Display(Name ="HR30T")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HR30T { get; set; }

       /// <summary>
       ///HRB
       /// </summary>
       [Display(Name ="HRB")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HRB { get; set; }

       /// <summary>
       ///HR30N
       /// </summary>
       [Display(Name ="HR30N")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HR30N { get; set; }

       /// <summary>
       ///HNC
       /// </summary>
       [Display(Name ="HNC")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HNC { get; set; }

       /// <summary>
       ///HV
       /// </summary>
       [Display(Name ="HV")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HV { get; set; }

       /// <summary>
       ///下辊
       /// </summary>
       [Display(Name ="下辊")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string LowRoller { get; set; }

       /// <summary>
       ///上辊
       /// </summary>
       [Display(Name ="上辊")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string UpRoller { get; set; }

       /// <summary>
       ///屈服强度（ReL）
       /// </summary>
       [Display(Name ="屈服强度（ReL）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrReL { get; set; }

       /// <summary>
       ///屈服强度（ReH）
       /// </summary>
       [Display(Name ="屈服强度（ReH）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrReH { get; set; }

       /// <summary>
       ///单卷米数
       /// </summary>
       [Display(Name ="单卷米数")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollMet { get; set; }

       /// <summary>
       ///单卷宽度
       /// </summary>
       [Display(Name ="单卷宽度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollWid { get; set; }

       /// <summary>
       ///单卷重量
       /// </summary>
       [Display(Name ="单卷重量")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SingleRollWe { get; set; }

       /// <summary>
       ///屈服强度（Rp0.2）
       /// </summary>
       [Display(Name ="屈服强度（Rp0.2）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrRp02 { get; set; }

       /// <summary>
       ///伸长率（%）
       /// </summary>
       [Display(Name ="伸长率（%）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Elo { get; set; }

       /// <summary>
       ///伸长率（A80%）
       /// </summary>
       [Display(Name ="伸长率（A80%）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EloA80 { get; set; }

       /// <summary>
       ///伸长率（A50%）
       /// </summary>
       [Display(Name ="伸长率（A50%）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EloA50 { get; set; }

       /// <summary>
       ///材质牌号
       /// </summary>
       [Display(Name ="材质牌号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///产品毛重
       /// </summary>
       [Display(Name ="产品毛重")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string GrossWeight { get; set; }

       /// <summary>
       ///膜名称
       /// </summary>
       [Display(Name ="膜名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
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
       ///附件
       /// </summary>
       [Display(Name ="附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Annex { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人编号
       /// </summary>
       [Display(Name ="创建人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人编号
       /// </summary>
       [Display(Name ="修改人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///子计划要求
       /// </summary>
       [Display(Name ="子计划要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkChildOrderDesc { get; set; }

       /// <summary>
       ///实测厚度
       /// </summary>
       [Display(Name ="实测厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MThickness { get; set; }

       /// <summary>
       ///实测宽度
       /// </summary>
       [Display(Name ="实测宽度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MWidth { get; set; }

       /// <summary>
       ///试样厚度
       /// </summary>
       [Display(Name ="试样厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TThickness { get; set; }

       /// <summary>
       ///试样宽度
       /// </summary>
       [Display(Name ="试样宽度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TWidth { get; set; }

       /// <summary>
       ///检验员
       /// </summary>
       [Display(Name ="检验员")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Inspectors { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCTTYPE")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRODUCTTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isSave")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isSave { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReportAudit")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ReportAudit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReportReviewer")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ReportReviewer { get; set; }

       /// <summary>
       ///产出规格
       /// </summary>
       [Display(Name ="产出规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialOutDesc { get; set; }

       /// <summary>
       ///表面粗糙度(上)
       /// </summary>
       [Display(Name ="表面粗糙度(上)")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Up { get; set; }

       /// <summary>
       ///表面粗糙度(下)
       /// </summary>
       [Display(Name ="表面粗糙度(下)")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Down { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="InspectDate")]
       [Column(TypeName="datetime")]
       public DateTime? InspectDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MarkNumber")]
       [Column(TypeName="int")]
       public int? MarkNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? ParentId { get; set; }

       
    }
}