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
    [Entity(TableCnName = "WOC_ProductAdd_JT",TableName = "WOC_ProductAdd_JT",DBServer = "SysDbContext")]
    public partial class WOC_ProductAdd_JT:SysEntity
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
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderCode")]
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
       [Display(Name ="RealEndTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

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
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

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
       [Display(Name ="OutThicknessUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutLengthUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutWidthUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutWeightUnit")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NEWFLOT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

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
       [Display(Name ="FLOTNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

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
       [Display(Name ="OrgCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

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
       [Display(Name ="ProductDesc")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

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
       [Display(Name ="FPRODUCTTYPE")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRODUCTTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MarkNumber")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MarkNumber { get; set; }

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
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MainFlot")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MainFlot { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FlotLevel")]
       [Column(TypeName="int")]
       public int? FlotLevel { get; set; }

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
       [Display(Name ="HV")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HV { get; set; }

       
    }
}