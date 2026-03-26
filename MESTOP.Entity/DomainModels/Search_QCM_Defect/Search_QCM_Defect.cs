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
    [Entity(TableCnName = "不良查询",TableName = "Search_QCM_Defect",DBServer = "SysDbContext")]
    public partial class Search_QCM_Defect:SysEntity
    {
        /// <summary>
       ///不良编码
       /// </summary>
       [Display(Name ="不良编码")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string DefectCode { get; set; }

       /// <summary>
       ///不良名称
       /// </summary>
       [Display(Name ="不良名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string DefectName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="DefectId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int DefectId { get; set; }

       
    }
}