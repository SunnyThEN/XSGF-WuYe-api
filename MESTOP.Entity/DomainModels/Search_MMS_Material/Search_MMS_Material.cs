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
    [Entity(TableCnName = "物料查询",TableName = "Search_MMS_Material",DBServer = "SysDbContext")]
    public partial class Search_MMS_Material:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MTFId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MTFId { get; set; }

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
       ///物料短码
       /// </summary>
       [Display(Name ="物料短码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialShortNo { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///物料版本
       /// </summary>
       [Display(Name ="物料版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialVersion { get; set; }

       /// <summary>
       ///所需工时
       /// </summary>
       [Display(Name ="所需工时")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaterialWorkTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CustomerMaterialNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CustomerMaterialNo { get; set; }

       /// <summary>
       ///BOM编码
       /// </summary>
       [Display(Name ="BOM编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BOMCode { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialTypeCode { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialTypeName { get; set; }

       /// <summary>
       ///质保期
       /// </summary>
       [Display(Name ="质保期")]
       [Column(TypeName="float")]
       public float? Warranty_date { get; set; }

       /// <summary>
       ///盛具类型编码
       /// </summary>
       [Display(Name ="盛具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ContainerTypeCode { get; set; }

       /// <summary>
       ///载具类型编码
       /// </summary>
       [Display(Name ="载具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string VehicleTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       
    }
}
