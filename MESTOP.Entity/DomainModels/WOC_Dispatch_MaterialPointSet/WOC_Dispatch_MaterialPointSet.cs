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
    [Entity(TableCnName = "派工物流",TableName = "WOC_Dispatch_MaterialPointSet",DBServer = "SysDbContext")]
    public partial class WOC_Dispatch_MaterialPointSet:SysEntity
    {
        /// <summary>
       ///料点信号状态
       /// </summary>
       [Display(Name ="料点信号状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PortStatus { get; set; }

       /// <summary>
       ///物流类型
       /// </summary>
       [Display(Name ="物流类型")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string InterfaceName { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

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
       ///任务号
       /// </summary>
       [Display(Name ="任务号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string taskNo { get; set; }

       /// <summary>
       ///是否主料
       /// </summary>
       [Display(Name ="是否主料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isMainMaterial { get; set; }

       /// <summary>
       ///是否强制回库
       /// </summary>
       [Display(Name ="是否强制回库")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isForceReceipt { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string BOMNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MWOId { get; set; }

       /// <summary>
       ///领料单编码
       /// </summary>
       [Display(Name ="领料单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string shipmentReferCode { get; set; }

       /// <summary>
       ///物流模式
       /// </summary>
       [Display(Name ="物流模式")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? LogisticsType { get; set; }

       /// <summary>
       ///接口发送次数
       /// </summary>
       [Display(Name ="接口发送次数")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PostNum { get; set; }

       /// <summary>
       ///是否原材料
       /// </summary>
       [Display(Name ="是否原材料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isMaterial { get; set; }

       /// <summary>
       ///盛具编码
       /// </summary>
       [Display(Name ="盛具编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string containerCode { get; set; }

       /// <summary>
       ///盛具类型编码
       /// </summary>
       [Display(Name ="盛具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string containerTypeCode { get; set; }

       /// <summary>
       ///载具类型编码
       /// </summary>
       [Display(Name ="载具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string vehicleTypeCode { get; set; }

       /// <summary>
       ///任务物料名称
       /// </summary>
       [Display(Name ="任务物料名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string materialName { get; set; }

       /// <summary>
       ///任务物料编码
       /// </summary>
       [Display(Name ="任务物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string materialCode { get; set; }

       /// <summary>
       ///终点料点
       /// </summary>
       [Display(Name ="终点料点")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string toPort { get; set; }

       /// <summary>
       ///载具编码
       /// </summary>
       [Display(Name ="载具编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string vehicleCode { get; set; }

       /// <summary>
       ///起始料点
       /// </summary>
       [Display(Name ="起始料点")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string fromPort { get; set; }

       /// <summary>
       ///顺序
       /// </summary>
       [Display(Name ="顺序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? sequence { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? WOStatus { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WORequiredQty { get; set; }

       /// <summary>
       ///顺序分组
       /// </summary>
       [Display(Name ="顺序分组")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string sequenceGroup { get; set; }

       /// <summary>
       ///排序总数
       /// </summary>
       [Display(Name ="排序总数")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? sequenceCount { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///是否停止任务
       /// </summary>
       [Display(Name ="是否停止任务")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isStop { get; set; }

       /// <summary>
       ///产出品总数
       /// </summary>
       [Display(Name ="产出品总数")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isEmptyVehBack")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isEmptyVehBack { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
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
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       
    }
}