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
    [Entity(TableCnName = "物流管理",TableName = "PPM_MaterialPointSet",DBServer = "SysDbContext")]
    public partial class PPM_MaterialPointSet:SysEntity
    {
        /// <summary>
       ///起始料点
       /// </summary>
       [Display(Name ="起始料点")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FromPort { get; set; }

       /// <summary>
       ///终点料点
       /// </summary>
       [Display(Name ="终点料点")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ToPort { get; set; }

       /// <summary>
       ///料点状态
       /// </summary>
       [Display(Name ="料点状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PortStatus { get; set; }

       /// <summary>
       ///接口名称
       /// </summary>
       [Display(Name ="接口名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string InterfaceName { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialName { get; set; }

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
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

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
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       /// <summary>
       ///工序节点代码
       /// </summary>
       [Display(Name ="工序节点代码")]
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
       ///物流模式
       /// </summary>
       [Display(Name ="物流模式")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? LogisticsType { get; set; }

       /// <summary>
       ///是否原材料
       /// </summary>
       [Display(Name ="是否原材料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsMaterial { get; set; }

       /// <summary>
       ///顺序号
       /// </summary>
       [Display(Name ="顺序号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? sequence { get; set; }

       /// <summary>
       ///是否强制回库
       /// </summary>
       [Display(Name ="是否强制回库")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isForceReceipt { get; set; }

       /// <summary>
       ///是否主料
       /// </summary>
       [Display(Name ="是否主料")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isMainMaterial { get; set; }

       /// <summary>
       ///顺序分组号
       /// </summary>
       [Display(Name ="顺序分组号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string sequenceGroup { get; set; }

       /// <summary>
       ///排序总数
       /// </summary>
       [Display(Name ="排序总数")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? sequenceCount { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       
    }
}