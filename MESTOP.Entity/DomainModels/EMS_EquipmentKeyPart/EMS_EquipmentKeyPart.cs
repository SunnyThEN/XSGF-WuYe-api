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
    [Entity(TableCnName = "设备关键部件档案",TableName = "EMS_EquipmentKeyPart",DBServer = "SysDbContext")]
    public partial class EMS_EquipmentKeyPart:SysEntity
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
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///设备关键部件编码
       /// </summary>
       [Display(Name ="设备关键部件编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentKeyPartCode { get; set; }

       /// <summary>
       ///设备关键部件名称
       /// </summary>
       [Display(Name ="设备关键部件名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentKeyPartName { get; set; }

       /// <summary>
       ///设备关键部件描述
       /// </summary>
       [Display(Name ="设备关键部件描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string EquipmentKeyPartDesc { get; set; }

       /// <summary>
       ///是否参与点检
       /// </summary>
       [Display(Name ="是否参与点检")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsSpotCheck { get; set; }

       /// <summary>
       ///是否参与维保
       /// </summary>
       [Display(Name ="是否参与维保")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsMaintenance { get; set; }

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
