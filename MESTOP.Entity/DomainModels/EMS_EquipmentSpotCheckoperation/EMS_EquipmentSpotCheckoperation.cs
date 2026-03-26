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
    [Entity(TableCnName = "设备点检执行LS",TableName = "EMS_EquipmentSpotCheckoperation",DBServer = "SysDbContext")]
    public partial class EMS_EquipmentSpotCheckoperation:SysEntity
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
       ///作业员姓名
       /// </summary>
       [Display(Name ="作业员姓名")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSpotCheckPeopleName { get; set; }

       /// <summary>
       ///作业员编码
       /// </summary>
       [Display(Name ="作业员编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSpotCheckPeopleCode { get; set; }

       /// <summary>
       ///点检执行状态
       /// </summary>
       [Display(Name ="点检执行状态")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? SpotCheckState { get; set; }

       /// <summary>
       ///执行日期
       /// </summary>
       [Display(Name ="执行日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? SpotCheckDate { get; set; }

       /// <summary>
       ///关联设备点检项目档案表
       /// </summary>
       [Display(Name ="关联设备点检项目档案表")]
       [Column(TypeName="int")]
       public int? EquipmentSpotCheckItemFileId { get; set; }

       /// <summary>
       ///关联设备维保方案表
       /// </summary>
       [Display(Name ="关联设备维保方案表")]
       [Column(TypeName="int")]
       public int? EquipmentMaintenanceSolutionId { get; set; }

       /// <summary>
       ///关联设备点检方案表
       /// </summary>
       [Display(Name ="关联设备点检方案表")]
       [Column(TypeName="int")]
       public int? EquipmentSpotCheckSolutonId { get; set; }

       /// <summary>
       ///关联设备
       /// </summary>
       [Display(Name ="关联设备")]
       [Column(TypeName="int")]
       public int? EquipmentFileId { get; set; }

       /// <summary>
       ///关联设备关键部位档案表
       /// </summary>
       [Display(Name ="关联设备关键部位档案表")]
       [Column(TypeName="int")]
       public int? EquipmentKeyPartFileId { get; set; }

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
       ///点检方案编码
       /// </summary>
       [Display(Name ="点检方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionCode { get; set; }

       /// <summary>
       ///点检方案名称
       /// </summary>
       [Display(Name ="点检方案名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionName { get; set; }

       /// <summary>
       ///关联设备名称
       /// </summary>
       [Display(Name ="关联设备名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///关联设备编码
       /// </summary>
       [Display(Name ="关联设备编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentCode { get; set; }

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
