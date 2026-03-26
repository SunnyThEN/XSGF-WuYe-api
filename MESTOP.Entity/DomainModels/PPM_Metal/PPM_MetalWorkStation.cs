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
    [Entity(TableCnName = "工序机组",TableName = "PPM_MetalWorkStation",DBServer = "ServiceDbContext")]
    public partial class PPM_MetalWorkStation:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="WorkStationId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid WorkStationId { get; set; }

       /// <summary>
       ///机组编码
       /// </summary>
       [Display(Name ="机组编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
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
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///工序步骤Id
       /// </summary>
       [Display(Name ="工序步骤Id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? ProcessStepId { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

       
    }
}