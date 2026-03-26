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
    [Entity(TableCnName = "项目配置",TableName = "PMS_ItemPath",DBServer = "SysDbContext")]
    public partial class PMS_ItemPath:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int DisposeID { get; set; }

       /// <summary>
       ///主项目ID
       /// </summary>
       [Display(Name ="主项目ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PId { get; set; }

       /// <summary>
       ///项目内容
       /// </summary>
       [Display(Name ="项目内容")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ItemName { get; set; }

       /// <summary>
       ///项目类型
       /// </summary>
       [Display(Name ="项目类型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Itemtype { get; set; }

       /// <summary>
       ///服务器打包路径
       /// </summary>
       [Display(Name ="服务器打包路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string DecomPath { get; set; }

       /// <summary>
       ///服务器下载路径
       /// </summary>
       [Display(Name ="服务器下载路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string UploadPath { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///本地解压路径
       /// </summary>
       [Display(Name ="本地解压路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Localunzip { get; set; }

       /// <summary>
       ///本地打包路径
       /// </summary>
       [Display(Name ="本地打包路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Localzip { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="int")]
       public int? ParentId { get; set; }

       /// <summary>
       ///可访问用户
       /// </summary>
       [Display(Name ="可访问用户")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string ItemUser { get; set; }

       
    }
}
