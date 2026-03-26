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
    [Entity(TableCnName = "生产订单入库信息视图",TableName = "CSR_JD_PRDMO",DBServer = "TestDbContext")]
    public partial class CSR_JD_PRDMO:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLNO")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FENTRYID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FENTRYID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMaterialID")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FMaterialID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FProductType")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string FProductType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FInStockType")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FInStockType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUnitID")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string FUnitID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDESCRIPTION")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FDESCRIPTION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISBACKFLUSH")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISBACKFLUSH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWorkShopId")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FWorkShopId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FIsOverLegalOrg")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FIsOverLegalOrg { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKOWNERID")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string FINSTOCKOWNERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMID")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Editable(true)]
       public string FBOMID { get; set; }

       
    }
}