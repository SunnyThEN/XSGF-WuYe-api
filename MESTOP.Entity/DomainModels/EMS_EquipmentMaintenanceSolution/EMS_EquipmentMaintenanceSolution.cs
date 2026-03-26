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
    [Entity(TableCnName = "设备维保方案",TableName = "EMS_EquipmentMaintenanceSolution",DBServer = "SysDbContext")]
    public partial class EMS_EquipmentMaintenanceSolution:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///设备点检项目编码
       /// </summary>
       [Display(Name ="设备点检项目编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemCode { get; set; }

       /// <summary>
       ///设备点检项目名称
       /// </summary>
       [Display(Name ="设备点检项目名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemName { get; set; }

       /// <summary>
       ///设备点检项目描述
       /// </summary>
       [Display(Name ="设备点检项目描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SpotCheckItemDesc { get; set; }

       /// <summary>
       ///点检更换物料编码
       /// </summary>
       [Display(Name ="点检更换物料编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialCode { get; set; }

       /// <summary>
       ///点检更换物料名称
       /// </summary>
       [Display(Name ="点检更换物料名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialName { get; set; }

       /// <summary>
       ///点检更换物料计量单位
       /// </summary>
       [Display(Name ="点检更换物料计量单位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialUOM { get; set; }

       /// <summary>
       ///点检更换物料数量
       /// </summary>
       [Display(Name ="点检更换物料数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SpotCheckItemMaterialQty { get; set; }

       /// <summary>
       ///点检方法指导书
       /// </summary>
       [Display(Name ="点检方法指导书")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckMethodESOP { get; set; }

       /// <summary>
       ///点检工具编码
       /// </summary>
       [Display(Name ="点检工具编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemToolNo { get; set; }

       /// <summary>
       ///点检工具名称
       /// </summary>
       [Display(Name ="点检工具名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemToolName { get; set; }

       /// <summary>
       ///人员技能方案编码
       /// </summary>
       [Display(Name ="人员技能方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionNo { get; set; }

       /// <summary>
       ///人员技能方案名称
       /// </summary>
       [Display(Name ="人员技能方案名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionName { get; set; }

       /// <summary>
       ///管控计量单位
       /// </summary>
       [Display(Name ="管控计量单位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ControlUOM { get; set; }

       /// <summary>
       ///管控精度USL
       /// </summary>
       [Display(Name ="管控精度USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlUSL { get; set; }

       /// <summary>
       ///管控精度LSL
       /// </summary>
       [Display(Name ="管控精度LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlLSL { get; set; }

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
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="N01")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string N01 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N02")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string N02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N03")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string N03 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N04")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string N04 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N05")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       public string N05 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N06")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       public string N06 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N07")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       public string N07 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N08")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       public string N08 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       
    }
}
