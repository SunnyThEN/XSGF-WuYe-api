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
    [Entity(TableCnName = "自检单检验数据",TableName = "QCM_SelfTestListTC",DetailTable =  new Type[] { typeof(QCM_SelfTestListTCValues)},DetailTableCnName = "定量数值和描述",DBServer = "SysDbContext")]
    public partial class QCM_SelfTestListTC:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="DynaTCID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid DynaTCID { get; set; }

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
       ///物料描述
       /// </summary>
       [Display(Name ="物料描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string tracingNo { get; set; }

       /// <summary>
       ///追溯码检验结果评价
       /// </summary>
       [Display(Name ="追溯码检验结果评价")]
       [Column(TypeName="int")]
       public int? tracingNoQCQualityStatus { get; set; }

       /// <summary>
       ///追溯码检验结果评价描述
       /// </summary>
       [Display(Name ="追溯码检验结果评价描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string tracingNoQCQualityStatusDesc { get; set; }

       /// <summary>
       ///追溯码处置策略
       /// </summary>
       [Display(Name ="追溯码处置策略")]
       [Column(TypeName="int")]
       public int? tracingNoDisStrategy { get; set; }

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
       [Display(Name ="DynaListID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? DynaListID { get; set; }

       [Display(Name ="定量数值和描述")]
       [ForeignKey("DynaTCID")]
       public List<QCM_SelfTestListTCValues> QCM_SelfTestListTCValues { get; set; }


       
    }
}