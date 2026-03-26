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
    [Entity(TableCnName = "料点档案",TableName = "PPM_Materiallocation",DBServer = "SysDbContext")]
    public partial class PPM_Materiallocation:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="PointId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid PointId { get; set; }

       /// <summary>
       ///料点编码
       /// </summary>
       [Display(Name ="料点编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialPointCode { get; set; }

       /// <summary>
       ///料点名称
       /// </summary>
       [Display(Name ="料点名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string MaterialPointName { get; set; }

       /// <summary>
       ///料点描述
       /// </summary>
       [Display(Name ="料点描述")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string MaterialPointDesc { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///是否投入料点 
       /// </summary>
       [Display(Name ="是否投入料点 ")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsInputMaterialPoint { get; set; }

       /// <summary>
       ///是否自动呼叫投入物料
       /// </summary>
       [Display(Name ="是否自动呼叫投入物料")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsAutoCallInputMaterial { get; set; }

       /// <summary>
       ///是否产出料点
       /// </summary>
       [Display(Name ="是否产出料点")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsOutputMaterialPoint { get; set; }

       /// <summary>
       ///是否自动呼叫移走物料
       /// </summary>
       [Display(Name ="是否自动呼叫移走物料")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsAutoCalloutputMaterial { get; set; }

       /// <summary>
       ///是否RFID读写器确认物料就位信号
       /// </summary>
       [Display(Name ="是否RFID读写器确认物料就位信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsRFIDReader { get; set; }

       /// <summary>
       ///物流管控设备编码
       /// </summary>
       [Display(Name ="物流管控设备编码")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string LogisticsEquipmentCode { get; set; }

       /// <summary>
       ///物流管控设备名称
       /// </summary>
       [Display(Name ="物流管控设备名称")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string LogisticsEquipmentName { get; set; }

       /// <summary>
       ///RFID读写器IP地址
       /// </summary>
       [Display(Name ="RFID读写器IP地址")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string RFIDReaderIPAddr { get; set; }

       /// <summary>
       ///是否条码读写器确认物料就位信号
       /// </summary>
       [Display(Name ="是否条码读写器确认物料就位信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsBarCodeReaderCheckSignal { get; set; }

       /// <summary>
       ///条码读写器IP地址
       /// </summary>
       [Display(Name ="条码读写器IP地址")]
       [MaxLength(50)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string BarcodeReaderIPAddr { get; set; }

       /// <summary>
       ///是否第三方系统确认物料就位信号
       /// </summary>
       [Display(Name ="是否第三方系统确认物料就位信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsThirdSystemCheckSignal { get; set; }

       /// <summary>
       ///第三方系统地址
       /// </summary>
       [Display(Name ="第三方系统地址")]
       [MaxLength(10)]
       [JsonIgnore]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string ThirdSystemapiAddr { get; set; }

       /// <summary>
       ///是否PLC确认物料就位信号
       /// </summary>
       [Display(Name ="是否PLC确认物料就位信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsPLCCheckSignal { get; set; }

       /// <summary>
       ///PLC品牌型号
       /// </summary>
       [Display(Name ="PLC品牌型号")]
       [MaxLength(250)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string PLCModel { get; set; }

       /// <summary>
       ///PLCIP地址
       /// </summary>
       [Display(Name ="PLCIP地址")]
       [MaxLength(250)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string PLCIPAddr { get; set; }

       /// <summary>
       ///PLCDB地址
       /// </summary>
       [Display(Name ="PLCDB地址")]
       [MaxLength(250)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string PLCDBAddr { get; set; }

       /// <summary>
       ///是否发送PLC物料就位信号
       /// </summary>
       [Display(Name ="是否发送PLC物料就位信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsIssuePLCSignal { get; set; }

       /// <summary>
       ///是否接受PLC物料可移走信号
       /// </summary>
       [Display(Name ="是否接受PLC物料可移走信号")]
       [JsonIgnore]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? IsGetPLCSignal { get; set; }

       /// <summary>
       ///是否可用
       /// </summary>
       [Display(Name ="是否可用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? IsAvailable { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

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
       ///
       /// </summary>
       [Display(Name ="isDel")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? isDel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="orderCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string orderCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="containerTypeCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string containerTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="vehicleTypeCode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string vehicleTypeCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr")]
       [Column(TypeName="int")]
       public int? Plcwr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr1")]
       [Column(TypeName="int")]
       public int? Plcwr1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr2")]
       [Column(TypeName="int")]
       public int? Plcwr2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr3")]
       [Column(TypeName="int")]
       public int? Plcwr3 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr4")]
       [Column(TypeName="int")]
       public int? Plcwr4 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr5")]
       [Column(TypeName="int")]
       public int? Plcwr5 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcwr6")]
       [Column(TypeName="int")]
       public int? Plcwr6 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="isEmpty")]
       [Column(TypeName="int")]
       public int? isEmpty { get; set; }

       
    }
}
