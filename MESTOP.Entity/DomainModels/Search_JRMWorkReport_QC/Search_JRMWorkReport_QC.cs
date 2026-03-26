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
    [Entity(TableCnName = "工艺数据查询",TableName = "Search_JRMWorkReport_QC",DBServer = "SysDbContext")]
    public partial class Search_JRMWorkReport_QC:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="JRM_WR_QId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid JRM_WR_QId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WRId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? JRM_WRId { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///产出品编码
       /// </summary>
       [Display(Name ="产出品编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///产出名称
       /// </summary>
       [Display(Name ="产出名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///质量状态
       /// </summary>
       [Display(Name ="质量状态")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string QualityStatus { get; set; }

       /// <summary>
       ///自检方案
       /// </summary>
       [Display(Name ="自检方案")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///自检编码
       /// </summary>
       [Display(Name ="自检编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SIPItemCode { get; set; }

       /// <summary>
       ///自检项目名称
       /// </summary>
       [Display(Name ="自检项目名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SIPItemName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemDesc")]
       [MaxLength(2000)]
       [Column(TypeName="varchar(2000)")]
       [Editable(true)]
       public string SIPItemDesc { get; set; }

       /// <summary>
       ///自检项目类型编码
       /// </summary>
       [Display(Name ="自检项目类型编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SIPItemTypeCode { get; set; }

       /// <summary>
       ///自检项目类型名称
       /// </summary>
       [Display(Name ="自检项目类型名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string SIPItemTypeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemTypeDesc")]
       [MaxLength(2000)]
       [Column(TypeName="varchar(2000)")]
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
       ///SL
       /// </summary>
       [Display(Name ="SL")]
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
       ///
       /// </summary>
       [Display(Name ="IsQCIPQC")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsQCIPQC { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsQCOQC")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsQCOQC { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
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
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PEPICAttached")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PEPICAttached { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PEMovieAttached")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PEMovieAttached { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///值
       /// </summary>
       [Display(Name ="值")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPValue { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPToolTypeCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SIPToolTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SIPItemId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemMethod")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SIPItemMethod { get; set; }

       
    }
}