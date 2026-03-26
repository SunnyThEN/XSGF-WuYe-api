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
    [Entity(TableCnName = "编码规则生成器",TableName = "SYS_Codingrules",DBServer = "SysDbContext")]
    public partial class SYS_Codingrules:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///代码前缀
       /// </summary>
       [Display(Name ="代码前缀")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string prefixCode { get; set; }

       /// <summary>
       ///日期代码
       /// </summary>
       [Display(Name ="日期代码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string DateCode { get; set; }

       /// <summary>
       ///流水码长度
       /// </summary>
       [Display(Name ="流水码长度")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SerialNumber { get; set; }

       /// <summary>
       ///对应数据列
       /// </summary>
       [Display(Name ="对应数据列")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TableAction { get; set; }

       /// <summary>
       ///分隔符
       /// </summary>
       [Display(Name ="分隔符")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Separator { get; set; }

       /// <summary>
       ///对应表格名
       /// </summary>
       [Display(Name ="对应表格名")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TableActionType { get; set; }

       /// <summary>
       ///最后记录日期
       /// </summary>
       [Display(Name ="最后记录日期")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string LastDate { get; set; }

       /// <summary>
       ///最后记录的流水号
       /// </summary>
       [Display(Name ="最后记录的流水号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string LastNumber { get; set; }

       /// <summary>
       ///SQL语句
       /// </summary>
       [Display(Name ="SQL语句")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SQLString { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       
    }
}
