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
    [Entity(TableCnName = "巡检项",TableName = "QCM_SamplingIpcItem",DetailTable =  new Type[] { typeof(QCM_SamplingIpcTestItem)},DetailTableCnName = "巡检检测项",DBServer = "ServiceDbContext")]
    public partial class QCM_SamplingIpcItem:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="SampleId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? SampleId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SampleItemId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid SampleItemId { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProcessName { get; set; }

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
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///新卷号
       /// </summary>
       [Display(Name ="新卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///来料编码
       /// </summary>
       [Display(Name ="来料编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///来料名称
       /// </summary>
       [Display(Name ="来料名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///判定结果
       /// </summary>
       [Display(Name ="判定结果")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Result { get; set; }

       /// <summary>
       ///巡检单号
       /// </summary>
       [Display(Name ="巡检单号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string SampleCode { get; set; }

       /// <summary>
       ///检验人
       /// </summary>
       [Display(Name ="检验人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Inspectors { get; set; }

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

       [Display(Name ="巡检检测项")]
       [ForeignKey("SampleItemId")]
       public List<QCM_SamplingIpcTestItem> QCM_SamplingIpcTestItem { get; set; }


       
    }
}