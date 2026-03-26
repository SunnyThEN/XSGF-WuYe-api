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
    [Entity(TableCnName = "异常处理列表",TableName = "QCM_AbnormalList",DetailTable =  new Type[] { typeof(QCM_AbnormalListItem)},DetailTableCnName = "异常处理明细",DBServer = "ServiceDbContext")]
    public partial class QCM_AbnormalList:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="AbnId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid AbnId { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序要求
       /// </summary>
       [Display(Name ="工序要求")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessRequest { get; set; }

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
       ///产品规格
       /// </summary>
       [Display(Name ="产品规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProductDesc { get; set; }

       /// <summary>
       ///长度
       /// </summary>
       [Display(Name ="长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///厚度
       /// </summary>
       [Display(Name ="厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///宽度
       /// </summary>
       [Display(Name ="宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///检验日期
       /// </summary>
       [Display(Name ="检验日期")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? CheckDate { get; set; }

       /// <summary>
       ///处理结果
       /// </summary>
       [Display(Name ="处理结果")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Result { get; set; }

       /// <summary>
       ///不良现象
       /// </summary>
       [Display(Name ="不良现象")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string DefectName { get; set; }

       /// <summary>
       ///质检备注
       /// </summary>
       [Display(Name ="质检备注")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? DealResult { get; set; }

       /// <summary>
       ///是否已处理
       /// </summary>
       [Display(Name ="是否已处理")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDeal { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
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
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? PID { get; set; }

       /// <summary>
       ///审核时间
       /// </summary>
       [Display(Name ="审核时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? AuditDate { get; set; }

       /// <summary>
       ///审核人
       /// </summary>
       [Display(Name ="审核人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Auditor { get; set; }

       /// <summary>
       ///审核状态
       /// </summary>
       [Display(Name ="审核状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? AuditStatus { get; set; }

       /// <summary>
       ///材质牌号
       /// </summary>
       [Display(Name ="材质牌号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialGrade { get; set; }

       /// <summary>
       ///是否成品
       /// </summary>
       [Display(Name ="是否成品")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProducts { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OtherProductsName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OtherProductsName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OtherProductsCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OtherProductsCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OtherProductsDesc")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OtherProductsDesc { get; set; }

       /// <summary>
       ///协议品质量等级
       /// </summary>
       [Display(Name ="协议品质量等级")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string F_PASF_QUALEVEL { get; set; }

       /// <summary>
       ///协议品质量描述
       /// </summary>
       [Display(Name ="协议品质量描述")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string F_PASF_QUADES { get; set; }

       [Display(Name ="异常处理明细")]
       [ForeignKey("AbnId")]
       public List<QCM_AbnormalListItem> QCM_AbnormalListItem { get; set; }


       
    }
}