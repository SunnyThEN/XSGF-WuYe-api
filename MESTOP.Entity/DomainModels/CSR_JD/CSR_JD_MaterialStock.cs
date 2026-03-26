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
    [Entity(TableCnName = "库位物料明细",TableName = "CSR_JD_MaterialStock",DBServer = "TestDbContext")]
    public partial class CSR_JD_MaterialStock:TestEntity
    {
        /// <summary>
       ///库位ID
       /// </summary>
       [Display(Name ="库位ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKID { get; set; }

       /// <summary>
       ///库位名称
       /// </summary>
       [Display(Name ="库位名称")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FNAME { get; set; }

       /// <summary>
       ///库位编码
       /// </summary>
       [Display(Name ="库位编码")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FNUMBER { get; set; }

       /// <summary>
       ///组织ID
       /// </summary>
       [Display(Name ="组织ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUSEORGID { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMATERIALID { get; set; }

       /// <summary>
       ///子项ID
       /// </summary>
       [Key]
       [Display(Name ="子项ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string MaterialCode { get; set; }

       
    }
}