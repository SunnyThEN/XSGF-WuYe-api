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
    [Entity(TableCnName = "电费明细",TableName = "RMS_ElectricityBillDetails",DBServer = "SysDbContext")]
    public partial class RMS_ElectricityBillDetails:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OwnerId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int OwnerId { get; set; }

       /// <summary>
       ///业主名称
       /// </summary>
       [Display(Name ="业主名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string OwnerName { get; set; }

       /// <summary>
       ///电费单价
       /// </summary>
       [Display(Name ="电费单价")]
       [DisplayFormat(DataFormatString="18,4")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ElectricityUnitPrice { get; set; }

       /// <summary>
       ///充电度数
       /// </summary>
       [Display(Name ="充电度数")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ChargeDegree { get; set; }

       /// <summary>
       ///实付金额
       /// </summary>
       [Display(Name ="实付金额")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? ActualAmount { get; set; }

       /// <summary>
       ///付款日期
       /// </summary>
       [Display(Name ="付款日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentDate { get; set; }

       /// <summary>
       ///开票金额
       /// </summary>
       [Display(Name ="开票金额")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? InvoiceAmount { get; set; }

       /// <summary>
       ///开票日期
       /// </summary>
       [Display(Name ="开票日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? InvoiceDate { get; set; }

       /// <summary>
       ///发票号码
       /// </summary>
       [Display(Name ="发票号码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
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
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       
    }
}