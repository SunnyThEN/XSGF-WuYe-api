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
    [Entity(TableCnName = "检验方案项目",TableName = "QCM_SIPSolutionItem",DBServer = "SysDbContext")]
    public partial class QCM_SIPSolutionItem:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ItemId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPSolutionId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPSolutionId { get; set; }

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
       ///检验类型编码
       /// </summary>
       [Display(Name ="检验类型编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeCode { get; set; }

       /// <summary>
       ///检验类型名称
       /// </summary>
       [Display(Name ="检验类型名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeName { get; set; }

       /// <summary>
       ///检验类型描述
       /// </summary>
       [Display(Name ="检验类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemTypeDesc { get; set; }

       /// <summary>
       ///USL
       /// </summary>
       [Display(Name ="USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUSL { get; set; }

       /// <summary>
       ///UCL
       /// </summary>
       [Display(Name ="UCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUCL { get; set; }

       /// <summary>
       ///SL
       /// </summary>
       [Display(Name ="SL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableSL { get; set; }

       /// <summary>
       ///CL
       /// </summary>
       [Display(Name ="CL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableCL { get; set; }

       /// <summary>
       ///LSL
       /// </summary>
       [Display(Name ="LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableLSL { get; set; }

       /// <summary>
       ///LCL
       /// </summary>
       [Display(Name ="LCL")]
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
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeCode { get; set; }

       /// <summary>
       ///检验工具类型名称
       /// </summary>
       [Display(Name ="检验工具类型名称")]
       [MaxLength(50)]
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
       ///
       /// </summary>
       [Display(Name ="ESOPADD")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ESOPADD { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ESIPADD")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
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
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

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
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DataStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? DataStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///检验方案编码
       /// </summary>
       [Display(Name ="检验方案编码")]
       [MaxLength(150)]
       [Column(TypeName="varchar(150)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///检验项目对应报工字段
       /// </summary>
       [Display(Name ="检验项目对应报工字段")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string QCMFiled { get; set; }

       
    }
}