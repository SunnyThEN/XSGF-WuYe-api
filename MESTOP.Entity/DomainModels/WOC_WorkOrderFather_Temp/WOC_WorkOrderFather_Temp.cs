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
    [Entity(TableCnName = "主计划派工",TableName = "WOC_WorkOrderFather_Temp",DetailTable =  new Type[] { typeof(WOC_WorkOrderChild_Temp),typeof(WOC_WorkOrderFatherWorkFlow_Temp),typeof(WOC_WorkOrderQC_Temp)},DetailTableCnName = "子项工单,子项工序,子项要求",DBServer = "ServiceDbContext")]
    public partial class WOC_WorkOrderFather_Temp:ServiceEntity
    {
        /// <summary>
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///计划号状态
       /// </summary>
       [Display(Name ="计划号状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WOStatus { get; set; }

       /// <summary>
       ///计划工艺流程
       /// </summary>
       [Display(Name ="计划工艺流程")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///生产组织名称
       /// </summary>
       [Display(Name ="生产组织名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
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
       ///车间编码
       /// </summary>
       [Display(Name ="车间编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///车间名称
       /// </summary>
       [Display(Name ="车间名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopName { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///生产组织编码
       /// </summary>
       [Display(Name ="生产组织编码")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Orderlevel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Orderlevel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///计划开始
       /// </summary>
       [Display(Name ="计划开始")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///计划结束
       /// </summary>
       [Display(Name ="计划结束")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductShortCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///计划工艺流程
       /// </summary>
       [Display(Name ="计划工艺流程")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///计划号要求
       /// </summary>
       [Display(Name ="计划号要求")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkOrderDesc { get; set; }

       [Display(Name ="子项工单")]
       [ForeignKey("FID")]
       public List<WOC_WorkOrderChild_Temp> WOC_WorkOrderChild_Temp { get; set; }


       [Display(Name ="子项工序")]
       [ForeignKey("FID")]
       public List<WOC_WorkOrderFatherWorkFlow_Temp> WOC_WorkOrderFatherWorkFlow_Temp { get; set; }


       [Display(Name ="子项要求")]
       [ForeignKey("FID")]
       public List<WOC_WorkOrderQC_Temp> WOC_WorkOrderQC_Temp { get; set; }


       
    }
}