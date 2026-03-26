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
    [Entity(TableCnName = "点检执行项目保存",TableName = "EMS_ESCChild",DBServer = "SysDbContext")]
    public partial class EMS_ESCChild:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ItemID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ItemID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemCode")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemDesc")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SpotCheckItemDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemMaterialCode")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemMaterialName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemMaterialUOM")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemMaterialUOM { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemMaterialQty")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SpotCheckItemMaterialQty { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckMethodESOP")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SpotCheckMethodESOP { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemToolNo")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemToolNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotCheckItemToolName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemToolName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ExecuterSkillSolutionNo")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ExecuterSkillSolutionName")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ControlUOM")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ControlUOM { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ControlUSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlUSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ControlLSL")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlLSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SolID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? SolID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ItemCompleted")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ItemCompleted { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ESCSolID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ESCSolID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spotcheckstandard")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Spotcheckstandard { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SpotcheckPeriod")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string SpotcheckPeriod { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UnusualDesc")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string UnusualDesc { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ProcessInfo")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string ProcessInfo { get; set; }

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
