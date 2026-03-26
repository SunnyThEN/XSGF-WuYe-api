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
    [Entity(TableCnName = "职员",TableName = "CSR_JD_User",DBServer = "TestDbContext")]
    public partial class CSR_JD_User:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="UserTrueName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string UserTrueName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UserName")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string UserName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UserPwd")]
       [MaxLength(24)]
       [Column(TypeName="varchar(24)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string UserPwd { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       
    }
}