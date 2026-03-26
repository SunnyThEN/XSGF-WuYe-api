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
    [Entity(TableCnName = "BOM查询",TableName = "Search_MMS_BOMDetailed",DBServer = "SysDbContext")]
    public partial class Search_MMS_BOMDetailed:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="BOMId")]
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
       ///物料描述
       /// </summary>
       [Display(Name ="物料描述")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///BOM版本
       /// </summary>
       [Display(Name ="BOM版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMVersion { get; set; }

       /// <summary>
       ///主计量单位
       /// </summary>
       [Display(Name ="主计量单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///主计量数量
       /// </summary>
       [Display(Name ="主计量数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float MasterQTY { get; set; }

       /// <summary>
       ///辅计量单位
       /// </summary>
       [Display(Name ="辅计量单位")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AuxiliaryUOM { get; set; }

       /// <summary>
       ///辅计量数量
       /// </summary>
       [Display(Name ="辅计量数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? AuxiliaryQTY { get; set; }

       /// <summary>
       ///物料类型名称
       /// </summary>
       [Display(Name ="物料类型名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MaterialTypeName { get; set; }

       /// <summary>
       ///物料类型编码
       /// </summary>
       [Display(Name ="物料类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialTypeCode { get; set; }

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
       ///上一级BOM
       /// </summary>
       [Display(Name ="上一级BOM")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ParentId { get; set; }

       /// <summary>
       ///主BOM编码
       /// </summary>
       [Display(Name ="主BOM编码")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PBOMMaterialCode { get; set; }

       /// <summary>
       ///是否原材料
       /// </summary>
       [Display(Name ="是否原材料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsMaterial { get; set; }

       /// <summary>
       ///盛具类型
       /// </summary>
       [Display(Name ="盛具类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ContainerTypeCode { get; set; }

       /// <summary>
       ///载具类型
       /// </summary>
       [Display(Name ="载具类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string VehicleTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///物料工时
       /// </summary>
       [Display(Name ="物料工时")]
       [Column(TypeName="float")]
       public float? MaterialWorkTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MQty")]
       [Column(TypeName="float")]
       public float? MQty { get; set; }

       
    }
}
