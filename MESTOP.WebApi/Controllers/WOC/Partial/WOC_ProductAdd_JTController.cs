/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("WOC_ProductAdd_JT",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using WOC.IServices;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using WOC.Repositories;
using WOC.Services;
using System.Linq;
using Castle.Core.Internal;
using CSR_JD.Repositories;
using CSR_JD.Services;
using MESTOP.Core.Extensions;
using MESTOP.Core.Utilities;
using Nancy;
using static CSR_JD.Services.BD_BarCodeMainFile;
using MESTOP.Core.DBManager;
using MESTOP.Core.BaseProvider;

namespace WOC.Controllers
{
    public partial class WOC_ProductAdd_JTController
    {
        private readonly IWOC_ProductAdd_JTService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public WOC_ProductAdd_JTController(
            IWOC_ProductAdd_JTService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("PRD_InWare")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> PRD_InWare()
        {
            //用料清单列表

            ////WOC_MaterialReceiptMainRepository.Instance.DbContext.ContextId("E42F8000-F668-4523-8A31-217BC7BD52D7").Find(x => 1 == 1);
 
            //var product = WOC_ProductAdd_JTRepository.Instance.FindFirst(x => x.IsInWarehouse == 0 || x.IsInWarehouse == null);
            var product = WOC_ProductAdd_JTRepository.Instance.FindFirst(x => (x.IsInWarehouse == 0 || x.IsInWarehouse == null) && (x.MarkNumber == 0 || x.MarkNumber == null));
            if (product is not null)
            {
               await  WOC_ProductAdd_JTService.Instance.InWare(product);
            }
            else
            {
                
                ////问题1 包含徐刚站线重新入库
                //var upall =await WOC_ProductAdd_JTRepository.Instance.FindAsync(x => x.IsInWarehouse == 2&&x.isInSubmit==null&& x.ERPRemark.Contains("徐刚"));
                //if (upall.Count > 0)
                //{
                //    upall.ForEach(x => { x.ERPRemark = ""; x.MarkNumber = 0; x.IsInWarehouse = 0; });
                //    WOC_ProductAdd_JTRepository.Instance.UpdateRange(upall, x => new { x.ERPRemark, x.MarkNumber, x.IsInWarehouse }, true);
                //}
                
            }

            return "";


        }


        [HttpPost, Route("BarCodeFileJT")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> BarCodeFileJT()
        {
            try
            {
                string sql = @" SELECT   *  FROM  [MES.TOP].[dbo].[WOC_Dispatch_WorkFlow]  WHERE NEWFLOT NOT IN ( SELECT FNUMBER  FROM [MES.TOPold].[dbo].[T_BD_BARCODEMAIN] )   and PlanStartTime>dateadd(Day,-50 ,getdate())   AND   IsInWarehouse is null   AND  NEWFLOT IS NOT NULL AND  LEN(NEWFLOT)>3 ";
                var orderResult =  await  
                DBServerProvider.SqlDapper.QueryListAsync<WOC_Dispatch_WorkFlow>(sql, null);

               // List<WOC_Dispatch_WorkFlow> orderResult  = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.NEWFLOT==NEWFLOT);
                //入库成功之后查询要新增的条码主档是否存在，存在就修改原有数据 入库单号 数量，宽度 长度
                foreach (var order in orderResult)
                {
                    //批号
                    var FLot = order.NEWFLOT;
                    var barcode = await T_BD_BARCODEMAINRepository.Instance.FindFirstAsync(x => x.FBARCODE == FLot);
                    //获得入库单号
                    BD_BarCodeMainFile.Model bdmodel = new BD_BarCodeMainFile.Model();
                    //FID默认为0，使用物料编码加批号在条码主档中查询到数据那就将FID赋值用来修改
                    bdmodel.FID = 0;
                    if (barcode  is null)
                    {
                       // bdmodel.FID = barcode.FID.GetInt();// 修改
                  
                    var weight = order.OutWeightUnit == null ? 0 : order.OutWeightUnit.GetFloat();

                    bdmodel.FMaterialId = new BD_BarCodeMainFile.FMaterialId();
                    bdmodel.FMaterialId.FNumber = order.ProductCode;        //"";//物料编号
                    bdmodel.FBaseQty = weight;//数量
                    bdmodel.FQty = weight;//数量

                    bdmodel.FLot = new BD_BarCodeMainFile.FLot();//批号
                    bdmodel.FLot.FNumber = order.NEWFLOT;//卷号
                    bdmodel.FBarCodeType = "LotBarCode";//条码类型.F
                    bdmodel.FBillCode = order.RequestNo;//入库号
                    bdmodel.FBarCode = order.NEWFLOT;//条形码 卷号
                    bdmodel.FBarCodeRule = new BD_BarCodeMainFile.FBarCodeRule();//批号 
                    bdmodel.FBarCodeRule.FNUMBER = "TMGZ03_SYS";//条码规则 
                    bdmodel.FCreateOrgId = new BD_BarCodeMainFile.FCreateOrgId();//组织
                    bdmodel.FCreateOrgId.FNumber = "JT";
                    //条码主档宽度
                    bdmodel.FAuxPropId = new FAuxPropId();
                    bdmodel.FAuxPropId.FAUXPROPID__FF100001 = new BD_BarCodeMainFile.FAUXPROPID__FF100001();
                    bdmodel.FAuxPropId.FAUXPROPID__FF100001.FNumber = order.OutWidthUnit.ToString();
                    //条码主档长度
                    bdmodel.F_PASF_Lenth = order.OutLengthUnit.ToString();
                    //MES子计划号
                    bdmodel.F_PASF_MESMO = order.WorkOrderCode;

                    bdmodel.F_PASF_BADCAUSE = order.Remark;
                         
                        bdmodel.FStockId = new BD_BarCodeMainFile.FStockId();//仓库
                        bdmodel.FStockId.FNumber = "JTCK002";

                       // bdmodel.FBillCode = FBillNo;
                    var ee = await CSR_JD_OtherWebApiService.Instance.BD_BarCodeMainFile(bdmodel);
                    if (ee.msg == "200")//条码主档
                    {

                    }
                    else
                    {
                        //await UpdateErroInt(orderResult, ee.msg + "条码主档错误.请联系管理员");
                        return  ee.msg + "条码主档错误.请联系管理员";
                    }
                    }
                }




            }
            catch (Exception ex)
            {
                return  ex.Message;
            }
            return "";
        }



        [HttpPost, Route("BarCodeFileDF")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> BarCodeFileDF()
        {
            try
            {
                string sql = @" SELECT  *  FROM  [MESJSJT].[dbo].[WOC_Dispatch_WorkFlow]  WHERE NEWFLOT NOT IN ( SELECT FNUMBER  FROM [MES.TOPold].[dbo].[T_BD_BARCODEMAIN] )     and PlanStartTime>dateadd(Day,-50 ,getdate())   AND   IsInWarehouse is null   AND  NEWFLOT IS NOT NULL AND  LEN(NEWFLOT)>3 ";
                var orderResult = await
                DBServerProvider.SqlDapper.QueryListAsync<WOC_Dispatch_WorkFlow>(sql, null);

                // List<WOC_Dispatch_WorkFlow> orderResult  = WOC_Dispatch_WorkFlowRepository.Instance.Find(x => x.NEWFLOT==NEWFLOT);
                //入库成功之后查询要新增的条码主档是否存在，存在就修改原有数据 入库单号 数量，宽度 长度
                foreach (var order in orderResult)
                {
                    //批号
                    var FLot = order.NEWFLOT;
                    var barcode = await T_BD_BARCODEMAINRepository.Instance.FindFirstAsync(x => x.FBARCODE == FLot);
                    //获得入库单号
                    BD_BarCodeMainFile.Model bdmodel = new BD_BarCodeMainFile.Model();
                    //FID默认为0，使用物料编码加批号在条码主档中查询到数据那就将FID赋值用来修改
                    bdmodel.FID = 0;
                    if (barcode is null)
                    {
                        // bdmodel.FID = barcode.FID.GetInt();// 修改

                        var weight = order.OutWeightUnit == null ? 0 : order.OutWeightUnit.GetFloat();

                        bdmodel.FMaterialId = new BD_BarCodeMainFile.FMaterialId();
                        bdmodel.FMaterialId.FNumber = order.ProductCode;        //"";//物料编号
                        bdmodel.FBaseQty = weight;//数量
                        bdmodel.FQty = weight;//数量

                        bdmodel.FLot = new BD_BarCodeMainFile.FLot();//批号
                        bdmodel.FLot.FNumber = order.NEWFLOT;//卷号
                        bdmodel.FBarCodeType = "LotBarCode";//条码类型.F
                        bdmodel.FBillCode = order.RequestNo;//入库号
                        bdmodel.FBarCode = order.NEWFLOT;//条形码 卷号
                        bdmodel.FBarCodeRule = new BD_BarCodeMainFile.FBarCodeRule();//批号 
                        bdmodel.FBarCodeRule.FNUMBER = "TMGZ03_SYS";//条码规则 
                        bdmodel.FCreateOrgId = new BD_BarCodeMainFile.FCreateOrgId();//组织
                        bdmodel.FCreateOrgId.FNumber = "DF";
                        //条码主档宽度
                        bdmodel.FAuxPropId = new FAuxPropId();
                        bdmodel.FAuxPropId.FAUXPROPID__FF100001 = new BD_BarCodeMainFile.FAUXPROPID__FF100001();
                        bdmodel.FAuxPropId.FAUXPROPID__FF100001.FNumber = order.OutWidthUnit.ToString();
                        //条码主档长度
                        bdmodel.F_PASF_Lenth = order.OutLengthUnit.ToString();
                        //MES子计划号
                        bdmodel.F_PASF_MESMO = order.WorkOrderCode;

                        bdmodel.F_PASF_BADCAUSE = order.Remark;

                        bdmodel.FStockId = new BD_BarCodeMainFile.FStockId();//仓库
                        bdmodel.FStockId.FNumber = "CK002";

                      //  bdmodel.FBillCode = FBillNo;
                        var ee = await CSR_JD_OtherWebApiService.Instance.BD_BarCodeMainFile(bdmodel);
                        if (ee.msg == "200")//条码主档
                        {

                        }
                        else
                        {
                            //await UpdateErroInt(orderResult, ee.msg + "条码主档错误.请联系管理员");
                            return ee.msg + "条码主档错误.请联系管理员";
                        }
                    }
                }




            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }



        [HttpPost, Route("JTMoClose")]//检测是否有相同自动工位的工单
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<string> JTMoClose()
        {
            //用料清单列表

       
            var molist =await T_PRD_MOENTRY_ARepository.Instance.FindAsync(x => x.FSTATUS == "4"||x.FSTATUS == "5");// 4开工
      

            foreach(var mo in molist) 
            {
                var PWorkOrder =await T_PRD_MORepository.Instance.FindAsyncFirst(x => x.FID == mo.FID && x.FPRDORGID == 100726);// 4开工
                if (PWorkOrder is not null)
                {
                    var womc = await T_PRD_MOENTRYRepository.Instance.FindAsyncFirst(x => x.FID == mo.FID && x.FENTRYID== mo.FENTRYID);// 4开工
                    if (womc is not null)
                    {

                        string Fseq = "00" + womc.FSEQ.ToString();
                        var Fleght= Fseq.Length - 3;
                        var workordercode = PWorkOrder.FBILLNO+"-" + Fseq.Substring(Fleght);
                        WOC_ProductAdd_JTService.Instance.JTMoForceClose(mo.FENTRYID, PWorkOrder.FBILLNO, workordercode);
                    }

                      
                }
            }
           

            return "";


        }

    }
}
