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
    [Entity(TableCnName = "覆膜明细",TableName = "JRM_ProductReportFM",DBServer = "ServiceDbContext")]
    public partial class JRM_ProductReportFM:ServiceEntity
    {
        /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///产品编码
       /// </summary>
       [Display(Name ="产品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///实收数量
       /// </summary>
       [Display(Name ="实收数量")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal ReceiveQty { get; set; }

       /// <summary>
       ///应收数量
       /// </summary>
       [Display(Name ="应收数量")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEAPPQTY { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///用料清单号
       /// </summary>
       [Display(Name ="用料清单号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string FSRCBILLNO { get; set; }

       /// <summary>
       ///领料单号
       /// </summary>
       [Display(Name ="领料单号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string FBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       public int? MWOId { get; set; }

       /// <summary>
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string ParentWorderCode { get; set; }

       
    }
}