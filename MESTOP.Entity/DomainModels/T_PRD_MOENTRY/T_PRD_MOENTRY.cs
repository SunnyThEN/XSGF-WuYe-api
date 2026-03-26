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
    [Entity(TableCnName = "T_PRD_MOENTRY",TableName = "T_PRD_MOENTRY",DBServer = "TestDbContext")]
    public partial class T_PRD_MOENTRY:TestEntity
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
       [Display(Name ="FGROUP")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FGROUP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCTTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FPRODUCTTYPE { get; set; }

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
       [Display(Name ="FBASEUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FBASEUNITID { get; set; }

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
       [Display(Name ="FBASEUNITQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEUNITQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPLANSTARTDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FPLANSTARTDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPLANFINISHDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FPLANFINISHDATE { get; set; }

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
       [Display(Name ="FROUTINGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FROUTINGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FYIELDRATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FYIELDRATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREQUESTORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FREQUESTORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINLIMITH")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINLIMITH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTOCKINLIMITH")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTOCKINLIMITH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINULRATIO")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINULRATIO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINLIMITL")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINLIMITL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTOCKINLIMITL")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTOCKINLIMITL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINLLRATIO")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINLLRATIO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISSUSPEND")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISSUSPEND { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKINORGID { get; set; }

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
       [Display(Name ="FSTOCKLOCID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKLOCID { get; set; }

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
       [Display(Name ="FCOSTRATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? FCOSTRATE { get; set; }

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
       [Display(Name ="FSRCBILLID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCBILLID { get; set; }

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
       [Display(Name ="FSRCBILLENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCBILLENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCBILLENTRYSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCBILLENTRYSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSALEORDERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSALEORDERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSALEORDERNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FSALEORDERNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSALEORDERENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSALEORDERENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSALEORDERENTRYSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSALEORDERENTRYSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEYIELDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEYIELDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCOPYENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCOPYENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FROWID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FROWID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPARENTROWID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPARENTROWID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FROWEXPANDTYPE")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FROWEXPANDTYPE { get; set; }

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
       [Display(Name ="FWORKSHOPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FWORKSHOPID { get; set; }

       ///// <summary>
       /////
       ///// </summary>
       //[Display(Name ="F_PASF_LENTH")]
       //[Column(TypeName="numeric")]
       //[Editable(true)]
       //[Required(AllowEmptyStrings=false)]
       //public decimal F_PASF_LENTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_PRDTYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_PRDTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_MANUFACTURER")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MANUFACTURER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NEWPREFIX { get; set; }

       
    }
}