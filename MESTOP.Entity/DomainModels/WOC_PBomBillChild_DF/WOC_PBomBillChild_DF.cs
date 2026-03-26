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
    [Entity(TableCnName = "WOC_PBomBillChild_DF",TableName = "WOC_PBomBillChild_DF",DBServer = "SysDbContext")]
    public partial class WOC_PBomBillChild_DF:SysEntity
    {
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
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FID { get; set; }

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
       [Display(Name ="FMATERIALID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

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
       [Display(Name ="WorkOrderCode")]
       [MaxLength(87)]
       [Column(TypeName="nvarchar(87)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

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
       [Display(Name ="FUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MasterUOM")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

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
       [Display(Name ="FMOENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ReceiveQty")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public decimal? ReceiveQty { get; set; }

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
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       
    }
}