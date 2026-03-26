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
    [Entity(TableCnName = "工艺子项",TableName = "PPM_ProcessFlowChild",DBServer = "TestDbContext")]
    public partial class PPM_ProcessFlowChild:TestEntity
    {
        /// <summary>
       ///子项编码
       /// </summary>
       [Display(Name ="子项编码")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDATAVALUE { get; set; }

       /// <summary>
       ///子项描述
       /// </summary>
       [Display(Name ="子项描述")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDESCRIPTION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FID { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FMATERIALID { get; set; }

       /// <summary>
       ///客户
       /// </summary>
       [Display(Name ="客户")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string Customer { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string ProductName { get; set; }

       /// <summary>
       ///产品规格
       /// </summary>
       [Display(Name ="产品规格")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string FSPECIFICATION { get; set; }

       /// <summary>
       ///产品编码
       /// </summary>
       [Display(Name ="产品编码")]
       [MaxLength(80)]
       [Column(TypeName="nvarchar(80)")]
       [Required(AllowEmptyStrings=false)]
       public string ProductCode { get; set; }

       
    }
}