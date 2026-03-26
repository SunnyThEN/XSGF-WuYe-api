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
    [Entity(TableCnName = "用料清单明细",TableName = "CSR_JD_PBomBillViewChild",DBServer = "ServiceDbContext")]
    public partial class CSR_JD_PBomBillViewChild:ServiceEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///生产用料ID
       /// </summary>
       [Display(Name ="生产用料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FID { get; set; }

       /// <summary>
       ///原卷号
       /// </summary>
       [Display(Name ="原卷号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///子项类型
       /// </summary>
       [Display(Name ="子项类型")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMATERIALTYPE { get; set; }

       /// <summary>
       ///需求日期	
       /// </summary>
       [Display(Name ="需求日期	")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FNEEDDATE { get; set; }

       /// <summary>
       ///计量单位
       /// </summary>
       [Display(Name ="计量单位")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///需求数量	
       /// </summary>
       [Display(Name ="需求数量	")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FNEEDQTY { get; set; }

       /// <summary>
       ///应发数量
       /// </summary>
       [Display(Name ="应发数量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FMUSTQTY { get; set; }

       /// <summary>
       ///标准数量
       /// </summary>
       [Display(Name ="标准数量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float FSTDQTY { get; set; }

       /// <summary>
       ///领取数量
       /// </summary>
       [Display(Name ="领取数量")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       public float? ReceiveQty { get; set; }

       /// <summary>
       ///序号
       /// </summary>
       [Display(Name ="序号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FSEQ { get; set; }

       /// <summary>
       ///子项物料编码	
       /// </summary>
       [Display(Name ="子项物料编码	")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///工单类型
       /// </summary>
       [Display(Name ="工单类型")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string FMOTYPE { get; set; }

       /// <summary>
       ///工单ID
       /// </summary>
       [Display(Name ="工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOID { get; set; }

       /// <summary>
       ///单位ID
       /// </summary>
       [Display(Name ="单位ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUNITID { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(87)]
       [Column(TypeName="nvarchar(87)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///ERP工单ID
       /// </summary>
       [Display(Name ="ERP工单ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMOENTRYID { get; set; }

       /// <summary>
       ///原卷ID
       /// </summary>
       [Display(Name ="原卷ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       
    }
}