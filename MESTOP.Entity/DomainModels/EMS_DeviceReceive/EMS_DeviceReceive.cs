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
    [Entity(TableCnName = "设备领用",TableName = "EMS_DeviceReceive",DetailTable =  new Type[] { typeof(EMS_DeviceReceiveList)},DetailTableCnName = "设备领用明细",DBServer = "SysDbContext")]
    public partial class EMS_DeviceReceive:SysEntity
    {
        /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人编号
       /// </summary>
       [Display(Name ="创建人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人编号
       /// </summary>
       [Display(Name ="修改人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///领用日期
       /// </summary>
       [Display(Name ="领用日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? ReceiveDate { get; set; }

       /// <summary>
       ///领用主键
       /// </summary>
       [Key]
       [Display(Name ="领用主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int DeviceReceiveId { get; set; }

       /// <summary>
       ///领用编号
       /// </summary>
       [Display(Name ="领用编号")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DeviceReceiveCode { get; set; }

       [Display(Name ="设备领用明细")]
       [ForeignKey("DeviceReceiveId")]
       public List<EMS_DeviceReceiveList> EMS_DeviceReceiveList { get; set; }


       
    }
}