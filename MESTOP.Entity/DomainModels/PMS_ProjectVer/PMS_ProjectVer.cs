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
    [Entity(TableCnName = "项目管理",TableName = "PMS_ProjectVer",DBServer = "SysDbContext")]
    public partial class PMS_ProjectVer:SysEntity
    {
        /// <summary>
       ///项目ID
       /// </summary>
       [Key]
       [Display(Name ="项目ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PId { get; set; }

       /// <summary>
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProjectName { get; set; }

       /// <summary>
       ///项目版本
       /// </summary>
       [Display(Name ="项目版本")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ProjectVersion { get; set; }

       /// <summary>
       ///计划开始
       /// </summary>
       [Display(Name ="计划开始")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanStartDate { get; set; }

       /// <summary>
       ///计划结束
       /// </summary>
       [Display(Name ="计划结束")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? PlanEndDate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
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
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///数据库名
       /// </summary>
       [Display(Name ="数据库名")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string sqldateName { get; set; }

       
    }
}
