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
    [Entity(TableCnName = "工厂日历方案",TableName = "FCM_Shift",DetailTable =  new Type[] { typeof(FCM_ShiftList)},DetailTableCnName = "班次明细",DBServer = "SysDbContext")]
    public partial class FCM_Shift:SysEntity
    {
        /// <summary>
       ///排版计划主键
       /// </summary>
       [Key]
       [Display(Name ="排版计划主键")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ShiftId { get; set; }

       /// <summary>
       ///计划名称
       /// </summary>
       [Display(Name ="计划名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ShiftName { get; set; }

       /// <summary>
       ///计划编码
       /// </summary>
       [Display(Name ="计划编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ShiftCode { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? StartDate { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? EndDate { get; set; }

       /// <summary>
       ///总工时
       /// </summary>
       [Display(Name ="总工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? TotalManHour { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string Status { get; set; }

       /// <summary>
       ///日工时
       /// </summary>
       [Display(Name ="日工时")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DayManHour { get; set; }

       /// <summary>
       ///节假天数
       /// </summary>
       [Display(Name ="节假天数")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? Hday { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string Remark { get; set; }

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

       /// <summary>
       ///班组类型
       /// </summary>
       [Display(Name ="班组类型")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TeamType { get; set; }

       /// <summary>
       ///轮班方式
       /// </summary>
       [Display(Name ="轮班方式")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ShiftType { get; set; }

       /// <summary>
       ///倒班方式
       /// </summary>
       [Display(Name ="倒班方式")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ChangeShiftType { get; set; }

       /// <summary>
       ///工作天数
       /// </summary>
       [Display(Name ="工作天数")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WDay { get; set; }

       [Display(Name ="班次明细")]
       [ForeignKey("ShiftId")]
       public List<FCM_ShiftList> FCM_ShiftList { get; set; }


       
    }
}