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
    [Entity(TableCnName = "派工工序Temp",TableName = "WOC_DispatchCard_WorkFlow_Temp",DBServer = "ServiceDbContext")]
    public partial class WOC_DispatchCard_WorkFlow_Temp:ServiceEntity
    {
        /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

       /// <summary>
       ///工单ID
       /// </summary>
       [Display(Name ="工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessStepId")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Key]
       [Display(Name ="工序ID")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid PID { get; set; }

       /// <summary>
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string ProductName { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       public float? WORequiredQty { get; set; }

       /// <summary>
       ///计划开始时间
       /// </summary>
       [Display(Name ="计划开始时间")]
       [Column(TypeName="datetime")]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///计划结束时间
       /// </summary>
       [Display(Name ="计划结束时间")]
       [Column(TypeName="datetime")]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int WOStatus { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [Column(TypeName="int")]
       public int? OrgCode { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string OrgName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Orderlevel { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string BOMVersion { get; set; }

       /// <summary>
       ///卷号ID
       /// </summary>
       [Display(Name ="卷号ID")]
       [Column(TypeName="int")]
       public int? FLOT { get; set; }

       /// <summary>
       ///工序状态初值
       /// </summary>
       [Display(Name ="工序状态初值")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///车间名称
       /// </summary>
       [Display(Name ="车间名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkShopName { get; set; }

       /// <summary>
       ///车间ID
       /// </summary>
       [Display(Name ="车间ID")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///工序要求
       /// </summary>
       [Display(Name ="工序要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessRequest { get; set; }

       /// <summary>
       ///工单要求
       /// </summary>
       [Display(Name ="工单要求")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkOrderDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NEWPREFIX { get; set; }

       /// <summary>
       ///机组编码
       /// </summary>
       [Display(Name ="机组编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationName { get; set; }

       
    }
}