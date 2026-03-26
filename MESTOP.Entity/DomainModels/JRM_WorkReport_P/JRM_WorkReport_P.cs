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
    [Entity(TableCnName = "主物料追溯",TableName = "JRM_WorkReport_P",DBServer = "SysDbContext")]
    public partial class JRM_WorkReport_P:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="QId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int QId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WR_PId")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid JRM_WR_PId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="JRM_WRId")]
       [Column(TypeName="uniqueidentifier")]
       public Guid? JRM_WRId { get; set; }

       /// <summary>
       ///主物料编码
       /// </summary>
       [Display(Name ="主物料编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductCode { get; set; }

       /// <summary>
       ///主物料名称
       /// </summary>
       [Display(Name ="主物料名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProductName { get; set; }

       /// <summary>
       ///追溯码
       /// </summary>
       [Display(Name ="追溯码")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string ProcessCode { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string CreateID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改ID
       /// </summary>
       [Display(Name ="修改ID")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string ModifyID { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string WorkOrderCode { get; set; }

       
    }
}