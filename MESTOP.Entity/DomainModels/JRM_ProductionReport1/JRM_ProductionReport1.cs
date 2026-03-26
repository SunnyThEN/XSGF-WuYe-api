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
    [Entity(TableCnName = "生产计划汇总",TableName = "JRM_ProductionReport1",DBServer = "SysDbContext")]
    public partial class JRM_ProductionReport1:SysEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid Id { get; set; }

       /// <summary>
       ///部件工单实际生产量
       /// </summary>
       [Display(Name ="部件工单实际生产量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float BJProdQty { get; set; }

       /// <summary>
       ///部件工单计划需求量
       /// </summary>
       [Display(Name ="部件工单计划需求量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float BJPlanQty { get; set; }

       /// <summary>
       ///工单计划需求量
       /// </summary>
       [Display(Name ="工单计划需求量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WOPlanQty { get; set; }

       /// <summary>
       ///工单实际产量
       /// </summary>
       [Display(Name ="工单实际产量")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float WOProdQty { get; set; }

       /// <summary>
       ///月份
       /// </summary>
       [Display(Name ="月份")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MON { get; set; }

       
    }
}