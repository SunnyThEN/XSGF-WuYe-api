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
    [Entity(TableCnName = "工序追溯",TableName = "JRM_View_WorkReport_PROC",DBServer = "SysDbContext")]
    public partial class JRM_View_WorkReport_PROC:SysEntity
    {
        /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序描述
       /// </summary>
       [Display(Name ="工序描述")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessDesc { get; set; }

       /// <summary>
       ///工序流程编码
       /// </summary>
       [Display(Name ="工序流程编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       /// <summary>
       ///工单编码
       /// </summary>
       [Display(Name ="工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WRId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid JRM_WRId { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///工序顺序
       /// </summary>
       [Display(Name ="工序顺序")]
       [Column(TypeName="int")]
       public int? OrderId { get; set; }

       
    }
}