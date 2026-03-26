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
    [Entity(TableCnName = "自检单明细",TableName = "QCM_SelfTestList",DetailTable =  new Type[] { typeof(QCM_SelfTestListTC)},DetailTableCnName = "检验数据",DBServer = "SysDbContext")]
    public partial class QCM_SelfTestList:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="DynaListID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid DynaListID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DynaID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? DynaID { get; set; }

       /// <summary>
       ///检验提交单编码
       /// </summary>
       [Display(Name ="检验提交单编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistCode { get; set; }

       /// <summary>
       ///检验提交单单据状态
       /// </summary>
       [Display(Name ="检验提交单单据状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPQCChecklistCodeStatus { get; set; }

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
       ///质检单方案档案编码
       /// </summary>
       [Display(Name ="质检单方案档案编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionCode { get; set; }

       /// <summary>
       ///质检单方案档案名称
       /// </summary>
       [Display(Name ="质检单方案档案名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionName { get; set; }

       /// <summary>
       ///质检单方案档案描述
       /// </summary>
       [Display(Name ="质检单方案档案描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPQCPPChecklistSolutionDesc { get; set; }

       /// <summary>
       ///检验项目方案档案编码
       /// </summary>
       [Display(Name ="检验项目方案档案编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///检验项目方案档案名称
       /// </summary>
       [Display(Name ="检验项目方案档案名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPSolutionName { get; set; }

       /// <summary>
       ///检验项目方案档案描述
       /// </summary>
       [Display(Name ="检验项目方案档案描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPSolutionDesc { get; set; }

       /// <summary>
       ///检验项目类型编码
       /// </summary>
       [Display(Name ="检验项目类型编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemTypeCode { get; set; }

       /// <summary>
       ///检验项目类型名称
       /// </summary>
       [Display(Name ="检验项目类型名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemTypeName { get; set; }

       /// <summary>
       ///检验项目类型描述
       /// </summary>
       [Display(Name ="检验项目类型描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemTypeDesc { get; set; }

       /// <summary>
       ///检验项目编码
       /// </summary>
       [Display(Name ="检验项目编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemCode { get; set; }

       /// <summary>
       ///检验项目名称
       /// </summary>
       [Display(Name ="检验项目名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemName { get; set; }

       /// <summary>
       ///检验项目描述
       /// </summary>
       [Display(Name ="检验项目描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPItemDesc { get; set; }

       /// <summary>
       ///检验项目结果评价
       /// </summary>
       [Display(Name ="检验项目结果评价")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPQCQualityStatus { get; set; }

       /// <summary>
       ///结果评价数据提交状态
       /// </summary>
       [Display(Name ="结果评价数据提交状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPQCAddStatus { get; set; }

       /// <summary>
       ///记录纸质文件照片附件
       /// </summary>
       [Display(Name ="记录纸质文件照片附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPAttachedFile { get; set; }

       /// <summary>
       ///检验规范文本SIP链接
       /// </summary>
       [Display(Name ="检验规范文本SIP链接")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string FInspectionSpeTextSIPLink { get; set; }

       /// <summary>
       ///检验项目执行人员
       /// </summary>
       [Display(Name ="检验项目执行人员")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string QCExePeople { get; set; }

       /// <summary>
       ///检验项目开始时间
       /// </summary>
       [Display(Name ="检验项目开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? QCExeStartDate { get; set; }

       /// <summary>
       ///检验项目结束时间
       /// </summary>
       [Display(Name ="检验项目结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? QCExeEndDate { get; set; }

       /// <summary>
       ///定性检验合格描述
       /// </summary>
       [Display(Name ="定性检验合格描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string FDnCheckOutDesc { get; set; }

       /// <summary>
       ///定量检验合格UCL
       /// </summary>
       [Display(Name ="定量检验合格UCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutUCL { get; set; }

       /// <summary>
       ///定量检验合格LCL
       /// </summary>
       [Display(Name ="定量检验合格LCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutLCL { get; set; }

       /// <summary>
       ///定量检验合格CL
       /// </summary>
       [Display(Name ="定量检验合格CL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutCL { get; set; }

       /// <summary>
       ///定量检验合格USL
       /// </summary>
       [Display(Name ="定量检验合格USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutUSL { get; set; }

       /// <summary>
       ///定量检验合格SL
       /// </summary>
       [Display(Name ="定量检验合格SL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutSL { get; set; }

       /// <summary>
       ///定量检验合格LSL
       /// </summary>
       [Display(Name ="定量检验合格LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FRationCheckOutLSL { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       [Display(Name ="检验数据")]
       [ForeignKey("DynaListID")]
       public List<QCM_SelfTestListTC> QCM_SelfTestListTC { get; set; }


       
    }
}