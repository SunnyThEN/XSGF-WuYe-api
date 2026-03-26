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
    [Entity(TableCnName = "版本明细",TableName = "PMS_ItemVer",DBServer = "SysDbContext")]
    public partial class PMS_ItemVer:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="VerId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int VerId { get; set; }

       /// <summary>
       ///主项目表主键
       /// </summary>
       [Display(Name ="主项目表主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ItemID { get; set; }

       /// <summary>
       ///生成路径
       /// </summary>
       [Display(Name ="生成路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemPath { get; set; }

       /// <summary>
       ///更新日期
       /// </summary>
       [Display(Name ="更新日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///版本号
       /// </summary>
       [Display(Name ="版本号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ItemNo { get; set; }

       /// <summary>
       ///项目版本
       /// </summary>
       [Display(Name ="项目版本")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemEditionNo { get; set; }

       /// <summary>
       ///压缩包名
       /// </summary>
       [Display(Name ="压缩包名")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemEditionNoZip { get; set; }

       /// <summary>
       ///存放路径
       /// </summary>
       [Display(Name ="存放路径")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string UpLoadPath { get; set; }

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
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ItemName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///0未用1在用
       /// </summary>
       [Display(Name ="0未用1在用")]
       [MaxLength(1)]
       [JsonIgnore]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string IsUseEdition { get; set; }

       /// <summary>
       ///主项目英文
       /// </summary>
       [Display(Name ="主项目英文")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ItemEng { get; set; }

       /// <summary>
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? PId { get; set; }

       /// <summary>
       ///版本描述
       /// </summary>
       [Display(Name ="版本描述")]
       [MaxLength(16)]
       [Column(TypeName="ntext(16)")]
       [Editable(true)]
       public string ItemDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isVerOK")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isVerOK { get; set; }

       
    }
}
