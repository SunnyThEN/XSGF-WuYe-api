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
    [Entity(TableCnName = "质检单搜索",TableName = "Search_QCM_SIPQCCPCheck",DBServer = "SysDbContext")]
    public partial class Search_QCM_SIPQCCPCheck:SysEntity
    {
        /// <summary>
       ///质检单类型编码
       /// </summary>
       [Display(Name ="质检单类型编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCChecklistTypeCode { get; set; }

       /// <summary>
       ///质检单类型名称
       /// </summary>
       [Display(Name ="质检单类型名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPQCChecklistTypeName { get; set; }

       /// <summary>
       ///质检单类型描述
       /// </summary>
       [Display(Name ="质检单类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPQCChecklistTypeDesc { get; set; }

       /// <summary>
       ///质检单方案档案编码
       /// </summary>
       [Display(Name ="质检单方案档案编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///质检单方案档案名称
       /// </summary>
       [Display(Name ="质检单方案档案名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionName { get; set; }

       /// <summary>
       ///质检单方案档案描述
       /// </summary>
       [Display(Name ="质检单方案档案描述")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string SIPSolutionDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SolutionFileID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid SolutionFileID { get; set; }

       
    }
}