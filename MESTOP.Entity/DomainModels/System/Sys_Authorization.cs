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
    [Entity(TableCnName = "Sys_Authorization",TableName = "Sys_Authorization",DBServer = "SysDbContext")]
    public partial class Sys_Authorization:SysEntity
    {
        /// <summary>
       ///MAC地址
       /// </summary>
       [Display(Name ="MAC地址")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MACstr { get; set; }

       /// <summary>
       ///用户
       /// </summary>
       [Display(Name ="用户")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SYSstr { get; set; }

       /// <summary>
       ///企业
       /// </summary>
       [Display(Name ="企业")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Companystr { get; set; }

       /// <summary>
       ///编码
       /// </summary>
       [Display(Name ="编码")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string AZstr { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isOK { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       
    }
}