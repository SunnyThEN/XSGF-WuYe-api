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
    [Entity(TableCnName = "付款明细",TableName = "RMS_PaymentDetails",DBServer = "SysDbContext")]
    public partial class RMS_PaymentDetails:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PaymentId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PaymentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OwnerId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int OwnerId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///业主名称
       /// </summary>
       [Display(Name ="业主名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OwnerName { get; set; }

       /// <summary>
       ///应收金额
       /// </summary>
       [Display(Name ="应收金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DueAmount { get; set; }

       /// <summary>
       ///实收金额
       /// </summary>
       [Display(Name ="实收金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ActualAmount { get; set; }

       /// <summary>
       ///优惠金额
       /// </summary>
       [Display(Name ="优惠金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DiscountAmount { get; set; }

       /// <summary>
       ///欠缴金额
       /// </summary>
       [Display(Name ="欠缴金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ArrearsAmount { get; set; }

       /// <summary>
       ///应收租金
       /// </summary>
       [Display(Name ="应收租金")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DueLeaseAmount { get; set; }

       /// <summary>
       ///实收租金
       /// </summary>
       [Display(Name ="实收租金")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ActualLeaseAmount { get; set; }

       /// <summary>
       ///应收管理费
       /// </summary>
       [Display(Name ="应收管理费")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DueManageAmout { get; set; }

       /// <summary>
       ///实收管理费
       /// </summary>
       [Display(Name ="实收管理费")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ActualManageAmount { get; set; }

       /// <summary>
       ///免租起始日期
       /// </summary>
       [Display(Name ="免租起始日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? RentFreeStartTime { get; set; }

       /// <summary>
       ///免租结束日期
       /// </summary>
       [Display(Name ="免租结束日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? RentFreeEndTime { get; set; }

       /// <summary>
       ///付款截止日期
       /// </summary>
       [Display(Name ="付款截止日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentDeadline { get; set; }

       /// <summary>
       ///付款日期
       /// </summary>
       [Display(Name ="付款日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentDate { get; set; }

       /// <summary>
       ///租赁付款期间起
       /// </summary>
       [Display(Name ="租赁付款期间起")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentStartDate { get; set; }

       /// <summary>
       ///租赁付款期间止
       /// </summary>
       [Display(Name ="租赁付款期间止")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentEndDate { get; set; }

       /// <summary>
       ///发票金额
       /// </summary>
       [Display(Name ="发票金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? InvoiceAmount { get; set; }

       /// <summary>
       ///发票日期
       /// </summary>
       [Display(Name ="发票日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? InvoiceDate { get; set; }

       /// <summary>
       ///发票号码
       /// </summary>
       [Display(Name ="发票号码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string InvoiceNo { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///公司
       /// </summary>
       [Display(Name ="公司")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? Company { get; set; }

       
    }
}