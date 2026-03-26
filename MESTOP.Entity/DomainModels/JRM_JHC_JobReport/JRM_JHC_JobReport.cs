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
    [Entity(TableCnName = "报工记录（JHC）",TableName = "JRM_JHC_JobReport",DBServer = "SysDbContext")]
    public partial class JRM_JHC_JobReport:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///单件追溯码
       /// </summary>
       [Display(Name ="单件追溯码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///测试项目
       /// </summary>
       [Display(Name ="测试项目")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TestProject { get; set; }

       /// <summary>
       ///测试值
       /// </summary>
       [Display(Name ="测试值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TestValue { get; set; }

       /// <summary>
       ///测试时间
       /// </summary>
       [Display(Name ="测试时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? TestTime { get; set; }

       /// <summary>
       ///USL
       /// </summary>
       [Display(Name ="USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? USL { get; set; }

       /// <summary>
       ///LSL
       /// </summary>
       [Display(Name ="LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? LSL { get; set; }

       /// <summary>
       ///质量状态
       /// </summary>
       [Display(Name ="质量状态")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

       /// <summary>
       ///标记
       /// </summary>
       [Display(Name ="标记")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? label { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string WorkStationCode { get; set; }

       
    }
}