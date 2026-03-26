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
    [Entity(TableCnName = "T_PRD_PPBOMENTRY_C",TableName = "T_PRD_PPBOMENTRY_C",DBServer = "TestDbContext")]
    public partial class T_PRD_PPBOMENTRY_C:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISSUETYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISSUETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISGETSCRAP")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISGETSCRAP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBACKFLUSHTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FBACKFLUSHTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOWOVER")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FALLOWOVER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOVERRATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FOVERRATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOWNERTYPEID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FOWNERTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOWNERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FOWNERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYORG")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSUPPLYORG { get; set; }

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
       [Display(Name ="FPOSITIONNO")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string FPOSITIONNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCTRANSORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCTRANSORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCTRANSSTOCKID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCTRANSSTOCKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCTRANSSTOCKLOCID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSRCTRANSSTOCKLOCID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISKEYCOMPONENT")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISKEYCOMPONENT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FRESERVETYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FRESERVETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRIORITY")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRIORITY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISSKIP")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FISSKIP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPLACEPOLICY")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FREPLACEPOLICY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPLACETYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FREPLACETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPLACEPRIORITY")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FREPLACEPRIORITY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWORKCALID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FWORKCALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYGROUP")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSUPPLYGROUP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOVERCONTROLMODE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FOVERCONTROLMODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSMID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSMENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSMENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCHILDSUPPLYORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCHILDSUPPLYORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPTQUEUE")]
       [MaxLength(8)]
       [Column(TypeName="nvarchar(8)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FOPTQUEUE { get; set; }

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
       [Display(Name ="FENTRUSTPICKORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRUSTPICKORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FROWID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FROWID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPARENTROWID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
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
       [Display(Name ="FISMINISSUEQTY")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISMINISSUEQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPPBOMENTRYTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPPBOMENTRYTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUPDATERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FUPDATERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUPDATEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FUPDATEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FGROUPBYOWNERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FGROUPBYOWNERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYMODE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSUPPLYMODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISMRPRUN")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISMRPRUN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCHECKRETURNMTRL")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCHECKRETURNMTRL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASERETURNAPPSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASERETURNAPPSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FRETURNAPPSELQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FRETURNAPPSELQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOCATEQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FALLOCATEQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEALLOCATEQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEALLOCATEQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLACCUYIELDRATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? FBILLACCUYIELDRATE { get; set; }

       
    }
}