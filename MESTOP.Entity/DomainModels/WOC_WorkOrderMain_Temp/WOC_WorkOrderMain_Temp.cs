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
    [Entity(TableCnName = "未派子工单Temp",TableName = "WOC_WorkOrderMain_Temp",DetailTable =  new Type[] { typeof(WOC_DispatchCard_WorkFlow_Temp)},DetailTableCnName = "派工工序",DBServer = "ServiceDbContext")]
    public partial class WOC_WorkOrderMain_Temp:ServiceEntity
    {
        /// <summary>
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///计划工艺流程
       /// </summary>
       [Display(Name ="计划工艺流程")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WORequiredQty { get; set; }

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
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WOStatus { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///车间名称
       /// </summary>
       [Display(Name ="车间名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopName { get; set; }

       /// <summary>
       ///生产组织
       /// </summary>
       [Display(Name ="生产组织")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgCode { get; set; }

       /// <summary>
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Orderlevel { get; set; }

       /// <summary>
       ///产出品短码
       /// </summary>
       [Display(Name ="产出品短码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///卷号ID
       /// </summary>
       [Display(Name ="卷号ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///车间编码
       /// </summary>
       [Display(Name ="车间编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///工单要求
       /// </summary>
       [Display(Name ="工单要求")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
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
       ///子计划要求
       /// </summary>
       [Display(Name ="子计划要求")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkChildOrderDesc { get; set; }

       [Display(Name ="派工工序")]
       [ForeignKey("MWOId")]
       public List<WOC_DispatchCard_WorkFlow_Temp> WOC_DispatchCard_WorkFlow_Temp { get; set; }


       
    }
}
