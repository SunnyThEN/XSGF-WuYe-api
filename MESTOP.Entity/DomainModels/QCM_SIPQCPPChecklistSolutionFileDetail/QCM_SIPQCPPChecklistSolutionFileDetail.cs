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
    [Entity(TableCnName = "质检单类型方案档案明细",TableName = "QCM_SIPQCPPChecklistSolutionFileDetail",DBServer = "SysDbContext")]
    public partial class QCM_SIPQCPPChecklistSolutionFileDetail:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SolutionFileListID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid SolutionFileListID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SolutionFileID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? SolutionFileID { get; set; }

       /// <summary>
       ///检验项目方案档案编码
       /// </summary>
       [Display(Name ="检验项目方案档案编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///检验项目方案档案名称
       /// </summary>
       [Display(Name ="检验项目方案档案名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionName { get; set; }

       /// <summary>
       ///检验项目方案档案描述
       /// </summary>
       [Display(Name ="检验项目方案档案描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionDesc { get; set; }

       /// <summary>
       ///是否启用抽样和处理规则
       /// </summary>
       [Display(Name ="是否启用抽样和处理规则")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsFCheckScheme { get; set; }

       /// <summary>
       ///抽样和处理规则编码
       /// </summary>
       [Display(Name ="抽样和处理规则编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeCode { get; set; }

       /// <summary>
       ///抽样和处理规则名称
       /// </summary>
       [Display(Name ="抽样和处理规则名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeName { get; set; }

       /// <summary>
       ///抽样和处理规则描述
       /// </summary>
       [Display(Name ="抽样和处理规则描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeDesc { get; set; }

       /// <summary>
       ///是否抽样数量比例
       /// </summary>
       [Display(Name ="是否抽样数量比例")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSIPSampleRate { get; set; }

       /// <summary>
       ///抽样数量比例（%）
       /// </summary>
       [Display(Name ="抽样数量比例（%）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPSampleRate { get; set; }

       /// <summary>
       ///是否抽样固定数量
       /// </summary>
       [Display(Name ="是否抽样固定数量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSIPSampleQty { get; set; }

       /// <summary>
       ///抽样固定数量
       /// </summary>
       [Display(Name ="抽样固定数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPSampleQty { get; set; }

       /// <summary>
       ///抽样执行频率（分钟）
       /// </summary>
       [Display(Name ="抽样执行频率（分钟）")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPSampleTimeIntervals { get; set; }

       /// <summary>
       ///是否禁用
       /// </summary>
       [Display(Name ="是否禁用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsDisable { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="smalldatetime")]
       [Editable(true)]
       public DateTime? ModifyTime { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       
    }
}