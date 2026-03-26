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
    [Entity(TableCnName = "维修配件明细",TableName = "EMS_MaintainPaperList",DBServer = "SysDbContext")]
    public partial class EMS_MaintainPaperList:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="MaintainPaperListId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid MaintainPaperListId { get; set; }

       /// <summary>
       ///维修单主键
       /// </summary>
       [Display(Name ="维修单主键")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? MaintainPaperId { get; set; }

       /// <summary>
       ///配件编码
       /// </summary>
       [Display(Name ="配件编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string PartsCode { get; set; }

       /// <summary>
       ///配件名称
       /// </summary>
       [Display(Name ="配件名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string PartsName { get; set; }

       /// <summary>
       ///配件规格型号
       /// </summary>
       [Display(Name ="配件规格型号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string PartsSpecifications { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="OrgName")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string OrgName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string OrgCode { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [Column(TypeName="float")]
       public float? PartsNum { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string PartsUnit { get; set; }

       
    }
}