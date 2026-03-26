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
    [Entity(TableCnName = "抽样和处理规则方案档案",TableName = "QCM_AQL",DBServer = "SysDbContext")]
    public partial class QCM_AQL:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid FID { get; set; }

       /// <summary>
       ///检验方案编码
       /// </summary>
       [Display(Name ="检验方案编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeCode { get; set; }

       /// <summary>
       ///检验方案名称
       /// </summary>
       [Display(Name ="检验方案名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeName { get; set; }

       /// <summary>
       ///检验方案描述
       /// </summary>
       [Display(Name ="检验方案描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FCheckSchemeDesc { get; set; }

       /// <summary>
       ///抽样处理规则方案编码
       /// </summary>
       [Display(Name ="抽样处理规则方案编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FSpot_CheckSchemeCode { get; set; }

       /// <summary>
       ///抽样处理规则方案名称
       /// </summary>
       [Display(Name ="抽样处理规则方案名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FSpot_CheckSchemeName { get; set; }

       /// <summary>
       ///抽样处理规则方案描述
       /// </summary>
       [Display(Name ="抽样处理规则方案描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FSpot_CheckSchemeDesc { get; set; }

       /// <summary>
       ///实收起始数量
       /// </summary>
       [Display(Name ="实收起始数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FPaid_UpStartQty { get; set; }

       /// <summary>
       ///实收起始数量
       /// </summary>
       [Display(Name ="实收起始数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FPaid_UpFinishQty { get; set; }

       /// <summary>
       ///样本数量
       /// </summary>
       [Display(Name ="样本数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FSampleQty { get; set; }

       /// <summary>
       ///判退数量
       /// </summary>
       [Display(Name ="判退数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FDismissalQty { get; set; }

       /// <summary>
       ///允收数量
       /// </summary>
       [Display(Name ="允收数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FAQLQty { get; set; }

       /// <summary>
       ///让步接收数量
       /// </summary>
       [Display(Name ="让步接收数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FADeviationQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DocStatus")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string DocStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AuditSteps")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string AuditSteps { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsSubmit")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string IsSubmit { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N01")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N01 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N02")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N03")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N03 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N04")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N04 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N05")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N05 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N06")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N06 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N07")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N07 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N08")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string N08 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string isDel { get; set; }

       
    }
}