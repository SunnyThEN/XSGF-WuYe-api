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
    [Entity(TableCnName = "工单管理",TableName = "CSR_JD_WorkOrder",DBServer = "TestDbContext")]
    public partial class CSR_JD_WorkOrder:TestEntity
    {
        /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALID { get; set; }

       /// <summary>
       ///需求数量
       /// </summary>
       [Display(Name ="需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WORequiredQty { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///计划结束时间
       /// </summary>
       [Display(Name ="计划结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///计划开始时间
       /// </summary>
       [Display(Name ="计划开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///工单级别
       /// </summary>
       [Display(Name ="工单级别")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Orderlevel { get; set; }

       /// <summary>
       ///工单类型名称
       /// </summary>
       [Display(Name ="工单类型名称")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string BillTypeName { get; set; }

       /// <summary>
       ///单据状态
       /// </summary>
       [Display(Name ="单据状态")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FDOCUMENTSTATUS { get; set; }

       /// <summary>
       ///卷号ID
       /// </summary>
       [Display(Name ="卷号ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FLOT { get; set; }

       /// <summary>
       ///产品类型
       /// </summary>
       [Display(Name ="产品类型")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FPRODUCTTYPE { get; set; }

       /// <summary>
       ///入库上限
       /// </summary>
       [Display(Name ="入库上限")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINLIMITH { get; set; }

       /// <summary>
       ///入库下限
       /// </summary>
       [Display(Name ="入库下限")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSTOCKINLIMITL { get; set; }

       /// <summary>
       ///需求单据(销售订单)
       /// </summary>
       [Display(Name ="需求单据(销售订单)")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FSALEORDERNO { get; set; }

       /// <summary>
       /// FWORKSHOPID
       /// </summary>
       [Display(Name =" FWORKSHOPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FWORKSHOPID { get; set; }

       /// <summary>
       ///FPRDORGID
       /// </summary>
       [Display(Name ="FPRDORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FPRDORGID { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///排程日期
       /// </summary>
       [Display(Name ="排程日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FSCHEDULEDATE { get; set; }

       /// <summary>
       ///下达日期
       /// </summary>
       [Display(Name ="下达日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCONVEYDATE { get; set; }

       /// <summary>
       ///开工日期
       /// </summary>
       [Display(Name ="开工日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FSTARTDATE { get; set; }

       /// <summary>
       ///完工日期
       /// </summary>
       [Display(Name ="完工日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FFINISHDATE { get; set; }

       /// <summary>
       ///结案日期
       /// </summary>
       [Display(Name ="结案日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FCLOSEDATE { get; set; }

       /// <summary>
       ///工单类型ID
       /// </summary>
       [Display(Name ="工单类型ID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       public string BillTypeId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WOStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FBILLNO { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(107)]
       [Column(TypeName="varchar(107)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///产出品短码
       /// </summary>
       [Display(Name ="产出品短码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProductShortCode { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [Column(TypeName="int")]
       public int? OrgCode { get; set; }

       /// <summary>
       ///ERP子工单ID
       /// </summary>
       [Display(Name ="ERP子工单ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkShopName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkShopName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkShopCode")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkShopCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkOrderDesc")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkOrderDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VOLUME")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int F_PASF_VOLUME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NEWPREFIX")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NEWPREFIX { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_PACREQUIRE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_PACREQUIRE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_THICKTOL")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_THICKTOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_YIELDSTRENGTH")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_YIELDSTRENGTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_WIDTHTOL")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_WIDTHTOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_EXTENSIONSTRENGTH")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_EXTENSIONSTRENGTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_DECIMAL")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_DECIMAL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_ELONGATION")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_ELONGATION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_CHROMEPLATE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_CHROMEPLATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_BASTHICKTOL")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_BASTHICKTOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_FILMTHICKTOL")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_FILMTHICKTOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_PEELSTRENGTH")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_PEELSTRENGTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_HTSTENGTH")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_HTSTENGTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_SURFROUGHNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_SURFROUGHNESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_SURFGLOSS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_SURFGLOSS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_VICKHARDNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_VICKHARDNESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_ROCKHARDNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_ROCKHARDNESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_RAG")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_RAG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_NIKELTHICKNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NIKELTHICKNESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_ALLOYTHICKNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_ALLOYTHICKNESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_SALTFOG")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_SALTFOG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_LENTHTOL")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_LENTHTOL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_LENTH")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int F_PASF_LENTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_MANUFACTURER")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MANUFACTURER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_PRDTYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_PRDTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkChildOrderDesc")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string WorkChildOrderDesc { get; set; }

       
    }
}