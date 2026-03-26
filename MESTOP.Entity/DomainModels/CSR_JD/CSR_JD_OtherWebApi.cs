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
    [Entity(TableCnName = "接口管理",TableName = "CSR_JD_OtherWebApi",DBServer = "TestDbContext")]
    public partial class CSR_JD_OtherWebApi:TestEntity
    {
        /// <summary>
       ///接口名称(Name)
       /// </summary>
       [Display(Name ="接口名称(Name)")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string APPName { get; set; }

       /// <summary>
       ///密匙(AppSec)
       /// </summary>
       [Display(Name ="密匙(AppSec)")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string AppSec { get; set; }

       /// <summary>
       ///延时
       /// </summary>
       [Display(Name ="延时")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? delaytime { get; set; }

       /// <summary>
       ///是否在用
       /// </summary>
       [Display(Name ="是否在用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isUsed { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid JDID { get; set; }

       /// <summary>
       ///是否删除
       /// </summary>
       [Display(Name ="是否删除")]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       /// <summary>
       ///Creator
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Creator { get; set; }

       /// <summary>
       ///Modifier
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Modifier { get; set; }

       /// <summary>
       ///CreateDate
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///ModifyDate
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///数据中心标识(AcctID)
       /// </summary>
       [Display(Name ="数据中心标识(AcctID)")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CloudDbId { get; set; }

       /// <summary>
       ///用户(UserName)
       /// </summary>
       [Display(Name ="用户(UserName)")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string CloudUser { get; set; }

       /// <summary>
       ///应用ID(AppID)
       /// </summary>
       [Display(Name ="应用ID(AppID)")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string ApiAppId { get; set; }

       /// <summary>
       ///语言(LCID）
       /// </summary>
       [Display(Name ="语言(LCID）")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Language { get; set; }

       /// <summary>
       ///接口地址(ServerUrl)
       /// </summary>
       [Display(Name ="接口地址(ServerUrl)")]
       [MaxLength(250)]
       [Column(TypeName="varchar(250)")]
       [Editable(true)]
       public string CloudUrl { get; set; }

       
    }
}