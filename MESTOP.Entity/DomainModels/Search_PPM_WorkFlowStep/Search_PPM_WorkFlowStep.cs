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
    [Entity(TableCnName = "工序节点查询",TableName = "Search_PPM_WorkFlowStep",DBServer = "SysDbContext")]
    public partial class Search_PPM_WorkFlowStep:SysEntity
    {
        /// <summary>
       ///子工序流程名称
       /// </summary>
       [Display(Name ="子工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowName { get; set; }

       /// <summary>
       ///子工序流程编码
       /// </summary>
       [Display(Name ="子工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WorkStepFlow_Id { get; set; }

       /// <summary>
       ///工序流程顺序
       /// </summary>
       [Display(Name ="工序流程顺序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrderId { get; set; }

       /// <summary>
       ///主工序流程名称
       /// </summary>
       [Display(Name ="主工序流程名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Required(AllowEmptyStrings=false)]
       public string MainProcessFlowName { get; set; }

       /// <summary>
       ///主工序流程编码
       /// </summary>
       [Display(Name ="主工序流程编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string MainProcessFlowCode { get; set; }

       
    }
}