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
    [Entity(TableCnName = "物料管理",TableName = "CSR_JD_Material",DBServer = "TestDbContext")]
    public partial class CSR_JD_Material:TestEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MId { get; set; }

       /// <summary>
       ///物料类型ID
       /// </summary>
       [Display(Name ="物料类型ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MTFId { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? FMATERIALGROUP { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialCode { get; set; }

       /// <summary>
       ///物料短码
       /// </summary>
       [Display(Name ="物料短码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialShortNo { get; set; }

       /// <summary>
       ///物料描述
       /// </summary>
       [Display(Name ="物料描述")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string MaterialDesc { get; set; }

       /// <summary>
       ///物料单位编码
       /// </summary>
       [Display(Name ="物料单位编码")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MasterUOMCode { get; set; }

       /// <summary>
       ///物料单位
       /// </summary>
       [Display(Name ="物料单位")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string MasterUOM { get; set; }

       /// <summary>
       ///物料类型编码
       /// </summary>
       [Display(Name ="物料类型编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string MaterialTypeCode { get; set; }

       
    }
}