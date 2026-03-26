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
    [Entity(TableCnName = "入库单子项",TableName = "WOC_ProductionreceiptAdd",DBServer = "ServiceDbContext")]
    public partial class WOC_ProductionreceiptAdd:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid PID { get; set; }

       /// <summary>
       ///主工单
       /// </summary>
       [Display(Name ="主工单")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子工单
       /// </summary>
       [Display(Name ="子工单")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产品编码
       /// </summary>
       [Display(Name ="产品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///生产结束时间
       /// </summary>
       [Display(Name ="生产结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessStatus")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string ProcessStatus { get; set; }

       /// <summary>
       ///厚度
       /// </summary>
       [Display(Name ="厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///长度
       /// </summary>
       [Display(Name ="长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///宽度
       /// </summary>
       [Display(Name ="宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isSplitting")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string isSplitting { get; set; }

       /// <summary>
       ///是否产品
       /// </summary>
       [Display(Name ="是否产品")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProducts { get; set; }

       /// <summary>
       ///原批号
       /// </summary>
       [Display(Name ="原批号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOTNumber { get; set; }

       /// <summary>
       ///工单ID
       /// </summary>
       [Display(Name ="工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///ERPID
       /// </summary>
       [Display(Name ="ERPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ERpId { get; set; }

       /// <summary>
       ///入库单号
       /// </summary>
       [Display(Name ="入库单号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string RequestNo { get; set; }

       /// <summary>
       ///是否入库
       /// </summary>
       [Display(Name ="是否入库")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsInWarehouse { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MID")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? MID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Result")]
       [Column(TypeName="int")]
       public int? Result { get; set; }

       
    }
}