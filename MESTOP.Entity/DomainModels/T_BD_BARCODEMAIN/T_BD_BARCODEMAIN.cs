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
    [Entity(TableCnName = "条码主档",TableName = "T_BD_BARCODEMAIN",DBServer = "TestDbContext")]
    public partial class T_BD_BARCODEMAIN:TestEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="FID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMASTERID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FMASTERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBARCODERULE")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBARCODERULE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FNUMBER")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBARCODE")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBARCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBARCODEMODEL")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBARCODEMODEL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMATERIALID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMATERIALID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAUXPROPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FAUXPROPID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSERIALNO")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSERIALNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDOCUMENTSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDOCUMENTSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDSTATUS")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FFORBIDSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOMID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBOMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FTRACKINGNUMBER")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FTRACKINGNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATORID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FCREATORID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATEDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime FCREATEDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMODIFIERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMODIFIERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMODIFYDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FMODIFYDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLASTPRINTUSERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLASTPRINTUSERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLASTPRINTDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FLASTPRINTDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRINTCOUNT")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPRINTCOUNT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRINTNUMBER")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPRINTNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDUSERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FFORBIDUSERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORBIDDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FFORBIDDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCREATEORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FCREATEORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRICE")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FPRICE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAMOUNT")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FAMOUNT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLCODE")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBILLCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBILLSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRODUCTIONDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FPRODUCTIONDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FSTOCKDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FKEEPINGDAY")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FKEEPINGDAY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FEXPIRATIONDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FEXPIRATIONDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAUXILIARYUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FAUXILIARYUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FAUXILIARYQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FAUXILIARYQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLTYPE")]
       [MaxLength(36)]
       [Column(TypeName="nvarchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBILLTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCUSTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FCUSTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLIERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSUPPLIERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDEPTID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FDEPTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBUSINESSMANID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBUSINESSMANID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEUNITID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBASEUNITID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBASEQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUPPLIERLOT")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSUPPLIERLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLOT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKLOCID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKLOCID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOT_TEXT")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FLOT_TEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBILLDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FBILLDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPURCHASERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPURCHASERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSALERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSALERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPLANERID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPLANERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSPECTORID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FINSPECTORID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEDATATYPE")]
       [MaxLength(36)]
       [Column(TypeName="varchar(36)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBASEDATATYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEDATANO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBASEDATANO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEDATANAME")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBASEDATANAME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FREMARK")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FREMARK { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBUSINESSORGID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FBUSINESSORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBASEDATAID")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBASEDATAID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBARCODEINVSTATUS")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBARCODEINVSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOUTQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FOUTQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWTCARDNUMBER")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FWTCARDNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWTASSETNUMBER")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FWTASSETNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWTPLACE")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FWTPLACE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FWTINITCHECKER")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FWTINITCHECKER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMONUMBER")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMONUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMOENTRYSEQ")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FMOENTRYSEQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPERNUMBER")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FOPERNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSEQNUMBER")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSEQNUMBER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRINTID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPRINTID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOXQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBOXQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPACKINGSTATUS")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPACKINGSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPERDESCRIPTION")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FOPERDESCRIPTION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FQUAQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FQUAQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSECURITYCODE")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSECURITYCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FASSETNAME")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FASSETNAME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FASTSPECIFICATION")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FASTSPECIFICATION { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FASSETTYPEID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FASSETTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FASSETSTATUSID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FASSETSTATUSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPACKAGEBARCODE")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPACKAGEBARCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBOXCAPACITY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FBOXCAPACITY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTALLEDQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FINSTALLEDQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDETAILBILLCODE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FDETAILBILLCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCHECKSTATUS")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCHECKSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSERIALNOSTR")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSERIALNOSTR { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCUSTOMERBARCODE")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCUSTOMERBARCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FTAREWEIGHT")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FTAREWEIGHT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FGROSSWEIGHT")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FGROSSWEIGHT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMANUFACTURER")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMANUFACTURER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMADEIN")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMADEIN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FRANDOMCODE")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FRANDOMCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRINTQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FPRINTQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOWNERID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FOWNERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOWNERTYPEID")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FOWNERTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FKEEPERTYPEID")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FKEEPERTYPEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FKEEPERID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FKEEPERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FFORMID")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FFORMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FBARCODETYPE")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FBARCODETYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPARENTBARCODE")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPARENTBARCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCONTROLNUM")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCONTROLNUM { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSN")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FIMEI1")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FIMEI1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FIMEI2")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FIMEI2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMEID")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FMEID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_UN_PACKETS")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal F_UN_PACKETS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FMINPACKQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FMINPACKQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALTERID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FALTERID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOCRATIO")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FALLOCRATIO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOCBEGINDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FALLOCBEGINDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOCENDDATE")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FALLOCENDDATE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FALLOCCOSTITEMID")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FALLOCCOSTITEMID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOWNO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FLOWNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSHORTFLOWNO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSHORTFLOWNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPROCESSID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPROCESSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOUTERBOXBARCODE")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FOUTERBOXBARCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FGUIDCODE")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FGUIDCODE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPACKLEVEL")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FPACKLEVEL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FISLASTBOX")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FISLASTBOX { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSRCCHANNEL")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSRCCHANNEL { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FDETAILCOUNT")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FDETAILCOUNT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUMDETAILQTY")]
       [Column(TypeName="numeric")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal FSUMDETAILQTY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FOPBILLNO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FOPBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSCANNING")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FSCANNING { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLASTSCANNER")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FLASTSCANNER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLASTSCANTIME")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FLASTSCANTIME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FLOTTEXT")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string FLOTTEXT { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKGROUPID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKGROUPID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPRINTPK")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long FPRINTPK { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKSTATUSID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FSTOCKSTATUSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FPCPACKBILLNO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FPCPACKBILLNO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKSTATUSID")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FINSTOCKSTATUSID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FCONTAINERSTATUS")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FCONTAINERSTATUS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FH_PASF_FCPZJ")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string FH_PASF_FCPZJ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FH_PASF_FSCRQ")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? FH_PASF_FSCRQ { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FH_PASF_FJYY")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int FH_PASF_FJYY { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FINSTOCKID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int FINSTOCKID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKOUTORGID")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string FSTOCKOUTORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSTOCKINORGID")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string FSTOCKINORGID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FTRANSFERBIZTYPE")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string FTRANSFERBIZTYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUMKTYKG")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal FSUMKTYKG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="FSUMQTYKG")]
       [Column(TypeName="numeric")]
       [Required(AllowEmptyStrings=false)]
       public decimal FSUMQTYKG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_LENTH")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_LENTH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_PACKED")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_PACKED { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_MESMO")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_MESMO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="F_PASF_BADCAUSE")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Required(AllowEmptyStrings=false)]
       public string F_PASF_BADCAUSE { get; set; }

       
    }
}