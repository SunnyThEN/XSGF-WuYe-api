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
    [Entity(TableCnName = "设备查询",TableName = "Search_EMS_Equipment",DBServer = "SysDbContext")]
    public partial class Search_EMS_Equipment:SysEntity
    {
        /// <summary>
       ///设备ID
       /// </summary>
       [Key]
       [Display(Name ="设备ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid EId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ETId")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ETId { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///设备描述
       /// </summary>
       [Display(Name ="设备描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string EquipmentDesc { get; set; }

       /// <summary>
       ///设备类型编码
       /// </summary>
       [Display(Name ="设备类型编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentTypeCode { get; set; }

       /// <summary>
       ///设备类型名称
       /// </summary>
       [Display(Name ="设备类型名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EquipmentTypeName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? isDel { get; set; }

       
    }
}
