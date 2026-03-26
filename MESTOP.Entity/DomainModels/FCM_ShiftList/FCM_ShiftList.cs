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
    [Entity(TableCnName = "工作日明细",TableName = "FCM_ShiftList",DBServer = "SysDbContext")]
    public partial class FCM_ShiftList:SysEntity
    {
        /// <summary>
       ///计划班次主键
       /// </summary>
       [Key]
       [Display(Name ="计划班次主键")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ShiftListId { get; set; }

       /// <summary>
       ///计划主键
       /// </summary>
       [Display(Name ="计划主键")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ShiftId { get; set; }

       /// <summary>
       ///显示顺序
       /// </summary>
       [Display(Name ="显示顺序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sequence { get; set; }

       /// <summary>
       ///班次名称
       /// </summary>
       [Display(Name ="班次名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PlanShiftName { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string StartTime { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string EndTime { get; set; }

       /// <summary>
       ///工时
       /// </summary>
       [Display(Name ="工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? ManHour { get; set; }

       /// <summary>
       ///创建人编号
       /// </summary>
       [Display(Name ="创建人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
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
       ///修改人编号
       /// </summary>
       [Display(Name ="修改人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       
    }
}