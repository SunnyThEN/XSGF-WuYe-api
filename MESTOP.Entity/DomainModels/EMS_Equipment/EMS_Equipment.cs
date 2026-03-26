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
    [Entity(TableCnName = "设备档案",TableName = "EMS_Equipment",DBServer = "SysDbContext")]
    public partial class EMS_Equipment:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid EId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ETId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ETId { get; set; }

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
       ///设备描述
       /// </summary>
       [Display(Name ="设备描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EquipmentDesc { get; set; }

       /// <summary>
       ///设备类型编码
       /// </summary>
       [Display(Name ="设备类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentTypeCode { get; set; }

       /// <summary>
       ///设备类型名称
       /// </summary>
       [Display(Name ="设备类型名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentTypeName { get; set; }

       /// <summary>
       ///是否维保
       /// </summary>
       [Display(Name ="是否维保")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsMaintenance { get; set; }

       /// <summary>
       ///是否点检
       /// </summary>
       [Display(Name ="是否点检")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSpotCheck { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///端口号
       /// </summary>
       [Display(Name ="端口号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PortNo { get; set; }

       /// <summary>
       ///网关地址
       /// </summary>
       [Display(Name ="网关地址")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string GateWayAddress { get; set; }

       /// <summary>
       ///IP地址
       /// </summary>
       [Display(Name ="IP地址")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string IPAddress { get; set; }

       /// <summary>
       ///设备维保计划编码
       /// </summary>
       [Display(Name ="设备维保计划编码")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsIOT { get; set; }

       /// <summary>
       ///设备维保计划编码
       /// </summary>
       [Display(Name ="设备维保计划编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentPlanCode { get; set; }

       /// <summary>
       ///是否启用维保计划
       /// </summary>
       [Display(Name ="是否启用维保计划")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsMaintenancePlan { get; set; }

       /// <summary>
       ///设备维保方案编码
       /// </summary>
       [Display(Name ="设备维保方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentMaintenanceCode { get; set; }

       /// <summary>
       ///点检计划编码
       /// </summary>
       [Display(Name ="点检计划编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSpotPCheckPlanCode { get; set; }

       /// <summary>
       ///是否启用点检计划
       /// </summary>
       [Display(Name ="是否启用点检计划")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSpotCheckPlan { get; set; }

       /// <summary>
       ///点检方案编码
       /// </summary>
       [Display(Name ="点检方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSpotCheckCode { get; set; }

       /// <summary>
       ///供应商名称
       /// </summary>
       [Display(Name ="供应商名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SupplierName { get; set; }

       /// <summary>
       ///供应商编码
       /// </summary>
       [Display(Name ="供应商编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SupplierCode { get; set; }

       /// <summary>
       ///人员技能方案编码
       /// </summary>
       [Display(Name ="人员技能方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SkillSolutionCode { get; set; }

       /// <summary>
       ///设备技能方案名称
       /// </summary>
       [Display(Name ="设备技能方案名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSkillSolutionName { get; set; }

       /// <summary>
       ///设备技能方案编码
       /// </summary>
       [Display(Name ="设备技能方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentSkillSolutionCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N01")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N01 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N02")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N03")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N03 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N04")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N04 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N05")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N05 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N06")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N06 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N07")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N07 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N08")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N08 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EquipStatusId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? EquipStatusId { get; set; }

       
    }
}