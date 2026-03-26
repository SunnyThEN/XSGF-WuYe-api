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
    [Entity(TableCnName = "物料类型",TableName = "MMS_MaterialType",DBServer = "SysDbContext")]
    public partial class MMS_MaterialType:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MTFId { get; set; }

       /// <summary>
       ///类型编码
       /// </summary>
       [Display(Name ="类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MaterialTypeCode { get; set; }

       /// <summary>
       ///类型名称
       /// </summary>
       [Display(Name ="类型名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialTypeName { get; set; }

       /// <summary>
       ///类型简码(SN)
       /// </summary>
       [Display(Name ="类型简码(SN)")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MTypeShortCode { get; set; }

       /// <summary>
       ///上级类型
       /// </summary>
       [Display(Name ="上级类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///类型描述
       /// </summary>
       [Display(Name ="类型描述")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Editable(true)]
       public string MaterialTypeDesc { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
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
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///密度系数（默认7.85）
       /// </summary>
       [Display(Name ="密度系数（默认7.85）")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? DensityValue { get; set; }

       
    }
}