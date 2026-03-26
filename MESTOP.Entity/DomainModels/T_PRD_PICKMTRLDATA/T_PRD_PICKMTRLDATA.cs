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
    [Entity(TableCnName = "T_PRD_PICKMTRLDATA",TableName = "T_PRD_PICKMTRLDATA",DBServer = "TestDbContext")]
    public partial class T_PRD_PICKMTRLDATA:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCBILLTYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FSRCBILLTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FSRCBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPPBOMENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPPBOMENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMATERIALID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMOID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMOBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FMOBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMOENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMOENTRYSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOENTRYSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPPBOMBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FPPBOMBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSELPRCDRETURNQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSELPRCDRETURNQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAPPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FAPPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FACTUALQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FACTUALQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOWOVERQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FALLOWOVERQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FBASEUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESELPRCDRETURNQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESELPRCDRETURNQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEAPPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEAPPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEACTUALQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEACTUALQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEALLOWOVERQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEALLOWOVERQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKSELPRCDRETURNQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKSELPRCDRETURNQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKAPPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKAPPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKACTUALQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKACTUALQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKALLOWOVERQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKALLOWOVERQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSECUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSECUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSECSELPRCDRETURNQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSECSELPRCDRETURNQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSECACTUALQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSECACTUALQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSECALLOWOVERQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSECALLOWOVERQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWORKSHOPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FWORKSHOPID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKLOCID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKLOCID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKSTATUSID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKSTATUSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKFLAG")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FSTOCKFLAG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FPRODUCEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FEXPIRYDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FEXPIRYDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FBOMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMTONO")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FMTONO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPROJECTNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FPROJECTNO { get; set; }

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
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FOPERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPROCESSID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPROCESSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAUXPROPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FAUXPROPID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRICE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FPRICE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAMOUNT")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FAMOUNT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCINTERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCINTERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCENTRYSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCENTRYSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBFLOWID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBFLOWID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPLANENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPLANENTRYID { get; set; }

       
    }
}