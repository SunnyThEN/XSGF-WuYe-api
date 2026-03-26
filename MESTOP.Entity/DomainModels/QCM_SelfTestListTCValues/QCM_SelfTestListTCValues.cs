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
    [Entity(TableCnName = "自检单定量数值和定性描述",TableName = "QCM_SelfTestListTCValues",DBServer = "SysDbContext")]
    public partial class QCM_SelfTestListTCValues:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="DynaTCVID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid DynaTCVID { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string tracingNo { get; set; }

       /// <summary>
       ///样本数据编码
       /// </summary>
       [Display(Name ="样本数据编码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SamplesValuesCode { get; set; }

       /// <summary>
       ///追溯码主计量单位
       /// </summary>
       [Display(Name ="追溯码主计量单位")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string tracingMasterUOM { get; set; }

       /// <summary>
       ///追溯码主计量单位数量
       /// </summary>
       [Display(Name ="追溯码主计量单位数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? tracingMasterQTY { get; set; }

       /// <summary>
       ///追溯码辅助计量单位
       /// </summary>
       [Display(Name ="追溯码辅助计量单位")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string tracingAuxiliaryUOM { get; set; }

       /// <summary>
       ///追溯码辅助计量单位数量
       /// </summary>
       [Display(Name ="追溯码辅助计量单位数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? tracingAuxiliaryQTY { get; set; }

       /// <summary>
       ///追溯码检验数值结果评价
       /// </summary>
       [Display(Name ="追溯码检验数值结果评价")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? tracingNoQCQualityStatus { get; set; }

       /// <summary>
       ///追溯码检验数值结果评价描述
       /// </summary>
       [Display(Name ="追溯码检验数值结果评价描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string tracingNoQCQualityStatusDesc { get; set; }

       /// <summary>
       ///实验数值
       /// </summary>
       [Display(Name ="实验数值")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string QCRealValue { get; set; }

       /// <summary>
       ///实验环境描述
       /// </summary>
       [Display(Name ="实验环境描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string QCRealEnvironment { get; set; }

       /// <summary>
       ///实际开始时间
       /// </summary>
       [Display(Name ="实际开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? QCRealStartTime { get; set; }

       /// <summary>
       ///实际结束时间
       /// </summary>
       [Display(Name ="实际结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? QCRealEndTime { get; set; }

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

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DynaTCID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? DynaTCID { get; set; }

       
    }
}