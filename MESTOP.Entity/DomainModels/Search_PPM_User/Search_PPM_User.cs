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
    [Entity(TableCnName = "角色查询",TableName = "Search_PPM_User",DBServer = "ServiceDbContext")]
    public partial class Search_PPM_User:ServiceEntity
    {
        /// <summary>
       ///角色ID
       /// </summary>
       [Key]
       [Display(Name ="角色ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Role_Id { get; set; }

       /// <summary>
       ///角色名
       /// </summary>
       [Display(Name ="角色名")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string RoleName { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

       
    }
}