using Newtonsoft.Json;
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
    [Entity(TableCnName = "检验工具档案",TableName = "QCM_SIPToolFile",DBServer = "SysDbContext")]
    public partial class QCM_SIPToolFile:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="SIPToolId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid SIPToolId { get; set; }

       /// <summary>
       ///检验工具编码
       /// </summary>
       [Display(Name ="检验工具编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolCode { get; set; }

       /// <summary>
       ///检验工具名称
       /// </summary>
       [Display(Name ="检验工具名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolName { get; set; }

       /// <summary>
       ///检验工具描述
       /// </summary>
       [Display(Name ="检验工具描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPToolDesc { get; set; }

       /// <summary>
       ///检验工具类型编码
       /// </summary>
       [Display(Name ="检验工具类型编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeCode { get; set; }

       /// <summary>
       ///检验工具类型名称
       /// </summary>
       [Display(Name ="检验工具类型名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string SIPToolTypeName { get; set; }

       /// <summary>
       ///检验工具类型描述
       /// </summary>
       [Display(Name ="检验工具类型描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       [Editable(true)]
       public string SIPToolTypeDesc { get; set; }

       /// <summary>
       ///是否维保
       /// </summary>
       [Display(Name ="是否维保")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsMaintenance { get; set; }

       /// <summary>
       ///是否点检
       /// </summary>
       [Display(Name ="是否点检")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsSpotCheck { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="SIPToolKeyIds")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int SIPToolKeyIds { get; set; }

       /// <summary>
       ///主表主键
       /// </summary>
       [Display(Name ="主表主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int SIPID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       
    }
}
