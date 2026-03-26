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
    [Entity(TableCnName = "报工选择（DF）",TableName = "JRM_DF_JobReport",DBServer = "SysDbContext")]
    public partial class JRM_DF_JobReport:SysEntity
    {
        /// <summary>
       ///BOMNo
       /// </summary>
       [Display(Name ="BOMNo")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string BOMNo { get; set; }

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
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///工序节点ID
       /// </summary>
       [Display(Name ="工序节点ID")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string StepId { get; set; }

       /// <summary>
       ///工序节点名称
       /// </summary>
       [Display(Name ="工序节点名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string StepName { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WorkFlow_Id { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
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
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///物料版本规格
       /// </summary>
       [Display(Name ="物料版本规格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialVersion { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MUnit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///操作员编码
       /// </summary>
       [Display(Name ="操作员编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PeopleCode { get; set; }

       /// <summary>
       ///操作员名称
       /// </summary>
       [Display(Name ="操作员名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PeopleName { get; set; }

       /// <summary>
       ///OK品数量
       /// </summary>
       [Display(Name ="OK品数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OKQty { get; set; }

       /// <summary>
       ///NG品数量
       /// </summary>
       [Display(Name ="NG品数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? NGQty { get; set; }

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
       ///外包装码
       /// </summary>
       [Display(Name ="外包装码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string OutBoxCode { get; set; }

       /// <summary>
       ///外包装码数量
       /// </summary>
       [Display(Name ="外包装码数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutBoxCodeNum { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NGCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NGCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OKCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OKCode { get; set; }

       /// <summary>
       ///NG策略选择
       /// </summary>
       [Display(Name ="NG策略选择")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string NGDescSelect { get; set; }

       /// <summary>
       ///OK品产出数量
       /// </summary>
       [Display(Name ="OK品产出数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutOKWIPQty { get; set; }

       /// <summary>
       ///NG品产出数量
       /// </summary>
       [Display(Name ="NG品产出数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutPutNGWIPQty { get; set; }

       /// <summary>
       ///未完成品数
       /// </summary>
       [Display(Name ="未完成品数")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? UnOutPutWIPQty { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WORequiredQty { get; set; }

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
       [Display(Name ="isProdTrace")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProdTrace { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDefectiveTrace")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDefectiveTrace { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isPackTrace")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isPackTrace { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductName")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductShortCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessFlowCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkStationCode")]
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
       ///
       /// </summary>
       [Display(Name ="TracingCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string TracingCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeUOM")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string TracingCodeUOM { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeQty")]
       [Column(TypeName="float")]
       public float? TracingCodeQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeInputRecordDate")]
       [Column(TypeName="datetime")]
       public DateTime? TracingCodeInputRecordDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TracingCodeOutputReordDate")]
       [Column(TypeName="datetime")]
       public DateTime? TracingCodeOutputReordDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealStartTime")]
       [Column(TypeName="datetime")]
       public DateTime? RealStartTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RealEndTime")]
       [Column(TypeName="datetime")]
       public DateTime? RealEndTime { get; set; }

       
    }
}