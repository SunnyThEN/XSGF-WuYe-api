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
    [Entity(TableCnName = "数据备份",TableName = "PMS_DataBackup",DBServer = "SysDbContext")]
    public partial class PMS_DataBackup:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///文件地址
       /// </summary>
       [Display(Name ="文件地址")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string FilePath { get; set; }

       /// <summary>
       ///文件名
       /// </summary>
       [Display(Name ="文件名")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string FileName { get; set; }

       /// <summary>
       ///文件大小
       /// </summary>
       [Display(Name ="文件大小")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string FileSize { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///描述
       /// </summary>
       [Display(Name ="描述")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string bkDesc { get; set; }

       /// <summary>
       ///附件
       /// </summary>
       [Display(Name ="附件")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       public string attachment { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PId { get; set; }

       
    }
}
