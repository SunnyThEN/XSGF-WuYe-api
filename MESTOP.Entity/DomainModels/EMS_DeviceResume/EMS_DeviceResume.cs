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
    [Entity(TableCnName = "设备履历",TableName = "EMS_DeviceResume",DBServer = "SysDbContext")]
    public partial class EMS_DeviceResume:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ResumeId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ResumeId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DevCatalogId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? DevCatalogId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DeviceId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? DeviceId { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeviceCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeviceName { get; set; }

       /// <summary>
       ///业务类型
       /// </summary>
       [Display(Name ="业务类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OperationType { get; set; }

       /// <summary>
       ///业务内容
       /// </summary>
       [Display(Name ="业务内容")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string OperationContent { get; set; }

       /// <summary>
       ///业务开始时间
       /// </summary>
       [Display(Name ="业务开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OperationStartTime { get; set; }

       /// <summary>
       ///业务结束时间
       /// </summary>
       [Display(Name ="业务结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OperationEndTime { get; set; }

       /// <summary>
       ///业务申请人
       /// </summary>
       [Display(Name ="业务申请人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string OperationApplicant { get; set; }

       /// <summary>
       ///业务执行人
       /// </summary>
       [Display(Name ="业务执行人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string OperationExecutor { get; set; }

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

       
    }
}