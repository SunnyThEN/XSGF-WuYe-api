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
    [Entity(TableCnName = "工序流程设备",TableName = "PPM_WorkFlowEquipment",DBServer = "SysDbContext")]
    public partial class PPM_WorkFlowEquipment:SysEntity
    {
        /// <summary>
       ///生产组织编码
       /// </summary>
       [Display(Name ="生产组织编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///生产组织名称
       /// </summary>
       [Display(Name ="生产组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string EquipmentCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///设备点检方案编码
       /// </summary>
       [Display(Name ="设备点检方案编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionCode { get; set; }

       /// <summary>
       ///设备点检方案名称
       /// </summary>
       [Display(Name ="设备点检方案名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionName { get; set; }

       /// <summary>
       ///是否需要点检
       /// </summary>
       [Display(Name ="是否需要点检")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSpotCheck { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WKEId { get; set; }

       /// <summary>
       ///工序节点
       /// </summary>
       [Display(Name ="工序节点")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid StepId { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///设备ID
       /// </summary>
       [Display(Name ="设备ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? EId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WKSId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? WKSId { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkStationCode { get; set; }

       
    }
}
