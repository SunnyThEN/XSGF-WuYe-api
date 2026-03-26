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
    [Entity(TableCnName = "WOC_PBomBillMain_DF",TableName = "WOC_PBomBillMain_DF",DBServer = "SysDbContext")]
    public partial class WOC_PBomBillMain_DF:SysEntity
    {
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
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

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
       [Display(Name ="Mid")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Mid { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductShortCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WORequiredQty")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal WORequiredQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWORKSHOPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FWORKSHOPID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgCode { get; set; }

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
       [Display(Name ="BOMCode")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BOMCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMVersion")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

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
       [Display(Name ="MasterUOM")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       
    }
}