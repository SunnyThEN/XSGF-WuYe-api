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
    [Entity(TableCnName = "WOC_ReceiptMain_DF",TableName = "WOC_ReceiptMain_DF",DBServer = "SysDbContext")]
    public partial class WOC_ReceiptMain_DF:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="MreceiptMId")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid MreceiptMId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

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
       [Display(Name ="AuditFBILLNO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AuditFBILLNO { get; set; }

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

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SubmitStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SubmitStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AuditStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? AuditStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Remark")]
       [MaxLength(3000)]
       [Column(TypeName="nvarchar(3000)")]
       [Editable(true)]
       public string Remark { get; set; }

       
    }
}