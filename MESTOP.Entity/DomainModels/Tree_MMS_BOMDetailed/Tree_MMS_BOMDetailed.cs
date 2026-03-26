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
    [Entity(TableCnName = "BOM树",TableName = "Tree_MMS_BOMDetailed",DBServer = "SysDbContext")]
    public partial class Tree_MMS_BOMDetailed:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="Id")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TreeName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TreeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PBOMMaterialCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PBOMMaterialCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="BOMId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int BOMId { get; set; }

       
    }
}