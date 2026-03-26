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
    [Entity(TableCnName = "T_PRD_MOENTRY_A",TableName = "T_PRD_MOENTRY_A",DBServer = "TestDbContext")]
    public partial class T_PRD_MOENTRY_A:TestEntity
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
       [Display(Name ="FSTOCKINQUASELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINQUASELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINQUASELAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINQUASELAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINFAILSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINFAILSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINFAILSELAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINFAILSELAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINQUAQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINQUAQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINQUAAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINQUAAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINFAILQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINFAILQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINFAILAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINFAILAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPQUAQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPQUAQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPFAILQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPFAILQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPFAILAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPFAILAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPQUAAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPQUAAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPLANCONFIRMDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FPLANCONFIRMDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSCHEDULEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FSCHEDULEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCONVEYDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCONVEYDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTARTDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FSTARTDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFINISHDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FFINISHDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCLOSEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCLOSEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCOSTDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCOSTDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATETYPE")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCREATETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPQUASELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPQUASELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPQUASELAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPQUASELAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPFAILSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPFAILSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPFAILSELAUXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPFAILSELAUXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRIORITY")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPRIORITY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREQTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FREQTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTOCKREADYQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTOCKREADYQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKREADYQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKREADYQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASERPTFINISHQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASERPTFINISHQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FRPTFINISHQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FRPTFINISHQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEREPAIRQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEREPAIRQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTOCKINSCRAPSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTOCKINSCRAPSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINSCRAPSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINSCRAPSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTOCKINSCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTOCKINSCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINSCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINSCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPAIRQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FREPAIRQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKOWNERTYPEID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FINSTOCKOWNERTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKOWNERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FINSTOCKOWNERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FINSTOCKTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCHECKPRODUCT")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCHECKPRODUCT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOUTPUTOPTQUEUE")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       public string FOUTPUTOPTQUEUE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FYIELDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FYIELDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQAIP")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FQAIP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISBACKFLUSH")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISBACKFLUSH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREQSRC")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FREQSRC { get; set; }

       
    }
}