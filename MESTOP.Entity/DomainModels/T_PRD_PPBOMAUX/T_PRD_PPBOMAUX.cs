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
    [Entity(TableCnName = "用料清单辅助数据",TableName = "T_PRD_PPBOMAUX",DBServer = "TestDbContext")]
    public partial class T_PRD_PPBOMAUX:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDATAVALUE")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDATAVALUE { get; set; }

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
       [Display(Name ="FMOTYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FMOTYPE { get; set; }

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
       [Display(Name ="FBOMID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FBOMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FBOMENTRYID { get; set; }

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
       [Display(Name ="FMATERIALTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMATERIALTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREPLACEGROUP")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FREPLACEGROUP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOFFSETTIME")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FOFFSETTIME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FTIMEUNIT")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FTIMEUNIT { get; set; }

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
       [Display(Name ="FDOSAGETYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDOSAGETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUSERATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FUSERATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEBOMNUMERATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEBOMNUMERATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEBOMDENOMINATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEBOMDENOMINATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASENUMERATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASENUMERATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEDENOMINATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEDENOMINATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMNUMERATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBOMNUMERATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMDENOMINATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBOMDENOMINATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FNUMERATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FNUMERATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDENOMINATOR")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FDENOMINATOR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUNITID { get; set; }

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
       [Display(Name ="FFIXSCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? FFIXSCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEFIXSCRAPQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? FBASEFIXSCRAPQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSCRAPRATE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? FSCRAPRATE { get; set; }

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
       [Display(Name ="FNEEDDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FNEEDDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASESTDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASESTDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASENEEDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASENEEDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEMUSTQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEMUSTQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FNEEDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FNEEDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMUSTQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FMUSTQTY { get; set; }

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
       [Display(Name ="FISKEYITEM")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISKEYITEM { get; set; }

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
       [Display(Name ="FPATHENTRYID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string FPATHENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSUPPLYTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCPATHENTRYID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       public string FSRCPATHENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISEXPAND")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISEXPAND { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_UN_JOINPREPICKBASEQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal F_UN_JOINPREPICKBASEQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPCODE")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string FOPCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FF100001")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FF100001 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCALCOL")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FCALCOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMASTERID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMASTERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATEORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FCREATEORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUSEORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUSEORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATORID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FCREATORID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime FCREATEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMODIFIERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMODIFIERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMODIFYDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime FMODIFYDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FFORBIDSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FFORBIDERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FFORBIDDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPARENTID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPARENTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FNUMBER")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISSYSPRESET")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISSYSPRESET { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAPPROVEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FAPPROVEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAPPROVERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FAPPROVERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDOCUMENTSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FDOCUMENTSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFeeRate")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FFeeRate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCARDSTAMPINGFEES")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FCARDSTAMPINGFEES { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCostLimit")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FCostLimit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCostLower")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FCostLower { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FTopAmt_CMK")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FTopAmt_CMK { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPKID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOCALEID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLOCALEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDESCRIPTION")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDESCRIPTION { get; set; }

       
    }
}