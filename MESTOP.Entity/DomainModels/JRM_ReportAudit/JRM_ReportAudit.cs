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
    [Entity(TableCnName = "生产日报表",TableName = "JRM_ReportAudit",DBServer = "ServiceDbContext")]
    public partial class JRM_ReportAudit:ServiceEntity
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
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///班组
       /// </summary>
       [Display(Name ="班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TeamGroup { get; set; }

       /// <summary>
       ///参与人
       /// </summary>
       [Display(Name ="参与人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Participants { get; set; }

       /// <summary>
       ///不良现象
       /// </summary>
       [Display(Name ="不良现象")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string DefectName { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///来料重量
       /// </summary>
       [Display(Name ="来料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///出料重量
       /// </summary>
       [Display(Name ="出料重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///出料长度
       /// </summary>
       [Display(Name ="出料长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///出料厚度
       /// </summary>
       [Display(Name ="出料厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///出料宽度
       /// </summary>
       [Display(Name ="出料宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///工序要求
       /// </summary>
       [Display(Name ="工序要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessRequest { get; set; }

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
       ///
       /// </summary>
       [Key]
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid PID { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

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
       ///卷号ID
       /// </summary>
       [Display(Name ="卷号ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="IsInWarehouse")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsInWarehouse { get; set; }

       /// <summary>
       ///材质牌号
       /// </summary>
       [Display(Name ="材质牌号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///子计划号要求
       /// </summary>
       [Display(Name ="子计划号要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkChildOrderDesc { get; set; }

       /// <summary>
       ///报表审核
       /// </summary>
       [Display(Name ="报表审核")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ReportAudit { get; set; }

       /// <summary>
       ///审核人
       /// </summary>
       [Display(Name ="审核人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ReportReviewer { get; set; }

       
    }
}