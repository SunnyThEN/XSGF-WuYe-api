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
    [Entity(TableCnName = "工序质检单档案配置",TableName = "QCM_WorkFlowStep",DBServer = "SysDbContext")]
    public partial class QCM_WorkFlowStep:SysEntity
    {
        /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

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
       ///工序节点产出品编码
       /// </summary>
       [Display(Name ="工序节点产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///工序节点产出品名称
       /// </summary>
       [Display(Name ="工序节点产出品名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///工序节点编号
       /// </summary>
       [Display(Name ="工序节点编号")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
   //    [Required(AllowEmptyStrings=false)]
       public Guid StepId { get; set; }

       /// <summary>
       ///工序节点名称
       /// </summary>
       [Display(Name ="工序节点名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string StepName { get; set; }

       /// <summary>
       ///工序流程描述
       /// </summary>
       [Display(Name ="工序流程描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///质检方式
       /// </summary>
       [Display(Name ="质检方式")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string SIPItemMethod { get; set; }

       /// <summary>
       ///是否禁用
       /// </summary>
       [Display(Name ="是否禁用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsDisable { get; set; }

       /// <summary>
       ///是否结果评价物流管控
       /// </summary>
       [Display(Name ="是否结果评价物流管控")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSIPQCFAIWorkFlowControl { get; set; }

       /// <summary>
       ///质检单类型描述
       /// </summary>
       [Display(Name ="质检单类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistTypeDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///质检单类型名称
       /// </summary>
       [Display(Name ="质检单类型名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCChecklistTypeName { get; set; }

       /// <summary>
       ///上级节点
       /// </summary>
       [Display(Name ="上级节点")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ParentId { get; set; }

       /// <summary>
       ///质检单类型编码
       /// </summary>
       [Display(Name ="质检单类型编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCChecklistTypeCode { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ProcessId { get; set; }

       /// <summary>
       ///质检单方案档案描述
       /// </summary>
       [Display(Name ="质检单方案档案描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionDesc { get; set; }

       /// <summary>
       ///质检单方案档案名称
       /// </summary>
       [Display(Name ="质检单方案档案名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionCode { get; set; }

       /// <summary>
       ///质检单方案档案编码
       /// </summary>
       [Display(Name ="质检单方案档案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionName { get; set; }

       /// <summary>
       ///流程主表Id
       /// </summary>
       [Display(Name ="流程主表Id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? WorkFlowMain_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="WorkStepFlow_Id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WorkStepFlow_Id { get; set; }

       /// <summary>
       ///标准小时产能
       /// </summary>
       [Display(Name ="标准小时产能")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? StandardCapacity { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StandardTime")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? StandardTime { get; set; }

       /// <summary>
       ///流程子表id
       /// </summary>
       [Display(Name ="流程子表id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? WorkFlow_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepType")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StepType { get; set; }

       /// <summary>
       ///审批用户id或角色id
       /// </summary>
       [Display(Name ="审批用户id或角色id")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StepValue { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       /// 创建人
       /// </summary>
       [Display(Name =" 创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Enable")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       public byte? Enable { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       
    }
}