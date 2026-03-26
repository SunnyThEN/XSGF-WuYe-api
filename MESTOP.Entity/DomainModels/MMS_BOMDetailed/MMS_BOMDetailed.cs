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
    [Entity(TableCnName = "主BOM管理",TableName = "MMS_BOMDetailed",DBServer = "SysDbContext")]
    public partial class MMS_BOMDetailed:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BOMId { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///是否原材料
       /// </summary>
       [Display(Name ="是否原材料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsMaterial { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsUse { get; set; }

       /// <summary>
       ///主计量单位用量
       /// </summary>
       [Display(Name ="主计量单位用量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float MasterQTY { get; set; }

       /// <summary>
       ///主计量单位
       /// </summary>
       [Display(Name ="主计量单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///辅助计量单位用量
       /// </summary>
       [Display(Name ="辅助计量单位用量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? AuxiliaryQTY { get; set; }

       /// <summary>
       ///辅助计量单位
       /// </summary>
       [Display(Name ="辅助计量单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AuxiliaryUOM { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string BOMCode { get; set; }

       /// <summary>
       ///上级BOM
       /// </summary>
       [Display(Name ="上级BOM")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentId { get; set; }

       /// <summary>
       ///物料Id
       /// </summary>
       [Display(Name ="物料Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MId { get; set; }

       /// <summary>
       ///替代料优先级
       /// </summary>
       [Display(Name ="替代料优先级")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSubstitutionMaterial { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialTypeCode { get; set; }

       /// <summary>
       ///产出品物料
       /// </summary>
       [Display(Name ="产出品物料")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PBOMMaterialCode { get; set; }

       /// <summary>
       ///载具类型编码
       /// </summary>
       [Display(Name ="载具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string VehicleTypeCode { get; set; }

       /// <summary>
       ///盛具类型编码
       /// </summary>
       [Display(Name ="盛具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ContainerTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="stockQty")]
       [JsonIgnore]
       [Column(TypeName="float")]
       public float? stockQty { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///物料所用工时
       /// </summary>
       [Display(Name ="物料所用工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? MaterialWorkTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FESQ")]
       [Column(TypeName="int")]
       public int? FESQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MQty")]
       [Column(TypeName="float")]
       public float? MQty { get; set; }

       /// <summary>
       ///子项类型
       /// </summary>
       [Display(Name ="子项类型")]
       [Column(TypeName="int")]
       public int? AttributeType { get; set; }

       
    }
}
