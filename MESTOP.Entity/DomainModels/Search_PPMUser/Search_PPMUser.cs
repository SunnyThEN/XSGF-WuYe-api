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
    [Entity(TableCnName = "人员查询",TableName = "Search_PPMUser",DBServer = "SysDbContext")]
    public partial class Search_PPMUser:SysEntity
    {
        /// <summary>
       ///用户ID
       /// </summary>
       [Key]
       [Display(Name ="用户ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int User_Id { get; set; }

       /// <summary>
       ///角色名
       /// </summary>
       [Display(Name ="角色名")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string RoleName { get; set; }

       /// <summary>
       ///用户名
       /// </summary>
       [Display(Name ="用户名")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string UserName { get; set; }

       /// <summary>
       ///真实姓名
       /// </summary>
       [Display(Name ="真实姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string UserTrueName { get; set; }

       /// <summary>
       ///组织名称
       /// </summary>
       [Display(Name ="组织名称")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string OrgName { get; set; }

       
    }
}