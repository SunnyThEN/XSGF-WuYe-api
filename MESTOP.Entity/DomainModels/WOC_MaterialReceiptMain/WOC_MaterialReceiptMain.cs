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
    [Entity(TableCnName = "生产领料",TableName = "WOC_MaterialReceiptMain",DetailTable =  new Type[] { typeof(WOC_MaterialReceiptChild)},DetailTableCnName = "领料单明细",DBServer = "ServiceDbContext")]
    public partial class WOC_MaterialReceiptMain:ServiceEntity
    {
        /// <summary>
       ///领料单编码
       /// </summary>
       [Display(Name ="领料单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="MreceiptMId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid MreceiptMId { get; set; }

       /// <summary>
       ///用料清单编码
       /// </summary>
       [Display(Name ="用料清单编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FBILLNO { get; set; }

       /// <summary>
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///ERP交互信息
       /// </summary>
       [Display(Name ="ERP交互信息")]
       [MaxLength(3000)]
       [Column(TypeName="nvarchar(3000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(87)]
       [Column(TypeName="nvarchar(87)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Mid { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///产出品短码
       /// </summary>
       [Display(Name ="产出品短码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///需求
       /// </summary>
       [Display(Name ="需求")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal WORequiredQty { get; set; }

       /// <summary>
       ///车间id
       /// </summary>
       [Display(Name ="车间id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FWORKSHOPID { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
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
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BOMCode { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///物料清单ID
       /// </summary>
       [Display(Name ="物料清单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///计量单位
       /// </summary>
       [Display(Name ="计量单位")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///领料递交
       /// </summary>
       [Display(Name ="领料递交")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SubmitStatus { get; set; }

       /// <summary>
       ///审核状态
       /// </summary>
       [Display(Name ="审核状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? AuditStatus { get; set; }

       /// <summary>
       ///审核单据编码
       /// </summary>
       [Display(Name ="审核单据编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AuditFBILLNO { get; set; }

       [Display(Name ="领料单明细")]
       [ForeignKey("MreceiptMId")]
       public List<WOC_MaterialReceiptChild> WOC_MaterialReceiptChild { get; set; }


       
    }
}