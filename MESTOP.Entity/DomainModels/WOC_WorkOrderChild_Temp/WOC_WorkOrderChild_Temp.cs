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
    [Entity(TableCnName = "主工单派工子项TEMP",TableName = "WOC_WorkOrderChild_Temp",DBServer = "ServiceDbContext")]
    public partial class WOC_WorkOrderChild_Temp:ServiceEntity
    {
        /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品
       /// </summary>
       [Display(Name ="产出品")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductName { get; set; }

       /// <summary>
       ///车间
       /// </summary>
       [Display(Name ="车间")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopName { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="WorkShopCode")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NEWFLOT")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="BOMVersion")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgName { get; set; }

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
       [Display(Name ="WOStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WOStatus { get; set; }

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
       [Display(Name ="ProductShortCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderDesc")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string WorkOrderDesc { get; set; }

       /// <summary>
       ///子计划要求
       /// </summary>
       [Display(Name ="子计划要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkChildOrderDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string F_PASF_NEWPREFIX { get; set; }

       
    }
}