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
    [Entity(TableCnName = "入库管理",TableName = "T_PRD_INSTOCK") ]
    public partial class T_PRD_INSTOCK:TestEntity
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
       [Display(Name ="FFORMID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FFORMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLTYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FBILLTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRDORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRDORGID { get; set; }

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
       [Display(Name ="FDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FDATE { get; set; }

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
       [Display(Name ="FCREATORID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCREATORID { get; set; }

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
       [Display(Name ="FAPPROVERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FAPPROVERID { get; set; }

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
       [Display(Name ="FMODIFIERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMODIFIERID { get; set; }

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
       [Display(Name ="FCANCELER")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCANCELER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCANCELDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCANCELDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCANCELSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FCANCELSTATUS { get; set; }

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
       [Display(Name ="FFINDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FFINDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCURRID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FCURRID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSTOCKERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FIOSBIZTYPEID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FIOSBIZTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISENTRUST")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FISENTRUST { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRUSTINSTOCKID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRUSTINSTOCKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISIOSFORFIN")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FISIOSFORFIN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISGENFORIOS")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISGENFORIOS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISTRAN")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FISTRAN { get; set; }

       //[Display(Name ="T_PRD_INSTOCKENTRY")]
       //[ForeignKey("FID")]
       //public List<T_PRD_INSTOCKENTRY> T_PRD_INSTOCKENTRY { get; set; }


       
    }
}