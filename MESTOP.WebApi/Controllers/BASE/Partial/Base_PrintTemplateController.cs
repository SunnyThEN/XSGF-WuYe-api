/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Base_PrintTemplate",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using BASE.IServices;
using BASE.IRepositories;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
 
using MESTOP.Core.Utilities;
using MESTOP.Core.DBManager;
using System.Net;
using System.Text;
using MESTOP.Core.Extensions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.Drawing;
using System.DrawingCore;
using System.Security.Cryptography;

namespace BASE.Controllers
{
    public partial class Base_PrintTemplateController
    {
        private readonly IBase_PrintTemplateService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBase_PrintTemplateRepository _templateRepository;
        private readonly IBase_PrintCatalogRepository _templateCatalogRepository;

        [ActivatorUtilitiesConstructor]
        public Base_PrintTemplateController(
            IBase_PrintTemplateService service,
            IHttpContextAccessor httpContextAccessor,
            IBase_PrintTemplateRepository templateRepository,
            IBase_PrintCatalogRepository templateCatalogRepository
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _templateRepository = templateRepository;
            _templateCatalogRepository = templateCatalogRepository;
        }


        [Route("updateStatus"), HttpGet]
        [ApiActionPermission(ActionPermissionOptions.Update)]
        public IActionResult UpdateStatus(Guid templateId, int statusFlag)
        {
            var catalogId = _templateRepository.FindAsIQueryable(x => x.PrintTemplateId == templateId)
                              .Select(s => s.CatalogId)
                              .FirstOrDefault();
            var list = _templateRepository.FindAsIQueryable(x => x.StatusFlag == 1 && x.CatalogId == catalogId && x.PrintTemplateId != templateId)
                               .ToList();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].StatusFlag = 0;
            }
            _templateRepository.UpdateRange(list, true);
            Base_PrintTemplate printTemplate = new Base_PrintTemplate()
            {
                PrintTemplateId = templateId,
                StatusFlag = statusFlag
            };
            _templateRepository.Update(printTemplate, x => new { x.StatusFlag }, true);
            return Content("修改成功");
        }


        [HttpPost, HttpGet, Route("saveOrUpdateData"), AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        public IActionResult saveOrUpdateData(string stage, string id, string cat, string token)
        {
            PrintOutput print = new PrintOutput();
            if (!VerificationToken(token))
            {
                print.message = "Token校验失败";
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            int? isDefault = _templateRepository.FindAsIQueryable(x => x.PrintTemplateId == new Guid(id))
                              .OrderByDescending(x => x.CreateDate)
                              .Select(s => s.isDefault)
                              .FirstOrDefault();
            if (isDefault == 1)
            {
                print.message = "系统内置模版不允许编辑";
                print.data = (JObject)JsonConvert.DeserializeObject("{}");
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            else
            {
                Base_PrintTemplate printTemplate = new Base_PrintTemplate()
                {
                    PrintTemplateId = new Guid(id),
                    TemplateContent = stage
                };

                //将模板存储成需要的类型
                JObject ob = JObject.Parse(stage);
                StringBuilder stringBuilder = new StringBuilder();
                //获取模板控件总数
                var elementsLen = ob["elements"].ToArray();

                stringBuilder.Append("LODOP.PRINT_INITA(\"3mm\", \"7mm\", \"" + ob["page"]["width"].ToString() + "mm\", \"" + ob["page"]["height"].ToString() + "mm\", \"采购流程\"); ");
                stringBuilder.Append("LODOP.SET_PRINT_PAGESIZE(\"1\", \"79.92mm\", \"60.07mm\", \"采购流程sssssss\"); ");
                stringBuilder.Append("LODOP.SET_PRINT_MODE(\"PROGRAM_CONTENT_BYVAR\", true);");
                stringBuilder.Append("LODOP.SET_PRINT_MODE(\"PRINT_NOCOLLATE\", 1);");
                for (int i = 0; i < elementsLen.Length; i++)
                {
                    string Top = "";
                    string Left = "";
                    string Width = "";
                    string Heigth = "";
                    string Result = "";
                    //判断控件名称
                    var type = elementsLen[i]["type"].ToString();
                    switch (type)
                    {
                        //文本
                        case "text":
                            Top = elementsLen[i]["props"]["y"].ToString();
                            Left = elementsLen[i]["props"]["x"].ToString();
                            Width = elementsLen[i]["props"]["width"].ToString();
                            Heigth = elementsLen[i]["props"]["height"].ToString();
                            JToken tokens = elementsLen[i]["props"]["bind"].SelectToken("fields");
                            Result = tokens == null ? "" : elementsLen[i]["props"]["bind"]["fields"][0]["key"].ToString();
                            stringBuilder.Append("LODOP.ADD_PRINT_TEXT(\"" + Top + "mm\", \"" + Left + "mm\", \"" + Width + "mm\", \"" + Heigth + "mm\", \"" + Result + "\"); ");
                            break;
                        //图片
                        case "image":
                            Top = elementsLen[i]["props"]["y"].ToString();
                            Left = elementsLen[i]["props"]["x"].ToString();
                            Width = elementsLen[i]["props"]["width"].ToString();
                            Heigth = elementsLen[i]["props"]["height"].ToString();
                            Result = elementsLen[i]["props"]["image"] == null ? "" : elementsLen[i]["props"]["image"].ToString();
                            stringBuilder.Append(" LODOP.ADD_PRINT_IMAGE(\"42.07mm\", \"2.91mm\", \"36.52mm\", \"17.99mm\", \"<img src='" + Result + "'>\"); ");
                            //stringBuilder.Append("LODOP.ADD_PRINT_IMAGE(0, 0, 200, 200, \"<img src= 'http://img-qn-2.51miz.com/preview/element/00/01/25/28/E-1252871-96D669E4.jpg' > \");");
                            stringBuilder.Append("LODOP.SET_PRINT_STYLEA(0,\"Stretch\",1);");

                            break;
                        //二维码
                        case "qrcode":
                            Top = elementsLen[i]["props"]["y"].ToString();
                            Left = elementsLen[i]["props"]["x"].ToString();
                            Width = elementsLen[i]["props"]["width"].ToString();
                            Heigth = elementsLen[i]["props"]["height"].ToString();
                            JToken tokenss = elementsLen[i]["props"]["bind"].SelectToken("fields");
                            Result = tokenss == null ? "" : elementsLen[i]["props"]["bind"]["fields"][0]["key"].ToString();
                            stringBuilder.Append("LODOP.ADD_PRINT_BARCODE(\"" + Top + "mm\", \"" + Left + "mm\", \"" + Width + "mm\", \"" + Heigth + "mm\", \"QRCode\", \"" + Result + "\"); ");
                            break;
                        //条形码
                        case "barcode":
                            Top = elementsLen[i]["props"]["y"].ToString();
                            Left = elementsLen[i]["props"]["x"].ToString();
                            Width = elementsLen[i]["props"]["width"].ToString();
                            Heigth = elementsLen[i]["props"]["height"].ToString();
                            JToken tokensss = elementsLen[i]["props"]["bind"].SelectToken("fields");
                            Result = tokensss == null ? "" : elementsLen[i]["props"]["bind"]["fields"][0]["key"].ToString();
                            stringBuilder.Append("LODOP.ADD_PRINT_BARCODE(\"" + Top + "mm\", \"" + Left + "mm\", \"" + Width + "mm\", \"" + Heigth + "mm\", \"Code39\", \"" + Result + "\"); ");
                            break;
                        //直线
                        case "line":
                            Top = elementsLen[i]["props"]["y"].ToString();
                            Left = elementsLen[i]["props"]["x"].ToString();
                            Width = elementsLen[i]["props"]["width"].ToString();
                            Heigth = elementsLen[i]["props"]["height"].ToString();
                            stringBuilder.Append("LODOP.ADD_PRINT_TEXT(\"" + Top + "mm\", \"" + Left + "mm\", \"" + Width + "mm\", \"" + Heigth + "mm\", \"" + Result + "\"); ");
                            break;
                        default:
                            break;
                    }
                }
                stringBuilder.Append(" LODOP.PREVIEW();");


                printTemplate.LodopPrint = stringBuilder.ToString();
                _templateRepository.Update(printTemplate, x => new { x.TemplateContent, x.LodopPrint }, true);
                print.message = "成功";
                print.data = (JObject)JsonConvert.DeserializeObject("{}");
                print.status = 1;
                print.success = true;
                return JsonNormal(print);
            }
        }


        [HttpPost, HttpGet, Route("getResourceByCatId"), AllowAnonymous]
        public IActionResult getResourceByCatId(string id, string cat, string token)
        {
            PrintOutput printOp = new PrintOutput();
            if (!VerificationToken(token))
            {
                printOp.message = "Token校验失败";
                printOp.status = 1;
                printOp.success = false;
                return JsonNormal(printOp);
            }
            string tableNameMain = string.Empty;
            string tableNameDetail = string.Empty;
            switch (cat)
            {
                case "EMS_MaintainPaper":
                    tableNameMain = "EMS_MaintainPaper";
                    tableNameDetail = "EMS_MaintainPaperList";
                    break;
                default:
                    tableNameMain = "EMS_MaintainPaper";
                    tableNameDetail = "EMS_MaintainPaperList";
                    break;
            }
            string sqlMain = @"SELECT 
                                  a.name [key],
                                  isnull(g.[value], '') name
                                FROM
                                  syscolumns a
                                  inner join sysobjects d on a.id = d.id
                                  and d.xtype = 'U'
                                  and d.name <> 'dtproperties'
                                  left join sys.extended_properties g on a.id = G.major_id
                                  and a.colid = g.minor_id
                                where
                                  d.name = @tableNameMain
                                order by
                                  a.id, 
                                  a.colorder";
            string sqlDetail = @"SELECT 
                                  a.name [key],
                                  isnull(g.[value], '') name
                                FROM
                                  syscolumns a
                                  inner join sysobjects d on a.id = d.id
                                  and d.xtype = 'U'
                                  and d.name <> 'dtproperties'
                                  left join sys.extended_properties g on a.id = G.major_id
                                  and a.colid = g.minor_id
                                where
                                  d.name = @tableNameDetail
                                order by
                                  a.id, 
                                  a.colorder";

            //与原生dapper使用方式基本一致，更多使用方法参照dapper文档
            List<filedDetail> main = DBServerProvider.SqlDapper.QueryList<filedDetail>(sqlMain, new { tableNameMain });
            List<filedDetail> detail = DBServerProvider.SqlDapper.QueryList<filedDetail>(sqlDetail, new { tableNameDetail });

            PrintFieldOutput print = new PrintFieldOutput();
            List<filed> list = new List<filed>();
            if (tableNameMain != "")
            {
                list.Add(new filed
                {
                    id = "bill",
                    name = "选择需要选择的表字段",
                    tag = "dataBill",
                    fields = main
                });
                list.Add(new filed
                {
                    id = "detail",
                    name = "子表数据",
                    tag = "dataDetail",
                    fields = detail
                });
            }
            print.data = list;
            print.message = "成功";
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }
        [HttpPost, HttpGet, Route("getDataById"), AllowAnonymous]
        public IActionResult getDataById(string id, string cat, string token)
        {
            PrintOutput print = new PrintOutput();
            if (!VerificationToken(token))
            {
                print.message = "Token校验失败";
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            string templateContent = string.Empty;
            if (string.IsNullOrWhiteSpace(id))
            {
                Guid catalogId = _templateCatalogRepository.FindAsIQueryable(x => x.CatalogCode == cat)
                               .OrderByDescending(x => x.CreateDate)
                               .Select(s => s.CatalogId)
                               .FirstOrDefault();
                templateContent = _templateRepository.FindAsIQueryable(x => x.CatalogId == catalogId && x.StatusFlag == 1)
                             .OrderByDescending(x => x.CreateDate)
                             .Select(s => s.TemplateContent)
                             .FirstOrDefault();
            }
            else
            {
                templateContent = _templateRepository.FindAsIQueryable(x => x.PrintTemplateId == new Guid(id))
                                   .OrderByDescending(x => x.CreateDate)
                                   .Select(s => s.TemplateContent)
                                   .FirstOrDefault();
            }
            JObject jo = new JObject();
            if (templateContent != null)
            {
                jo = (JObject)JsonConvert.DeserializeObject(templateContent);
            }
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }
        private bool VerificationToken(string token)
        {
            string requestToken = token?.Replace("Bearer ", "");
            int userId = JwtHelper.GetUserId(requestToken);
            if (string.IsNullOrWhiteSpace(token) || userId <= 0)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

        [HttpPost, HttpGet, Route("getDataByIdPrint"), AllowAnonymous]
        public IActionResult getDataByIdPrint(string dataId, string cat, string token)
        {
            PrintOutput print = new PrintOutput();
            if (!VerificationToken(token))
            {
                print.message = "Token校验失败";
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            string templateContent = string.Empty;
            Guid catalogId = _templateCatalogRepository.FindAsIQueryable(x => x.CatalogCode == cat)
                           .OrderByDescending(x => x.CreateDate)
                           .Select(s => s.CatalogId)
                           .FirstOrDefault();
            templateContent = _templateRepository.FindAsIQueryable(x => x.CatalogId == catalogId && x.StatusFlag == 1)
                         .OrderByDescending(x => x.CreateDate)
                         .Select(s => s.TemplateContent)
                         .FirstOrDefault();

            JObject jo = (JObject)JsonConvert.DeserializeObject(templateContent);
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }

        [HttpPost, HttpGet, Route("getBillData"), AllowAnonymous]
        public IActionResult getBillData(string id, string cat, string token)
        {
            PrintOutput print = new PrintOutput();
            if (!VerificationToken(token))
            {
                print.message = "Token校验失败";
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            string tableNameMain = string.Empty;
            string sql = string.Empty;
            string jsonstr = string.Empty;
            switch (cat)
            {
                case "EMS_MaintainPaper":
                    tableNameMain = "EMS_MaintainPaper";
                    sql = "select * from " + tableNameMain + " where MaintainPaperId=@ID ";
                    string ID = id;
                    //与原生dapper使用方式基本一致，更多使用方法参照dapper文档
                    EMS_MaintainPaper entity = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaper>(sql, new { ID })[0];
                    jsonstr = JsonConvert.SerializeObject(entity);
                    break;
                default:
                    tableNameMain = "EMS_MaintainPaper";
                    sql = "select * from " + tableNameMain + " where MaintainPaperId=@ID2 ";
                    string ID2 = id;
                    //与原生dapper使用方式基本一致，更多使用方法参照dapper文档
                    EMS_MaintainPaper entity2 = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaper>(sql, new { ID2 })[0];
                    jsonstr = JsonConvert.SerializeObject(entity2);
                    break;
            }
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonstr);
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }
        [HttpPost, HttpGet, Route("getReviewBillData"), AllowAnonymous]
        public IActionResult getReviewBillData(string id, string cat, string token)
        {
            PrintOutput print = new PrintOutput();
            if (!VerificationToken(token))
            {
                print.message = "Token校验失败";
                print.status = 1;
                print.success = false;
                return JsonNormal(print);
            }
            string tableNameMain = string.Empty;
            string sql = string.Empty;
            string jsonstr = string.Empty;
            switch (cat)
            {
                case "EMS_MaintainPaper":
                    tableNameMain = "EMS_MaintainPaper";
                    sql = "select top 1  * from " + tableNameMain;
                    string ID = id;
                    //与原生dapper使用方式基本一致，更多使用方法参照dapper文档

                    var entity = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaper>(sql, new { ID });
                    if (entity.Count < 1)
                    {
                        return Json("数据为空！");
                    }
                    else
                        jsonstr = JsonConvert.SerializeObject(entity[0]);
                    break;
                default:
                    tableNameMain = "EMS_MaintainPaper";
                    sql = "select top 1  * from " + tableNameMain;
                    string ID2 = id;
                    //与原生dapper使用方式基本一致，更多使用方法参照dapper文档
                    EMS_MaintainPaper entity2 = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaper>(sql, new { ID2 })[0];
                    jsonstr = JsonConvert.SerializeObject(entity2);
                    break;
            }
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonstr);
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }

        [HttpPost, HttpGet, Route("GetLodopCode"), AllowAnonymous]
        public IActionResult GetLodopCode()
        {
            var mes = _service.LodopPrint();
            return Json(mes);
        }

        [HttpPost, HttpGet, Route("getReviewDetailData"), AllowAnonymous]
        public IActionResult getReviewDetailData(string id, string cat, string token)
        {
            PrintOutput printOp = new PrintOutput();
            if (!VerificationToken(token))
            {
                printOp.message = "Token校验失败";
                printOp.status = 1;
                printOp.success = false;
                return JsonNormal(printOp);
            }
            string tableNameDetail = string.Empty;
            string sql = string.Empty;
            string jsonstr = string.Empty;
            switch (cat)
            {
                case "EMS_MaintainPaper":
                    tableNameDetail = "EMS_MaintainPaperList";
                    string MaintainPaperListId = id;
                    sql = "select top 3 * from " + tableNameDetail;
                    List<EMS_MaintainPaperList> entityList = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaperList>(sql, new { MaintainPaperListId });
                    jsonstr = JsonConvert.SerializeObject(entityList);
                    break;

                default:
                    tableNameDetail = "EMS_MaintainPaperList";
                    string EMS_MaintainPaperListId = id;
                    sql = "select  top 3 * from " + tableNameDetail;
                    List<EMS_MaintainPaperList> entityList2 = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaperList>(sql, new { EMS_MaintainPaperListId });
                    jsonstr = JsonConvert.SerializeObject(entityList2);
                    break;
            }
            PrintOutputArray print = new PrintOutputArray();
            JArray jo = (JArray)JsonConvert.DeserializeObject(jsonstr);
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }
        [HttpPost, HttpGet, Route("getDetailData"), AllowAnonymous]
        public IActionResult getDetailData(string id, string cat, string token)
        {
            PrintOutput printOp = new PrintOutput();
            if (!VerificationToken(token))
            {
                printOp.message = "Token校验失败";
                printOp.status = 1;
                printOp.success = false;
                return JsonNormal(printOp);
            }
            string tableNameDetail = string.Empty;
            string sql = string.Empty;
            string jsonstr = string.Empty;
            switch (cat)
            {
                case "EMS_MaintainPaper":
                    tableNameDetail = "EMS_MaintainPaperList";
                    string MaintainPaperId = id;
                    sql = "select * from " + tableNameDetail + " where MaintainPaperId=@MaintainPaperId ";
                    List<EMS_MaintainPaperList> entityList = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaperList>(sql, new { MaintainPaperId });
                    jsonstr = JsonConvert.SerializeObject(entityList);
                    break;
                default:
                    tableNameDetail = "EMS_MaintainPaperList";
                    string EMS_MaintainPaperId = id;
                    sql = "select * from " + tableNameDetail + " where EMS_MaintainPaperListId=@EMS_MaintainPaperId ";
                    List<EMS_MaintainPaperList> entityList2 = DBServerProvider.SqlDapper.QueryList<EMS_MaintainPaperList>(sql, new { EMS_MaintainPaperId });
                    jsonstr = JsonConvert.SerializeObject(entityList2);
                    break;
            }
            PrintOutputArray print = new PrintOutputArray();
            JArray jo = (JArray)JsonConvert.DeserializeObject(jsonstr);
            print.message = "成功";
            print.data = jo;
            print.status = 1;
            print.success = true;
            return JsonNormal(print);
        }
        [HttpPost, HttpGet, Route("LodopResult"), AllowAnonymous]
        public IActionResult LodopResult(Guid MaintainPaperListId)
        {
            var mes = _service.LodopResult(MaintainPaperListId);
            return Json(mes);
        }


    }
}
