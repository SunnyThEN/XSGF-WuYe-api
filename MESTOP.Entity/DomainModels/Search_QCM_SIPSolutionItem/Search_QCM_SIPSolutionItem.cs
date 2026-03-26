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
    [Entity(TableCnName = "检验项目检索",TableName = "Search_QCM_SIPSolutionItem",DBServer = "SysDbContext")]
    public partial class Search_QCM_SIPSolutionItem:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int SIPKeyId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPTypeKeyIds")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPTypeKeyIds { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="SIPItemDescOK")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescOK { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemDescDead")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescDead { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemDescMajor")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescMajor { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemDescSimple")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPItemDescSimple { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableUSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableUCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableUCL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableCL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableCL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableLSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SIPQuantitableLSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPQuantitableLCL")]
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
       ///
       /// </summary>
       [Display(Name ="SIPToolTypeCode")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPToolTypeName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPToolTypeDesc")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPToolTypeDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ESOPADD")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ESOPADD { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ESIPADD")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ESIPADD { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
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
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyTime")]
       [Column(TypeName="smalldatetime")]
       [Editable(true)]
       public DateTime? ModifyTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

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
       ///产出品工艺
       /// </summary>
       [Display(Name ="产出品工艺")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? WorkFlow_Id { get; set; }

       
    }
}