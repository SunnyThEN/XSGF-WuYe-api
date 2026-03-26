using Newtonsoft.Json;
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
    [Entity(TableCnName = "派工设备",TableName = "WOC_Dispatch_Equipment",DBServer = "SysDbContext")]
    public partial class WOC_Dispatch_Equipment:SysEntity
    {
        /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///设备点检方案编码
       /// </summary>
       [Display(Name ="设备点检方案编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionCode { get; set; }

       /// <summary>
       ///设备点检方案名称
       /// </summary>
       [Display(Name ="设备点检方案名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionName { get; set; }

       /// <summary>
       ///是否需要点检
       /// </summary>
       [Display(Name ="是否需要点检")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSpotCheck { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMNo { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

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
       ///子工序流程名称
       /// </summary>
       [Display(Name ="子工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///工序流程ID
       /// </summary>
       [Display(Name ="工序流程ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WorkFlow_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///工序节点ID
       /// </summary>
       [Display(Name ="工序节点ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? StepId { get; set; }

       /// <summary>
       ///点检完成
       /// </summary>
       [Display(Name ="点检完成")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Spotcheckcompleted { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///设备工作模式
       /// </summary>
       [Display(Name ="设备工作模式")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EqutStatus { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WOStatus { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
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
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       
    }
}
