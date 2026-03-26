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
    [Entity(TableCnName = "生产领料申请单",TableName = "JRM_MaterialReq",DBServer = "SysDbContext")]
    public partial class JRM_MaterialReq:SysEntity
    {
        /// <summary>
       ///PId
       /// </summary>
       [Key]
       [Display(Name ="PId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PId { get; set; }

       /// <summary>
       ///JRM_PId
       /// </summary>
       [Display(Name ="JRM_PId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? JRM_PId { get; set; }

       /// <summary>
       ///领料单编码
       /// </summary>
       [Display(Name ="领料单编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PickMtrlCode { get; set; }

       /// <summary>
       ///领料单状态
       /// </summary>
       [Display(Name ="领料单状态")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PickMtrlStatus { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///质量状态
       /// </summary>
       [Display(Name ="质量状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? QualityStatus { get; set; }

       /// <summary>
       ///单位(主计量)
       /// </summary>
       [Display(Name ="单位(主计量)")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AUnit { get; set; }

       /// <summary>
       ///数量(主计量)
       /// </summary>
       [Display(Name ="数量(主计量)")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? AQty { get; set; }

       /// <summary>
       ///单位(辅助计量)
       /// </summary>
       [Display(Name ="单位(辅助计量)")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BUnit { get; set; }

       /// <summary>
       ///数量(辅助计量)
       /// </summary>
       [Display(Name ="数量(辅助计量)")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? BQty { get; set; }

       /// <summary>
       ///容器编码
       /// </summary>
       [Display(Name ="容器编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ContainerCode { get; set; }

       /// <summary>
       ///载具编码
       /// </summary>
       [Display(Name ="载具编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string VehicleCode { get; set; }

       /// <summary>
       ///仓库类型
       /// </summary>
       [Display(Name ="仓库类型")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WarehouseTypeCode { get; set; }

       /// <summary>
       ///仓库类型名称
       /// </summary>
       [Display(Name ="仓库类型名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WarehouseTypeName { get; set; }

       /// <summary>
       ///仓库编码
       /// </summary>
       [Display(Name ="仓库编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WarehouseCode { get; set; }

       /// <summary>
       ///仓库名称
       /// </summary>
       [Display(Name ="仓库名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WarehouseName { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
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
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MetarialDesc")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string MetarialDesc { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string WorkOrderCode { get; set; }

       
    }
}