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
    [Entity(TableCnName = "物料规格",TableName = "CSR_JD_MaterialLenth",DBServer = "ServiceDbContext")]
    public partial class CSR_JD_MaterialLenth:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FLOTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLOTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_LENTH")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_LENTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_MANUFACTURER")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MANUFACTURER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_MATBATCHNO")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MATBATCHNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_WARRANTY")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_WARRANTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_STANDARD")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_STANDARD { get; set; }

       
    }
}