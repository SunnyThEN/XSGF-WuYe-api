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
    [Entity(TableCnName = "工序档案",TableName = "PPM_Prodprocess",DetailTable =  new Type[] { typeof(PPM_MetalWorkStation),typeof(PPM_UserInfo)},DetailTableCnName = "机组,角色",DBServer = "ServiceDbContext")]
    public partial class PPM_Prodprocess:ServiceEntity
    {
        /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序描述
       /// </summary>
       [Display(Name ="工序描述")]
       [MaxLength(3000)]
       [Column(TypeName="nvarchar(3000)")]
       [Editable(true)]
       public string ProcessDesc { get; set; }

       /// <summary>
       ///技能方案
       /// </summary>
       [Display(Name ="技能方案")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SkillSId { get; set; }

       /// <summary>
       ///理论值误差(%)
       /// </summary>
       [Display(Name ="理论值误差(%)")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Theoreticalvalue { get; set; }

       /// <summary>
       ///技能方案管控
       /// </summary>
       [Display(Name ="技能方案管控")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsSkillControl { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///工序步骤Id
       /// </summary>
       [Key]
       [Display(Name ="工序步骤Id")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid ProcessStepId { get; set; }

       [Display(Name ="机组")]
       [ForeignKey("ProcessStepId")]
       public List<PPM_MetalWorkStation> PPM_MetalWorkStation { get; set; }


       [Display(Name ="角色")]
       [ForeignKey("ProcessStepId")]
       public List<PPM_UserInfo> PPM_UserInfo { get; set; }


       
    }
}
