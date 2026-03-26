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
    [Entity(TableCnName = "生产组织管理",TableName = "CSR_JD_Organization",DBServer = "TestDbContext")]
    public partial class CSR_JD_Organization:TestEntity
    {
        /// <summary>
       ///组织ID
       /// </summary>
       [Key]
       [Display(Name ="组织ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int OrgId { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgName { get; set; }

       /// <summary>
       ///组织编码
       /// </summary>
       [Display(Name ="组织编码")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string OrgCode { get; set; }

       /// <summary>
       ///上级组织
       /// </summary>
       [Display(Name ="上级组织")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       
    }
}