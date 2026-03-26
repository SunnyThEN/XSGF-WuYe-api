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
    [Entity(TableCnName = "机组档案",TableName = "ORG_WorkStation",DetailTable =  new Type[] { typeof(ORG_WorkUser)},DetailTableCnName = "操作人员",DBServer = "ServiceDbContext")]
    public partial class ORG_WorkStation:ServiceEntity
    {
        /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WorkStationId { get; set; }

       /// <summary>
       ///机组编号
       /// </summary>
       [Display(Name ="机组编号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///机组名称
       /// </summary>
       [Display(Name ="机组名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///机组描述
       /// </summary>
       [Display(Name ="机组描述")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string WorkStationDesc { get; set; }

       /// <summary>
       ///生产组织
       /// </summary>
       [Display(Name ="生产组织")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? OrgId { get; set; }

       /// <summary>
       ///ERP组织编码
       /// </summary>
       [Display(Name ="ERP组织编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OrgCode { get; set; }

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
       ///是否禁用
       /// </summary>
       [Display(Name ="是否禁用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsDel { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       public int? Sort { get; set; }

       [Display(Name ="操作人员")]
       [ForeignKey("WorkStationId")]
       public List<ORG_WorkUser> ORG_WorkUser { get; set; }


       
    }
}