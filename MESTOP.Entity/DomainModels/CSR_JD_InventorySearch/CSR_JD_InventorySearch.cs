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
    [Entity(TableCnName = "即时仓库查询",TableName = "CSR_JD_InventorySearch",DBServer = "ServiceDbContext")]
    public partial class CSR_JD_InventorySearch:ServiceEntity
    {
        /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string FLOT { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料规格
       /// </summary>
       [Display(Name ="物料规格")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///物料宽度
       /// </summary>
       [Display(Name ="物料宽度")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string MaterialWidth { get; set; }

       /// <summary>
       ///英文单位
       /// </summary>
       [Display(Name ="英文单位")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Required(AllowEmptyStrings=false)]
       public string MasterUOMCode { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MaterialTypeCode { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       public string MasterUOM { get; set; }

       /// <summary>
       ///仓库名称
       /// </summary>
       [Display(Name ="仓库名称")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string StockName { get; set; }

       /// <summary>
       ///仓库编码
       /// </summary>
       [Display(Name ="仓库编码")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Required(AllowEmptyStrings=false)]
       public string StockNumber { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FUSEORGID { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEQTY { get; set; }

       /// <summary>
       ///质量结果
       /// </summary>
       [Display(Name ="质量结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMATERIALGROUP")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FMATERIALGROUP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MaterialShortNo")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string MaterialShortNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQTY")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal FQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Required(AllowEmptyStrings=false)]
       public string FID { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int MId { get; set; }

       /// <summary>
       ///库位ID
       /// </summary>
       [Display(Name ="库位ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKID { get; set; }

       /// <summary>
       ///长度
       /// </summary>
       [Display(Name ="长度")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_LENTH { get; set; }

       /// <summary>
       ///质量等级
       /// </summary>
       [Display(Name ="质量等级")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string F_PASF_QUALEVEL { get; set; }

       /// <summary>
       ///质量描述
       /// </summary>
       [Display(Name ="质量描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_QUADES { get; set; }

       /// <summary>
       ///去向
       /// </summary>
       [Display(Name ="去向")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_DESTINATION { get; set; }

       /// <summary>
       ///桶芯
       /// </summary>
       [Display(Name ="桶芯")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string F_PASF_BARRELCORES { get; set; }

       /// <summary>
       ///硬度
       /// </summary>
       [Display(Name ="硬度")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_HARDNESS { get; set; }

       /// <summary>
       ///镍层厚度
       /// </summary>
       [Display(Name ="镍层厚度")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_NICKELTHICKNESS { get; set; }

       /// <summary>
       ///粗糙度(上表面/下表面)
       /// </summary>
       [Display(Name ="粗糙度(上表面/下表面)")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_ROUGHNESS { get; set; }

       /// <summary>
       ///屈服强度
       /// </summary>
       [Display(Name ="屈服强度")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_YIELDSTRENGTH { get; set; }

       /// <summary>
       ///抗拉强度
       /// </summary>
       [Display(Name ="抗拉强度")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_TENSILESTRENGTH { get; set; }

       /// <summary>
       ///表面粗糙度(上)
       /// </summary>
       [Display(Name ="表面粗糙度(上)")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Up { get; set; }

       /// <summary>
       ///表面粗糙度(下)
       /// </summary>
       [Display(Name ="表面粗糙度(下)")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SurfaceRou_Down { get; set; }

       /// <summary>
       ///屈服强度（Rp0.2）
       /// </summary>
       [Display(Name ="屈服强度（Rp0.2）")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStrRp02 { get; set; }

       /// <summary>
       ///硬度(HV)
       /// </summary>
       [Display(Name ="硬度(HV)")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string HV { get; set; }

       /// <summary>
       ///镍层厚度
       /// </summary>
       [Display(Name ="镍层厚度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string NickelThk { get; set; }

       /// <summary>
       ///TensileStr
       /// </summary>
       [Display(Name ="TensileStr")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TensileStr { get; set; }

       /// <summary>
       ///屈服强度
       /// </summary>
       [Display(Name ="屈服强度")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string YieldStr { get; set; }

       /// <summary>
       ///产出时间
       /// </summary>
       [Display(Name ="产出时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RealEndTime { get; set; }

       
    }
}
