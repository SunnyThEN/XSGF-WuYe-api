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
    [Entity(TableCnName = "设备台账",TableName = "EMS_Device",DBServer = "SysDbContext")]
    public partial class EMS_Device:SysEntity
    {
        /// <summary>
       ///设备主键
       /// </summary>
       [Key]
       [Display(Name ="设备主键")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid DeviceId { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DeviceName { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DeviceCode { get; set; }

       /// <summary>
       ///设备品牌
       /// </summary>
       [Display(Name ="设备品牌")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeviceBrand { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ModelType { get; set; }

       /// <summary>
       ///所属车间
       /// </summary>
       [Display(Name ="所属车间")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string WorkShopId { get; set; }

       /// <summary>
       ///设备分类
       /// </summary>
       [Display(Name ="设备分类")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? ParentId { get; set; }

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
       ///修改人编号
       /// </summary>
       [Display(Name ="修改人编号")]
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
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///设备类型
       /// </summary>
       [Display(Name ="设备类型")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeviceType { get; set; }

       /// <summary>
       ///设备状态
       /// </summary>
       [Display(Name ="设备状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? DeviceStatus { get; set; }

       /// <summary>
       ///设备描述
       /// </summary>
       [Display(Name ="设备描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string DeviceRemark { get; set; }

       /// <summary>
       ///设备图片
       /// </summary>
       [Display(Name ="设备图片")]
       [MaxLength(10)]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string DevicePic { get; set; }

       /// <summary>
       ///生产日期
       /// </summary>
       [Display(Name ="生产日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ManufactureDate { get; set; }

       /// <summary>
       ///使用年限
       /// </summary>
       [Display(Name ="使用年限")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ServiceLife { get; set; }

       /// <summary>
       ///生产厂商
       /// </summary>
       [Display(Name ="生产厂商")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeviceManufacturer { get; set; }

       /// <summary>
       ///投产日期
       /// </summary>
       [Display(Name ="投产日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ProductionDate { get; set; }

       /// <summary>
       ///所属部门
       /// </summary>
       [Display(Name ="所属部门")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DeptId { get; set; }

       /// <summary>
       ///负责人
       /// </summary>
       [Display(Name ="负责人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Head { get; set; }

       /// <summary>
       ///负责人电话
       /// </summary>
       [Display(Name ="负责人电话")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string HeadPhNum { get; set; }

       /// <summary>
       ///维护人
       /// </summary>
       [Display(Name ="维护人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Maintainers { get; set; }

       /// <summary>
       ///维护日期
       /// </summary>
       [Display(Name ="维护日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? MaintenanceDate { get; set; }

       /// <summary>
       ///随机附件
       /// </summary>
       [Display(Name ="随机附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Annex { get; set; }

       /// <summary>
       ///资产原值
       /// </summary>
       [Display(Name ="资产原值")]
       [Column(TypeName="float")]
       public float? OriginalValue { get; set; }

       /// <summary>
       ///资产净值
       /// </summary>
       [Display(Name ="资产净值")]
       [Column(TypeName="float")]
       public float? NetValue { get; set; }

       /// <summary>
       ///单位编号
       /// </summary>
       [Display(Name ="单位编号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string UnitNum { get; set; }

       /// <summary>
       ///单位名称
       /// </summary>
       [Display(Name ="单位名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string UnitName { get; set; }

       
    }
}