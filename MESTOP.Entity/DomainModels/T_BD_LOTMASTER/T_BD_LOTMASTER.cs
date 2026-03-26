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
    [Entity(TableCnName = "T_BD_LOTMASTER",TableName = "T_BD_LOTMASTER",DBServer = "TestDbContext")]
    public partial class T_BD_LOTMASTER:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FLOTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLOTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMASTERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMASTERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMATERIALID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMATERIALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAUXPROPERTYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FAUXPROPERTYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FNUMBER")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOTSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FLOTSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDOCUMENTSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDOCUMENTSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSUPPLYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLYLOT")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FSUPPLYLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCEDEPTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRODUCEDEPTID { get; set; }

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
       public DateTime? FCREATEDATE { get; set; }

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
       public DateTime? FMODIFYDATE { get; set; }

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
       [Display(Name ="FFORBIDSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FFORBIDSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBIZTYPE")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBIZTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCUSTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCUSTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCANCELSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCANCELSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FINSTOCKDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_LENTH")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_LENTH { get; set; }

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
       [Display(Name ="F_PASF_MATBATCHNO")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MATBATCHNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_WARRANTY")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_WARRANTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_STANDARD")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_STANDARD { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_QUALEVEL")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_QUALEVEL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_QUADES")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_QUADES { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_DESTINATION")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_DESTINATION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_BARRELCORES")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_BARRELCORES { get; set; }

       
    }
}