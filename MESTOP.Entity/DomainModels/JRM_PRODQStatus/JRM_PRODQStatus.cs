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
    [Entity(TableCnName = "产出品质量状态汇总",TableName = "JRM_PRODQStatus",DBServer = "SysDbContext")]
    public partial class JRM_PRODQStatus:SysEntity
    {
        /// <summary>
       ///CWOId
       /// </summary>
       [Key]
       [Display(Name ="CWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int QId { get; set; }

       /// <summary>
       ///JRM_QId
       /// </summary>
       [Display(Name ="JRM_QId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? JRM_QId { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///质量状态
       /// </summary>
       [Display(Name ="质量状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

       /// <summary>
       ///单位(主)
       /// </summary>
       [Display(Name ="单位(主)")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string AUnit { get; set; }

       /// <summary>
       ///数量(主)
       /// </summary>
       [Display(Name ="数量(主)")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? AQty { get; set; }

       /// <summary>
       ///单位(辅)
       /// </summary>
       [Display(Name ="单位(辅)")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BUnit { get; set; }

       /// <summary>
       ///数量(辅)
       /// </summary>
       [Display(Name ="数量(辅)")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? BQty { get; set; }

       /// <summary>
       ///容器编码
       /// </summary>
       [Display(Name ="容器编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ContainerCode { get; set; }

       /// <summary>
       ///载具编码
       /// </summary>
       [Display(Name ="载具编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string VehicleCode { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WOId")]
       [Column(TypeName="int")]
       public int? WOId { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       
    }
}