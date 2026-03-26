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
    [Entity(TableCnName = "工艺追溯",TableName = "JRM_View_WorkReport_QC",DetailTableCnName = "CreateDate",DBServer = "SysDbContext")]
    public partial class JRM_View_WorkReport_QC:SysEntity
    {
        /// <summary>
       ///主物料编码
       /// </summary>
       [Display(Name ="主物料编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///主物料名称
       /// </summary>
       [Display(Name ="主物料名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
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
       ///检验方案编码
       /// </summary>
       [Display(Name ="检验方案编码")]
       [MaxLength(150)]
       [Column(TypeName="varchar(150)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="SIPItemTypeCode")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemTypeName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPItemTypeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPItemTypeDesc")]
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
       ///
       /// </summary>
       [Display(Name ="ItemId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ItemId { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///工艺值
       /// </summary>
       [Display(Name ="工艺值")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string SIPValue { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WR_QId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? JRM_WR_QId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string WorkOrderCode { get; set; }

       
    }
}