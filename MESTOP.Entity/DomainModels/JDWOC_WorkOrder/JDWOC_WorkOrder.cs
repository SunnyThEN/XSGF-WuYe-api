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
    [Entity(TableCnName = "金蝶工单同步",TableName = "JDWOC_WorkOrder",DBServer = "ServiceDbContext")]
    public partial class JDWOC_WorkOrder:ServiceEntity
    {
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
       [Display(Name ="ParentWorkOrderCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductName")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductShortCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WORequiredQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DispatchedQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UndispatchedQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutPutOKWIPQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OutPutNGWIPQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UnOutPutWIPQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UnOutPutWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PlanStartTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PlanEndTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WOStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WOStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOrderFlag")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FOrderFlag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealStartTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealEndTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EquipIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PeopleIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PeopleIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialIsOk")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaterialIsOk { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgName")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string OrgCode { get; set; }

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
       [Display(Name ="NG2OKQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? NG2OKQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="poststatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? poststatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="postNumber")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? postNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentReferStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? shipmentReferStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskNo")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string taskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Order_Cancellation")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Order_Cancellation { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Order_Distribution")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Order_Distribution { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskStatus")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string taskStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrderWMsPost")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrderWMsPost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmentWMSsPost")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentWMSsPost { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrdertaskNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrdertaskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="shipmenttaskNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmenttaskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BOMVersion")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MainProcessFlowCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MainProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="BillTypeName")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BillTypeName { get; set; }

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
       [Display(Name ="WorkShopName")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string WorkShopName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkShopCode")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderType")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WorkOrderType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="orderNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string orderNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="batchNumber")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string batchNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

       
    }
}