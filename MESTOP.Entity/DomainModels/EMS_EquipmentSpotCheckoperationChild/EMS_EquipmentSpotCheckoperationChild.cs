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
    [Entity(TableCnName = "点检执行项目明细",TableName = "EMS_EquipmentSpotCheckoperationChild",DBServer = "SysDbContext")]
    public partial class EMS_EquipmentSpotCheckoperationChild:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ID { get; set; }

       /// <summary>
       ///项目方案编码
       /// </summary>
       [Display(Name ="项目方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckSolutionCode { get; set; }

       /// <summary>
       ///点检项目编码
       /// </summary>
       [Display(Name ="点检项目编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemCode { get; set; }

       /// <summary>
       ///点检项目名称
       /// </summary>
       [Display(Name ="点检项目名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SpotCheckItemName { get; set; }

       /// <summary>
       ///设备点检标准
       /// </summary>
       [Display(Name ="设备点检标准")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Spotcheckstandard { get; set; }

       /// <summary>
       ///设备点检频率
       /// </summary>
       [Display(Name ="设备点检频率")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string SpotcheckPeriod { get; set; }

       /// <summary>
       ///点检项目描述
       /// </summary>
       [Display(Name ="点检项目描述")]
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
       ///执行顺序
       /// </summary>
       [Display(Name ="执行顺序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Executionorder { get; set; }

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
       ///点检方案编码
       /// </summary>
       [Display(Name ="点检方案编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionNo { get; set; }

       /// <summary>
       ///点检方案名称
       /// </summary>
       [Display(Name ="点检方案名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ExecuterSkillSolutionName { get; set; }

       /// <summary>
       ///UOM控制
       /// </summary>
       [Display(Name ="UOM控制")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ControlUOM { get; set; }

       /// <summary>
       ///USL控制
       /// </summary>
       [Display(Name ="USL控制")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlUSL { get; set; }

       /// <summary>
       ///LSL控制
       /// </summary>
       [Display(Name ="LSL控制")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ControlLSL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ESCSolID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ESCSolID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IsSpotCheck")]
       [Column(TypeName="int")]
       public int? IsSpotCheck { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Expr1")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid Expr1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       
    }
}