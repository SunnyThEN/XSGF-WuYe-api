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
    [Entity(TableCnName = " 工单查询",TableName = "Search_WOC_WorkOrder",DBServer = "SysDbContext")]
    public partial class Search_WOC_WorkOrder:SysEntity
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
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [Column(TypeName="int")]
       public int? Orderlevel { get; set; }

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
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMNo { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

       /// <summary>
       ///生产组织编码
       /// </summary>
       [Display(Name ="生产组织编码")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       public string OrgCode { get; set; }

       /// <summary>
       ///已产出OK数量
       /// </summary>
       [Display(Name ="已产出OK数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///已产出NG数量
       /// </summary>
       [Display(Name ="已产出NG数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///未产出数量
       /// </summary>
       [Display(Name ="未产出数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UnOutPutWIPQty { get; set; }

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
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///上级工单ID
       /// </summary>
       [Display(Name ="上级工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

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
       ///已派工数量
       /// </summary>
       [Display(Name ="已派工数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DispatchedQty { get; set; }

       /// <summary>
       ///未派工数量
       /// </summary>
       [Display(Name ="未派工数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UndispatchedQty { get; set; }

       /// <summary>
       ///生产组织名称
       /// </summary>
       [Display(Name ="生产组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string OrgName { get; set; }

       /// <summary>
       ///生产组织类型
       /// </summary>
       [Display(Name ="生产组织类型")]
       [Column(TypeName="int")]
       public int? OrgType { get; set; }

       /// <summary>
       ///日期
       /// </summary>
       [Display(Name ="日期")]
       [MaxLength(4000)]
       [Column(TypeName="nvarchar(4000)")]
       public string getdate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NG2OKQty")]
       [JsonIgnore]
       [Column(TypeName="float")]
       public float? NG2OKQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="poststatus")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? poststatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="taskNo")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       public string taskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="postNumber")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? postNumber { get; set; }

       /// <summary>
       ///领料单编码
       /// </summary>
       [Display(Name ="领料单编码")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///领料单状态
       /// </summary>
       [Display(Name ="领料单状态")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? shipmentReferStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductName { get; set; }

       /// <summary>
       ///产出品短码
       /// </summary>
       [Display(Name ="产出品短码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///实际开始时间
       /// </summary>
       [Display(Name ="实际开始时间")]
       [Column(TypeName="datetime")]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///实际结束时间
       /// </summary>
       [Display(Name ="实际结束时间")]
       [Column(TypeName="datetime")]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string ProcessFlowName { get; set; }

       
    }
}
