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
    [Entity(TableCnName = "退火报工",TableName = "JRM_FeedReport",DetailTable =  new Type[] { typeof(JRM_FeedReport_Sub)},DetailTableCnName = "退火子项",DBServer = "ServiceDbContext")]
    public partial class JRM_FeedReport:ServiceEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FeedId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid FeedId { get; set; }

       /// <summary>
       ///炉台编码
       /// </summary>
       [Display(Name ="炉台编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///炉台名称
       /// </summary>
       [Display(Name ="炉台名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///总重量
       /// </summary>
       [Display(Name ="总重量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///件数
       /// </summary>
       [Display(Name ="件数")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? MaterialCount { get; set; }

       /// <summary>
       ///进炉时间
       /// </summary>
       [Display(Name ="进炉时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? InFeedStartTime { get; set; }

       /// <summary>
       ///出炉时间
       /// </summary>
       [Display(Name ="出炉时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? OutFeedEndTime { get; set; }

       /// <summary>
       ///填炉参与人
       /// </summary>
       [Display(Name ="填炉参与人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string InParticipants { get; set; }

       /// <summary>
       ///出炉参与人
       /// </summary>
       [Display(Name ="出炉参与人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string OutParticipants { get; set; }

       /// <summary>
       ///填炉班组
       /// </summary>
       [Display(Name ="填炉班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string InTeamGroup { get; set; }

       /// <summary>
       ///出炉班组
       /// </summary>
       [Display(Name ="出炉班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OutTeamGroup { get; set; }

       /// <summary>
       ///吊外罩时间
       /// </summary>
       [Display(Name ="吊外罩时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CoverTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? PID { get; set; }

       /// <summary>
       ///报工状态
       /// </summary>
       [Display(Name ="报工状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string FeedStatus { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人编号
       /// </summary>
       [Display(Name ="创建人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人编号
       /// </summary>
       [Display(Name ="修改人编号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       [Display(Name ="退火子项")]
       [ForeignKey("FeedId")]
       public List<JRM_FeedReport_Sub> JRM_FeedReport_Sub { get; set; }


       
    }
}