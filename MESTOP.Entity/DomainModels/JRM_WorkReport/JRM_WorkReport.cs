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
    [Entity(TableCnName = "工序追溯",TableName = "JRM_WorkReport",DBServer = "SysDbContext")]
    public partial class JRM_WorkReport:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="JRM_WRId")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid JRM_WRId { get; set; }

       /// <summary>
       ///子工单编码
       /// </summary>
       [Display(Name ="子工单编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WorkOrderCode { get; set; }

       /// <summary>
       ///工单需求数量
       /// </summary>
       [Display(Name ="工单需求数量")]
       [Column(TypeName="float")]
       [Editable(true)]
       public float? WORequiredQty { get; set; }

       /// <summary>
       ///在制品编码
       /// </summary>
       [Display(Name ="在制品编码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///在制品名称
       /// </summary>
       [Display(Name ="在制品名称")]
       [MaxLength(51)]
       [Column(TypeName="varchar(51)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///在制品追溯码
       /// </summary>
       [Display(Name ="在制品追溯码")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string TracingCode { get; set; }

       /// <summary>
       ///投入时间
       /// </summary>
       [Display(Name ="投入时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? TracingCodStartDate { get; set; }

       /// <summary>
       ///产出时间
       /// </summary>
       [Display(Name ="产出时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? TracingCodeEndDate { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string TracingCodeQty { get; set; }

       /// <summary>
       ///单位
       /// </summary>
       [Display(Name ="单位")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string TracingCodeUnit { get; set; }

       /// <summary>
       ///生产执行人员编码
       /// </summary>
       [Display(Name ="生产执行人员编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PeopleCode { get; set; }

       /// <summary>
       ///生产执行人名称
       /// </summary>
       [Display(Name ="生产执行人名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string PeopleName { get; set; }

       /// <summary>
       ///设备编码
       /// </summary>
       [Display(Name ="设备编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string EquipmentCode { get; set; }

       /// <summary>
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///设备描述
       /// </summary>
       [Display(Name ="设备描述")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string EquipmentDesc { get; set; }

       /// <summary>
       ///工序ID
       /// </summary>
       [Display(Name ="工序ID")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Process_Id { get; set; }

       /// <summary>
       ///工序名称
       /// </summary>
       [Display(Name ="工序名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessName { get; set; }

       /// <summary>
       ///工序描述
       /// </summary>
       [Display(Name ="工序描述")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessDesc { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WorkStationName { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///质量状态
       /// </summary>
       [Display(Name ="质量状态")]
       [Column(TypeName="int")]
       public int? qualityStatus { get; set; }

       /// <summary>
       ///X轴
       /// </summary>
       [Display(Name ="X轴")]
       [Column(TypeName="int")]
       public int? locationNoX { get; set; }

       /// <summary>
       ///Y轴
       /// </summary>
       [Display(Name ="Y轴")]
       [Column(TypeName="int")]
       public int? locationNoY { get; set; }

       /// <summary>
       ///数量
       /// </summary>
       [Display(Name ="数量")]
       [Column(TypeName="float")]
       public float? qty { get; set; }

       /// <summary>
       ///是否有料
       /// </summary>
       [Display(Name ="是否有料")]
       [Column(TypeName="int")]
       public int? IsMaterial { get; set; }

       /// <summary>
       ///质检方案编码
       /// </summary>
       [Display(Name ="质检方案编码")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       public string SIPSolutionCode { get; set; }

       /// <summary>
       ///检验方式
       /// </summary>
       [Display(Name ="检验方式")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string SIPMethod { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="XYOrderby")]
       [Column(TypeName="int")]
       public int? XYOrderby { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Plcstatus")]
       [Column(TypeName="int")]
       public int? Plcstatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="fromPort")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string fromPort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p1")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p2")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p3")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p3 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p4")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p4 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p5")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p5 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p6")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p6 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p7")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p7 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p8")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p8 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p9")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p9 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p10")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p10 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p11")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p11 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p12")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p12 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p13")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p13 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p14")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p14 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p15")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p15 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p16")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p16 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p17")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p17 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p18")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p18 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p19")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p19 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p20")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p20 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p21")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p21 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p22")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p22 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p23")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p23 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p24")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p24 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p25")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p25 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p26")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p26 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p27")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p27 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p28")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p28 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="p29")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string p29 { get; set; }

       /// <summary>
       ///工单状态
       /// </summary>
       [Display(Name ="工单状态")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string WOStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="sqlstatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? sqlstatus { get; set; }

       /// <summary>
       ///工序编码
       /// </summary>
       [Display(Name ="工序编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessCode { get; set; }

       /// <summary>
       ///工序流程档案编码
       /// </summary>
       [Display(Name ="工序流程档案编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ProcessFlowCode { get; set; }

       /// <summary>
       ///工位编码
       /// </summary>
       [Display(Name ="工位编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string WorkStationCode { get; set; }

       /// <summary>
       ///主工单编码
       /// </summary>
       [Display(Name ="主工单编码")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string ParentWorkOrderCode { get; set; }

       
    }
}