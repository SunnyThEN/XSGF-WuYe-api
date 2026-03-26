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
    [Entity(TableCnName = "覆膜自检",TableName = "QCM_FMSelfReport",DBServer = "ServiceDbContext")]
    public partial class QCM_FMSelfReport:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ZJId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ZJId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ParentId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ParentId { get; set; }

       /// <summary>
       ///卷号
       /// </summary>
       [Display(Name ="卷号")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string NEWFLOT { get; set; }

       /// <summary>
       ///重量（kg）
       /// </summary>
       [Display(Name ="重量（kg）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///宽度（mm）
       /// </summary>
       [Display(Name ="宽度（mm）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WidthUnit { get; set; }

       /// <summary>
       ///厚度（mm）
       /// </summary>
       [Display(Name ="厚度（mm）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ThicknessUnit { get; set; }

       /// <summary>
       ///长度（m）
       /// </summary>
       [Display(Name ="长度（m）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? LengthUnit { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? Remark { get; set; }

       /// <summary>
       ///室温（℃）
       /// </summary>
       [Display(Name ="室温（℃）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? RoomTemp { get; set; }

       /// <summary>
       ///机台速度（m/min）
       /// </summary>
       [Display(Name ="机台速度（m/min）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? MacSpeed { get; set; }

       /// <summary>
       ///测张仪显示（kg）
       /// </summary>
       [Display(Name ="测张仪显示（kg）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? TensionTester { get; set; }

       /// <summary>
       ///设定张力
       /// </summary>
       [Display(Name ="设定张力")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? TensionSet { get; set; }

       /// <summary>
       ///钢带温度（℃）
       /// </summary>
       [Display(Name ="钢带温度（℃）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SteelTemp { get; set; }

       /// <summary>
       ///侧面温度（℃）
       /// </summary>
       [Display(Name ="侧面温度（℃）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SideTemp { get; set; }

       /// <summary>
       ///硬度（Mpa）
       /// </summary>
       [Display(Name ="硬度（Mpa）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? Hardness { get; set; }

       
    }
}