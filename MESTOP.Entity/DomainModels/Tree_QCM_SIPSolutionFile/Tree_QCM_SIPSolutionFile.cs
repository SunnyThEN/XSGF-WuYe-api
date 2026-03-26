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
    [Entity(TableCnName = "自检方案树",TableName = "Tree_QCM_SIPSolutionFile",DBServer = "SysDbContext")]
    public partial class Tree_QCM_SIPSolutionFile:SysEntity
    {
        /// <summary>
       ///Id
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///TreeName
       /// </summary>
       [Display(Name ="TreeName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TreeName { get; set; }

       /// <summary>
       ///ParentId
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       
    }
}