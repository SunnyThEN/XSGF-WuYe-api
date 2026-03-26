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
    [Entity(TableCnName = "商户明细",TableName = "RMS_OwnerDetails",DetailTable =  new Type[] { typeof(RMS_PaymentDetails)},DetailTableCnName = "付款明细",DBServer = "SysDbContext")]
    public partial class RMS_OwnerDetails:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="OwnerId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int OwnerId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PropertyId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PropertyId { get; set; }

       /// <summary>
       ///商户名称
       /// </summary>
       [Display(Name ="商户名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string OwnerName { get; set; }

       /// <summary>
       ///付款日期
       /// </summary>
       [Display(Name ="付款日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? PaymentDate { get; set; }

       /// <summary>
       ///租赁起始日期
       /// </summary>
       [Display(Name ="租赁起始日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? RentalStartTime { get; set; }

       /// <summary>
       ///租赁结束日期
       /// </summary>
       [Display(Name ="租赁结束日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? RentalEndTime { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///租赁期
       /// </summary>
       [Display(Name ="租赁期")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string RentalTime { get; set; }

       /// <summary>
       ///月租金
       /// </summary>
       [Display(Name ="月租金")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MonthlyRent { get; set; }

       /// <summary>
       ///月管理费
       /// </summary>
       [Display(Name ="月管理费")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MonthlyManageFee { get; set; }

       /// <summary>
       ///月计
       /// </summary>
       [Display(Name ="月计")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MonthlyTotalFee { get; set; }

       /// <summary>
       ///总租金
       /// </summary>
       [Display(Name ="总租金")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Rent { get; set; }

       /// <summary>
       ///总管理费
       /// </summary>
       [Display(Name ="总管理费")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ManageFee { get; set; }

       /// <summary>
       ///总计
       /// </summary>
       [Display(Name ="总计")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TotalFee { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
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
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///承租方识别号
       /// </summary>
       [Display(Name ="承租方识别号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TenantId { get; set; }

       /// <summary>
       ///合同编号
       /// </summary>
       [Display(Name ="合同编号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ContractNumber { get; set; }

       /// <summary>
       ///公司
       /// </summary>
       [Display(Name ="公司")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? Company { get; set; }

       [Display(Name ="付款明细")]
       [ForeignKey("OwnerId")]
       public List<RMS_PaymentDetails> RMS_PaymentDetails { get; set; }


       
    }
}