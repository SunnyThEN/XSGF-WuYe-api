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
    [Entity(TableCnName = "技能档案",TableName = "SIM_SkillFile",DBServer = "SysDbContext")]
    public partial class SIM_SkillFile:SysEntity
    {
        /// <summary>
       ///SkillId
       /// </summary>
       [Key]
       [Display(Name ="SkillId")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int SkillId { get; set; }

       /// <summary>
       ///技能名称
       /// </summary>
       [Display(Name ="技能名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SkillName { get; set; }

       /// <summary>
       ///SkillSId
       /// </summary>
       [Display(Name ="SkillSId")]
       [Column(TypeName="int")]
       public int? SkillSId { get; set; }

       /// <summary>
       ///技能编号
       /// </summary>
       [Display(Name ="技能编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SkillNo { get; set; }

       /// <summary>
       ///标准描述
       /// </summary>
       [Display(Name ="标准描述")]
       [MaxLength(16)]
       [Column(TypeName="text(16)")]
       [Editable(true)]
       public string SkillStandardDesc { get; set; }

       /// <summary>
       ///等级
       /// </summary>
       [Display(Name ="等级")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SkillLevel { get; set; }

       /// <summary>
       ///证书
       /// </summary>
       [Display(Name ="证书")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Certificate { get; set; }

       /// <summary>
       ///直通率USL
       /// </summary>
       [Display(Name ="直通率USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FPYUSL { get; set; }

       /// <summary>
       ///直通率LSL
       /// </summary>
       [Display(Name ="直通率LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? FPYLSL { get; set; }

       /// <summary>
       ///计划达成率 USL
       /// </summary>
       [Display(Name ="计划达成率 USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? PARUSL { get; set; }

       /// <summary>
       ///计划达成率 LSL
       /// </summary>
       [Display(Name ="计划达成率 LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? PARLSL { get; set; }

       /// <summary>
       ///稼动率USL
       /// </summary>
       [Display(Name ="稼动率USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ORUSL { get; set; }

       /// <summary>
       ///稼动率LSL
       /// </summary>
       [Display(Name ="稼动率LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ORLSL { get; set; }

       /// <summary>
       ///设备综合效率USL
       /// </summary>
       [Display(Name ="设备综合效率USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OEEUSL { get; set; }

       /// <summary>
       ///设备综合效率LSL
       /// </summary>
       [Display(Name ="设备综合效率LSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OEELSL { get; set; }

       /// <summary>
       ///人员综合效率USL
       /// </summary>
       [Display(Name ="人员综合效率USL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OPEUSL { get; set; }

       /// <summary>
       ///人员综合效率LS
       /// </summary>
       [Display(Name ="人员综合效率LS")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? OPELSL { get; set; }

       /// <summary>
       ///附件
       /// </summary>
       [Display(Name ="附件")]
       [MaxLength(16)]
       [Column(TypeName="text(16)")]
       [Editable(true)]
       public string AssociatedFile { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N01")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N01 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N02")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N02 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N03")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N03 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N04")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N04 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N05")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string N05 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N06")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N06 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N07")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N07 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="N08")]
       [MaxLength(100)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string N08 { get; set; }

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
