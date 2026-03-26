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
    [Entity(TableCnName = "自检提交单",TableName = "QCM_SelfTest",DBServer = "SysDbContext")]
    public partial class QCM_SelfTest:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="DynaID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid DynaID { get; set; }

       /// <summary>
       ///提交单编码
       /// </summary>
       [Display(Name ="提交单编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistCode { get; set; }

       /// <summary>
       ///提交单单据状态
       /// </summary>
       [Display(Name ="提交单单据状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPQCChecklistCodeStatus { get; set; }

       /// <summary>
       ///提交单任务结果评价
       /// </summary>
       [Display(Name ="提交单任务结果评价")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPQCChecklistTaskStatus { get; set; }

       /// <summary>
       ///检验提交单类型编码
       /// </summary>
       [Display(Name ="检验提交单类型编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistTypeCode { get; set; }

       /// <summary>
       ///检验提交单类型名称
       /// </summary>
       [Display(Name ="检验提交单类型名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistTypeName { get; set; }

       /// <summary>
       ///检验提交单类型描述
       /// </summary>
       [Display(Name ="检验提交单类型描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistTypeDesc { get; set; }

       /// <summary>
       ///源单编码
       /// </summary>
       [Display(Name ="源单编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SourceChecklistCode { get; set; }

       /// <summary>
       ///源单名称
       /// </summary>
       [Display(Name ="源单名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SourceChecklistName { get; set; }

       /// <summary>
       ///所组批批号
       /// </summary>
       [Display(Name ="所组批批号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string POCode { get; set; }

       /// <summary>
       ///计划抽样数量
       /// </summary>
       [Display(Name ="计划抽样数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQCChecklistPlanQTY { get; set; }

       /// <summary>
       ///实抽样数量
       /// </summary>
       [Display(Name ="实抽样数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQCChecklistRealQTY { get; set; }

       /// <summary>
       ///抽样人员
       /// </summary>
       [Display(Name ="抽样人员")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string GetSamplePeople { get; set; }

       /// <summary>
       ///抽样日期
       /// </summary>
       [Display(Name ="抽样日期")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string GetSampleDate { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工序流程名称
       /// </summary>
       [Display(Name ="工序流程名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
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
       ///主计量单位数量
       /// </summary>
       [Display(Name ="主计量单位数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? MasterQTY { get; set; }

       /// <summary>
       ///主计量单位
       /// </summary>
       [Display(Name ="主计量单位")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///辅助计量单位数量
       /// </summary>
       [Display(Name ="辅助计量单位数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? AuxiliaryQTY { get; set; }

       /// <summary>
       ///辅助计量单位
       /// </summary>
       [Display(Name ="辅助计量单位")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string AuxiliaryUOM { get; set; }

       /// <summary>
       ///下推状态
       /// </summary>
       [Display(Name ="下推状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PushDownStatus { get; set; }

       
    }
}