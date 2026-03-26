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
    [Entity(TableCnName = "申请单",TableName = "RMS_ApplicationForm",DBServer = "SysDbContext")]
    public partial class RMS_ApplicationForm:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ApplicationId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid ApplicationId { get; set; }

       /// <summary>
       ///申请单编号
       /// </summary>
       [Display(Name ="申请单编号")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ApplicationNumber { get; set; }

       /// <summary>
       ///申请单名称
       /// </summary>
       [Display(Name ="申请单名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ApplicationName { get; set; }

       /// <summary>
       ///申请人名称
       /// </summary>
       [Display(Name ="申请人名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ApplicantName { get; set; }

       /// <summary>
       ///申请类型
       /// </summary>
       [Display(Name ="申请类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ApplicationType { get; set; }

       /// <summary>
       ///申请备注
       /// </summary>
       [Display(Name ="申请备注")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string ApplicationDescription { get; set; }

       /// <summary>
       ///紧急程度
       /// </summary>
       [Display(Name ="紧急程度")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Urgency { get; set; }

       /// <summary>
       ///申请状态
       /// </summary>
       [Display(Name ="申请状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? AuditStatus { get; set; }

       /// <summary>
       ///起始时间
       /// </summary>
       [Display(Name ="起始时间")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? StartDate { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [Column(TypeName="date")]
       [Editable(true)]
       public DateTime? EndDate { get; set; }

       /// <summary>
       ///时长
       /// </summary>
       [Display(Name ="时长")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Duration { get; set; }

       /// <summary>
       ///金额
       /// </summary>
       [Display(Name ="金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? Amount { get; set; }

       /// <summary>
       ///附件
       /// </summary>
       [Display(Name ="附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Attachments { get; set; }

       /// <summary>
       ///结算金额
       /// </summary>
       [Display(Name ="结算金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? SettlementAmount { get; set; }

       /// <summary>
       ///验收附件
       /// </summary>
       [Display(Name ="验收附件")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string AcceptanceAnnex { get; set; }

       /// <summary>
       ///验收描述
       /// </summary>
       [Display(Name ="验收描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string AcceptanceRes { get; set; }

       
    }
}