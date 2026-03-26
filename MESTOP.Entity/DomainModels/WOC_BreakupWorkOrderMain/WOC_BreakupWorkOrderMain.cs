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
    [Entity(TableCnName = "拆分工单主表",TableName = "WOC_BreakupWorkOrderMain",DetailTable =  new Type[] { typeof(WOC_BreakupWorkOrderChild)},DetailTableCnName = "WOC_BreakupWorkOrderChild",DBServer = "SysDbContext")]
    public partial class WOC_BreakupWorkOrderMain:SysEntity
    {
        /// <summary>
       ///MWOId
       /// </summary>
       [Key]
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

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
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///按结束日期逆排工单
       /// </summary>
       [Display(Name ="按结束日期逆排工单")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int isDesc { get; set; }

       /// <summary>
       ///工单排程
       /// </summary>
       [Display(Name ="工单排程")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string isAsc { get; set; }

       /// <summary>
       ///工厂日历方案
       /// </summary>
       [Display(Name ="工厂日历方案")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCM_ShiftId { get; set; }

       /// <summary>
       ///频率间隔
       /// </summary>
       [Display(Name ="频率间隔")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Interval { get; set; }

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

       [Display(Name ="WOC_BreakupWorkOrderChild")]
       [ForeignKey("MWOId")]
       public List<WOC_BreakupWorkOrderChild> WOC_BreakupWorkOrderChild { get; set; }


       
    }
}
