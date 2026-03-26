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
    [Entity(TableCnName = "房产明细",TableName = "RMS_PropertyDetails",DetailTable =  new Type[] { typeof(RMS_OwnerDetails)},DetailTableCnName = "业主信息",DBServer = "SysDbContext")]
    public partial class RMS_PropertyDetails:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PropertyId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PropertyId { get; set; }

       /// <summary>
       ///承租方名称
       /// </summary>
       [Display(Name ="承租方名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TenantName { get; set; }

       /// <summary>
       ///承租方识别号
       /// </summary>
       [Display(Name ="承租方识别号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TenantId { get; set; }

       /// <summary>
       ///楼幢
       /// </summary>
       [Display(Name ="楼幢")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Buildings { get; set; }

       /// <summary>
       ///楼层
       /// </summary>
       [Display(Name ="楼层")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Floor { get; set; }

       /// <summary>
       ///面积
       /// </summary>
       [Display(Name ="面积")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Area { get; set; }

       /// <summary>
       ///室号
       /// </summary>
       [Display(Name ="室号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string RoomNumber { get; set; }

       /// <summary>
       ///是否闲置
       /// </summary>
       [Display(Name ="是否闲置")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Isidle { get; set; }

       /// <summary>
       ///合同编号
       /// </summary>
       [Display(Name ="合同编号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ContractNumber { get; set; }

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
       ///租赁期
       /// </summary>
       [Display(Name ="租赁期")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string RentalTime { get; set; }

       /// <summary>
       ///押金
       /// </summary>
       [Display(Name ="押金")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Deposit { get; set; }

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
       ///房产证编号
       /// </summary>
       [Display(Name ="房产证编号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TitleDeedNumber { get; set; }

       /// <summary>
       ///公司
       /// </summary>
       [Display(Name ="公司")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? Company { get; set; }

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

       [Display(Name ="业主信息")]
       [ForeignKey("PropertyId")]
       public List<RMS_OwnerDetails> RMS_OwnerDetails { get; set; }


       
    }
}