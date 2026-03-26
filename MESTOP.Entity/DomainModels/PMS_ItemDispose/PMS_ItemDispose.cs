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
    [Entity(TableCnName = "版本管理",TableName = "PMS_ItemDispose",DBServer = "SysDbContext")]
    public partial class PMS_ItemDispose:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ItemID { get; set; }

       /// <summary>
       ///子项目名称
       /// </summary>
       [Display(Name ="子项目名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemName { get; set; }

       /// <summary>
       ///子项目路径
       /// </summary>
       [Display(Name ="子项目路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemEng { get; set; }

       /// <summary>
       ///子项目名
       /// </summary>
       [Display(Name ="子项目名")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string VerItemName { get; set; }

       /// <summary>
       ///项目类型
       /// </summary>
       [Display(Name ="项目类型")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string Itemtype { get; set; }

       /// <summary>
       ///子项目英文
       /// </summary>
       [Display(Name ="子项目英文")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string VerItemEng { get; set; }

       /// <summary>
       ///项目路径
       /// </summary>
       [Display(Name ="项目路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemFullPath { get; set; }

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
       ///上级项目
       /// </summary>
       [Display(Name ="上级项目")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? parentId { get; set; }

       /// <summary>
       ///解压路径
       /// </summary>
       [Display(Name ="解压路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string DecomPath { get; set; }

       /// <summary>
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PId { get; set; }

       /// <summary>
       ///使用用户
       /// </summary>
       [Display(Name ="使用用户")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string ItemUser { get; set; }

       
    }
}
