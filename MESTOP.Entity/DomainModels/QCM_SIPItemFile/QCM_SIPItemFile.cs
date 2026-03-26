using Newtonsoft.Json;
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
    [Entity(TableCnName = "检验项目档案",TableName = "QCM_SIPItemFile",DBServer = "SysDbContext")]
    public partial class QCM_SIPItemFile:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? SIPId { get; set; }

       /// <summary>
       ///检验项目编码
       /// </summary>
       [Display(Name ="检验项目编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemCode { get; set; }

       /// <summary>
       ///检验项目名称
       /// </summary>
       [Display(Name ="检验项目名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemName { get; set; }

       /// <summary>
       ///检验项目描述
       /// </summary>
       [Display(Name ="检验项目描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDesc { get; set; }

       /// <summary>
       ///检验项目类型编码
       /// </summary>
       [Display(Name ="检验项目类型编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeCode { get; set; }

       /// <summary>
       ///检验项目类型名称
       /// </summary>
       [Display(Name ="检验项目类型名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeName { get; set; }

       /// <summary>
       ///检验项目类型描述
       /// </summary>
       [Display(Name ="检验项目类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemTypeDesc { get; set; }

       /// <summary>
       ///检验项目合格标准描述
       /// </summary>
       [Display(Name ="检验项目合格标准描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescOK { get; set; }

       /// <summary>
       ///检验项目致命异常描述
       /// </summary>
       [Display(Name ="检验项目致命异常描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescDead { get; set; }

       /// <summary>
       ///检验项目重大异常描述
       /// </summary>
       [Display(Name ="检验项目重大异常描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescMajor { get; set; }

       /// <summary>
       ///检验项目一般异常描述
       /// </summary>
       [Display(Name ="检验项目一般异常描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescSimple { get; set; }

       /// <summary>
       ///检验数值USL
       /// </summary>
       [Display(Name ="检验数值USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUSL { get; set; }

       /// <summary>
       ///检验数值UCL
       /// </summary>
       [Display(Name ="检验数值UCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUCL { get; set; }

       /// <summary>
       ///检验数值SL
       /// </summary>
       [Display(Name ="检验数值SL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableSL { get; set; }

       /// <summary>
       ///检验数值CL
       /// </summary>
       [Display(Name ="检验数值CL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableCL { get; set; }

       /// <summary>
       ///检验数值LSL
       /// </summary>
       [Display(Name ="检验数值LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableLSL { get; set; }

       /// <summary>
       ///检验数值LCL
       /// </summary>
       [Display(Name ="检验数值LCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableLCL { get; set; }

       /// <summary>
       ///检验工具编码
       /// </summary>
       [Display(Name ="检验工具编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolCode { get; set; }

       /// <summary>
       ///检验工具名称
       /// </summary>
       [Display(Name ="检验工具名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolName { get; set; }

       /// <summary>
       ///检验工具描述
       /// </summary>
       [Display(Name ="检验工具描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPToolDesc { get; set; }

       /// <summary>
       ///检验工具类型编码
       /// </summary>
       [Display(Name ="检验工具类型编码")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeCode { get; set; }

       /// <summary>
       ///检验工具类型名称
       /// </summary>
       [Display(Name ="检验工具类型名称")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeName { get; set; }

       /// <summary>
       ///检验工具类型描述
       /// </summary>
       [Display(Name ="检验工具类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPToolTypeDesc { get; set; }

       /// <summary>
       ///作业指导书存档地址
       /// </summary>
       [Display(Name ="作业指导书存档地址")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ESOPADD { get; set; }

       /// <summary>
       ///检验指导书存档地址
       /// </summary>
       [Display(Name ="检验指导书存档地址")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ESIPADD { get; set; }

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

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? DataStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SIPKeyId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int SIPKeyId { get; set; }

       /// <summary>
       ///主表主键
       /// </summary>
       [Display(Name ="主表主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPTypeKeyIds { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///产出品工艺
       /// </summary>
       [Display(Name ="产出品工艺")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? WorkFlow_Id { get; set; }

       
    }
}
