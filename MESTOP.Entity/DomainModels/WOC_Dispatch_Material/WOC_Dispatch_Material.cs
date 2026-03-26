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
    [Entity(TableCnName = "派工物料",TableName = "WOC_Dispatch_Material",DBServer = "SysDbContext")]
    public partial class WOC_Dispatch_Material:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///产出品BOM版本
       /// </summary>
       [Display(Name ="产出品BOM版本")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMNo { get; set; }

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
       ///创建者
       /// </summary>
       [Display(Name ="创建者")]
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
       ///修改者
       /// </summary>
       [Display(Name ="修改者")]
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
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///生产组织名称
       /// </summary>
       [Display(Name ="生产组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///生产组织代码
       /// </summary>
       [Display(Name ="生产组织代码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///物料简码
       /// </summary>
       [Display(Name ="物料简码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialShortNo { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料代码
       /// </summary>
       [Display(Name ="物料代码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///料点编码
       /// </summary>
       [Display(Name ="料点编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialPointCode { get; set; }

       /// <summary>
       ///料点名称
       /// </summary>
       [Display(Name ="料点名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialPointName { get; set; }

       /// <summary>
       ///是否原材料
       /// </summary>
       [Display(Name ="是否原材料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isMaterial { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MUnit { get; set; }

       /// <summary>
       ///物料版本
       /// </summary>
       [Display(Name ="物料版本")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialVersion { get; set; }

       /// <summary>
       ///MWOId
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MWOId { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeUOM")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TracingCodeUOM { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeQty")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? TracingCodeQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeQualityStatus")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? TracingCodeQualityStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StandardTime")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? StandardTime { get; set; }

       /// <summary>
       ///标准小时产能
       /// </summary>
       [Display(Name ="标准小时产能")]
       [JsonIgnore]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? StandardCapacity { get; set; }

       /// <summary>
       ///是否完成呼叫WMS物料出库
       /// </summary>
       [Display(Name ="是否完成呼叫WMS物料出库")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WMSisshipment { get; set; }

       /// <summary>
       ///任务号
       /// </summary>
       [Display(Name ="任务号")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string taskNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isEmpty")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isEmpty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isRemove")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isRemove { get; set; }

       /// <summary>
       ///盛具编码
       /// </summary>
       [Display(Name ="盛具编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ContainerCode { get; set; }

       /// <summary>
       ///载具编码
       /// </summary>
       [Display(Name ="载具编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string VehicleCode { get; set; }

       /// <summary>
       ///盛具类型编码
       /// </summary>
       [Display(Name ="盛具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ContainerTypeCode { get; set; }

       /// <summary>
       ///载具类型编码
       /// </summary>
       [Display(Name ="载具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string VehicleTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="endPort")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string endPort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isWriting")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isWriting { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isHandMaterial")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isHandMaterial { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isToNextPort")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isToNextPort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NextPortCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NextPortCode { get; set; }

       /// <summary>
       ///是否关重件
       /// </summary>
       [Display(Name ="是否关重件")]
       [Column(TypeName="int")]
       public int? isParts { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
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
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MQty")]
       [Column(TypeName="float")]
       public float? MQty { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ParentWorkOrderCode { get; set; }

       
    }
}
