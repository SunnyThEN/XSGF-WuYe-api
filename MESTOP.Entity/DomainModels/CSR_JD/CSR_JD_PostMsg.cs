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
    [Entity(TableCnName = "接口交互日志",TableName = "CSR_JD_PostMsg",DBServer = "TestDbContext")]
    public partial class CSR_JD_PostMsg:TestEntity
    {
        /// <summary>
       ///JDID
       /// </summary>
       [Key]
       [Display(Name ="JDID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid JDID { get; set; }

       /// <summary>
       ///posturl
       /// </summary>
       [Display(Name ="posturl")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string posturl { get; set; }

       /// <summary>
       ///postcontent
       /// </summary>
       [Display(Name ="postcontent")]
       [Column(TypeName="varchar(max)")]
       [Editable(true)]
       public string postcontent { get; set; }

       /// <summary>
       ///code
       /// </summary>
       [Display(Name ="code")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string code { get; set; }

       /// <summary>
       ///msg
       /// </summary>
       [Display(Name ="msg")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string msg { get; set; }

       /// <summary>
       ///taskNo
       /// </summary>
       [Display(Name ="taskNo")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string taskNo { get; set; }

       /// <summary>
       ///CreateDate
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///Creator
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///Modifier
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///ModifyDate
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///isDel
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       
    }
}