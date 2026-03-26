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
    [Entity(TableCnName = "生产组织",TableName = "ORG_Organization",DBServer = "ServiceDbContext")]
    public partial class ORG_Organization:ServiceEntity
    {
        /// <summary>
       ///组织ID
       /// </summary>
       [Key]
       [Display(Name ="组织ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid OrgId { get; set; }

       /// <summary>
       ///生产组织编码
       /// </summary>
       [Display(Name ="生产组织编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string OrgCode { get; set; }

       /// <summary>
       ///生产组织名称
       /// </summary>
       [Display(Name ="生产组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string OrgName { get; set; }

       /// <summary>
       ///上级生产组织
       /// </summary>
       [Display(Name ="上级生产组织")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? ParentId { get; set; }

       /// <summary>
       ///上级组织名称
       /// </summary>
       [Display(Name ="上级组织名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentName { get; set; }

       /// <summary>
       ///是否禁用
       /// </summary>
       [Display(Name ="是否禁用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsDel { get; set; }

       /// <summary>
       ///生产组织类型
       /// </summary>
       [Display(Name ="生产组织类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgType { get; set; }

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

       
    }
}