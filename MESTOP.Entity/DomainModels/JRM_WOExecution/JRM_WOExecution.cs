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
    [Entity(TableCnName = "工单生产执行汇总",TableName = "JRM_WOExecution",DBServer = "SysDbContext")]
    public partial class JRM_WOExecution:SysEntity
    {
        /// <summary>
       ///WOId
       /// </summary>
       [Key]
       [Display(Name ="WOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WOId { get; set; }

       /// <summary>
       ///JRM_WId
       /// </summary>
       [Display(Name ="JRM_WId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? JRM_WId { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MainWorkOrder { get; set; }

       /// <summary>
       ///金蝶工单号
       /// </summary>
       [Display(Name ="金蝶工单号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CSR_JD_FBILLNO { get; set; }

       /// <summary>
       ///产出品
       /// </summary>
       [Display(Name ="产出品")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///产出品短码
       /// </summary>
       [Display(Name ="产出品短码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///主工序流程编码
       /// </summary>
       [Display(Name ="主工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MainProcessFlowNo { get; set; }

       /// <summary>
       ///计划开始时间
       /// </summary>
       [Display(Name ="计划开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///计划结束时间
       /// </summary>
       [Display(Name ="计划结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///实际开始时间
       /// </summary>
       [Display(Name ="实际开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///实际结束时间
       /// </summary>
       [Display(Name ="实际结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string WOStatus { get; set; }

       /// <summary>
       ///父项
       /// </summary>
       [Display(Name ="父项")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///工单层级
       /// </summary>
       [Display(Name ="工单层级")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
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
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///已派工数量
       /// </summary>
       [Display(Name ="已派工数量")]
       [Column(TypeName="float")]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///未派工数量
       /// </summary>
       [Display(Name ="未派工数量")]
       [Column(TypeName="float")]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///已产出OK数量
       /// </summary>
       [Display(Name ="已产出OK数量")]
       [Column(TypeName="float")]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///已产出NG数量
       /// </summary>
       [Display(Name ="已产出NG数量")]
       [Column(TypeName="float")]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///未产出数量
       /// </summary>
       [Display(Name ="未产出数量")]
       [Column(TypeName="float")]
       public float? UnOutPutWIPQty { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///子工序流程编码
       /// </summary>
       [Display(Name ="子工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProcessFlowCode { get; set; }

       
    }
}