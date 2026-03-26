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
    [Entity(TableCnName = "工位产出品管理",TableName = "PPM_WorkFlowWorkSation",DBServer = "SysDbContext")]
    public partial class PPM_WorkFlowWorkSation:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WKSId { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///生产组织代码
       /// </summary>
       [Display(Name ="生产组织代码")]
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
       ///标准工时产能
       /// </summary>
       [Display(Name ="标准工时产能")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? MaterialWorkTime { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid StepId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkStationId")]
       [Column(TypeName="int")]
       public int? WorkStationId { get; set; }

       /// <summary>
       ///是否生产追溯
       /// </summary>
       [Display(Name ="是否生产追溯")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isProdTrace { get; set; }

       /// <summary>
       ///是否不良品追溯
       /// </summary>
       [Display(Name ="是否不良品追溯")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDefectiveTrace { get; set; }

       /// <summary>
       ///是否包装追溯
       /// </summary>
       [Display(Name ="是否包装追溯")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isPackTrace { get; set; }

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
       ///下料料点
       /// </summary>
       [Display(Name ="下料料点")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialPointCode { get; set; }

       /// <summary>
       ///料点名称
       /// </summary>
       [Display(Name ="料点名称")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialPointName { get; set; }

       /// <summary>
       ///是否呼叫空盛具
       /// </summary>
       [Display(Name ="是否呼叫空盛具")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isCallEmptyContainer { get; set; }

       /// <summary>
       ///是否流转下一料点
       /// </summary>
       [Display(Name ="是否流转下一料点")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isToNextPort { get; set; }

       /// <summary>
       ///下一料点编码
       /// </summary>
       [Display(Name ="下一料点编码")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NextPortCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出品名称
       /// </summary>
       [Display(Name ="产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       
    }
}
