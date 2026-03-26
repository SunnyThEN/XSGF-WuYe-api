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
    [Entity(TableCnName = "生产领料单子项明细",TableName = "WOC_MaterialReceiptChild",DBServer = "ServiceDbContext")]
    public partial class WOC_MaterialReceiptChild:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="MreceiptCId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid MreceiptCId { get; set; }

       /// <summary>
       ///子项ID
       /// </summary>
       [Display(Name ="子项ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///领料单ID
       /// </summary>
       [Display(Name ="领料单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FID { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSEQ { get; set; }

       /// <summary>
       ///ERP物料ID
       /// </summary>
       [Display(Name ="ERP物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///子项ID
       /// </summary>
       [Display(Name ="子项ID")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMATERIALTYPE { get; set; }

       /// <summary>
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FMOTYPE { get; set; }

       /// <summary>
       ///工单ID
       /// </summary>
       [Display(Name ="工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOID { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(87)]
       [Column(TypeName="nvarchar(87)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///需求日期
       /// </summary>
       [Display(Name ="需求日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FNEEDDATE { get; set; }

       /// <summary>
       ///单位ID
       /// </summary>
       [Display(Name ="单位ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUNITID { get; set; }

       /// <summary>
       ///计量单位
       /// </summary>
       [Display(Name ="计量单位")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///标准用量
       /// </summary>
       [Display(Name ="标准用量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTDQTY { get; set; }

       /// <summary>
       ///需求用量
       /// </summary>
       [Display(Name ="需求用量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FNEEDQTY { get; set; }

       /// <summary>
       ///应发数量
       /// </summary>
       [Display(Name ="应发数量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FMUSTQTY { get; set; }

       /// <summary>
       ///子工单ID
       /// </summary>
       [Display(Name ="子工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOENTRYID { get; set; }

       /// <summary>
       ///实收数量
       /// </summary>
       [Display(Name ="实收数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ReceiveQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MreceiptMId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid MreceiptMId { get; set; }

       /// <summary>
       ///原卷ID
       /// </summary>
       [Display(Name ="原卷ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       
    }
}