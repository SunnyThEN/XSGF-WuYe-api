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
    [Entity(TableCnName = "退火工位",TableName = "JRM_FeedWorkStation",DetailTable =  new Type[] { typeof(JRM_FeedReport_Sub)},DetailTableCnName = "退火子项",DBServer = "ServiceDbContext")]
    public partial class JRM_FeedWorkStation:ServiceEntity
    {
        /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [Column(TypeName="float")]
       public float? WeightUnit { get; set; }

       /// <summary>
       ///件数
       /// </summary>
       [Display(Name ="件数")]
       [Column(TypeName="int")]
       public int? MaterialCount { get; set; }

       /// <summary>
       ///开炉时间
       /// </summary>
       [Display(Name ="开炉时间")]
       [Column(TypeName="datetime")]
       public DateTime? InFeedStartTime { get; set; }

       /// <summary>
       ///出炉时间
       /// </summary>
       [Display(Name ="出炉时间")]
       [Column(TypeName="datetime")]
       public DateTime? OutFeedEndTime { get; set; }

       /// <summary>
       ///开炉参与人
       /// </summary>
       [Display(Name ="开炉参与人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string InParticipants { get; set; }

       /// <summary>
       ///出炉参与人
       /// </summary>
       [Display(Name ="出炉参与人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string OutParticipants { get; set; }

       /// <summary>
       ///开炉班组
       /// </summary>
       [Display(Name ="开炉班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string InTeamGroup { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FeedId")]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid FeedId { get; set; }

       /// <summary>
       ///出炉班组
       /// </summary>
       [Display(Name ="出炉班组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string OutTeamGroup { get; set; }

       /// <summary>
       ///吊盖时间
       /// </summary>
       [Display(Name ="吊盖时间")]
       [Column(TypeName="datetime")]
       public DateTime? CoverTime { get; set; }

       /// <summary>
       ///报工状态
       /// </summary>
       [Display(Name ="报工状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       public string FeedStatus { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       public int? Sort { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string ProcessName { get; set; }

       [Display(Name ="退火子项")]
       [ForeignKey("FeedId")]
       public List<JRM_FeedReport_Sub> JRM_FeedReport_Sub { get; set; }


       
    }
}