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
    [Entity(TableCnName = "物料追溯",TableName = "JRM_View_WorkReport_M",DBServer = "SysDbContext")]
    public partial class JRM_View_WorkReport_M:SysEntity
    {
        /// <summary>
       ///主物料编码
       /// </summary>
       [Display(Name ="主物料编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductCode { get; set; }

       /// <summary>
       ///子物料编码
       /// </summary>
       [Display(Name ="子物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string MaterialCode { get; set; }

       /// <summary>
       ///子物料名称
       /// </summary>
       [Display(Name ="子物料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string MaterialName { get; set; }

       /// <summary>
       ///主物料追溯码
       /// </summary>
       [Display(Name ="主物料追溯码")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       public string TracingCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WR_MId")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid JRM_WR_MId { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [Column(TypeName="float")]
       public float? MQty { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductName { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子物料追溯
       /// </summary>
       [Display(Name ="子物料追溯")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ChildTracingCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string WorkOrderCode { get; set; }

       
    }
}