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
    [Entity(TableCnName = "物料类型",TableName = "CSR_JD_MaterialType",DBServer = "TestDbContext")]
    public partial class CSR_JD_MaterialType:TestEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int MTFId { get; set; }

       /// <summary>
       ///上级ID
       /// </summary>
       [Display(Name ="上级ID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? ParentId { get; set; }

       /// <summary>
       ///物料类型编码
       /// </summary>
       [Display(Name ="物料类型编码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string MaterialTypeCode { get; set; }

       /// <summary>
       ///物料类型名称
       /// </summary>
       [Display(Name ="物料类型名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string MaterialTypeName { get; set; }

       /// <summary>
       ///物料类型描述
       /// </summary>
       [Display(Name ="物料类型描述")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string MaterialTypeDesc { get; set; }

       
    }
}