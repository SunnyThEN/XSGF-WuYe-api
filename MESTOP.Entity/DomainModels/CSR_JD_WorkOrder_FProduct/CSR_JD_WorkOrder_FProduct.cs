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
    [Entity(TableCnName = "工单副产品",TableName = "CSR_JD_WorkOrder_FProduct",DBServer = "TestDbContext")]
    public partial class CSR_JD_WorkOrder_FProduct:TestEntity
    {
        /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string ProductName { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///批号
       /// </summary>
       [Display(Name ="批号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///分卷数量
       /// </summary>
       [Display(Name ="分卷数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int F_PASF_VOLUME { get; set; }

       /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string FSPECIFICATION { get; set; }

       /// <summary>
       ///厚度
       /// </summary>
       [Display(Name ="厚度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutThicknessUnit { get; set; }

       /// <summary>
       ///宽度
       /// </summary>
       [Display(Name ="宽度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWidthUnit { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WORequiredQty { get; set; }

       /// <summary>
       ///主计划号
       /// </summary>
       [Display(Name ="主计划号")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///子计划号
       /// </summary>
       [Display(Name ="子计划号")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///FID
       /// </summary>
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///副产品
       /// </summary>
       [Display(Name ="副产品")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FPRODUCTTYPE { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///长度
       /// </summary>
       [Display(Name ="长度")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutLengthUnit { get; set; }

       /// <summary>
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OutWeightUnit { get; set; }

       /// <summary>
       ///班组
       /// </summary>
       [Display(Name ="班组")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string TeamGroup { get; set; }

       /// <summary>
       ///参与人
       /// </summary>
       [Display(Name ="参与人")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string Participants { get; set; }

       /// <summary>
       ///判定
       /// </summary>
       [Display(Name ="判定")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Result { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MWOId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int MWOId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProductDesc")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string ProductDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NEWPREFIX { get; set; }

       
    }
}