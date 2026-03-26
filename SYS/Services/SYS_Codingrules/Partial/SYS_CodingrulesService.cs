/*
 *所有关于SYS_Codingrules类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*SYS_CodingrulesService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;
using System.Linq;
using MESTOP.Core.Utilities;
using System.Linq.Expressions;
using MESTOP.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using SYS.IRepositories;
using System;
using MESTOP.Core.DBManager;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace SYS.Services
{
    public partial class SYS_CodingrulesService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISYS_CodingrulesRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public SYS_CodingrulesService(
            ISYS_CodingrulesRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }



            public override PageGridData<SYS_Codingrules>GetPageData(PageDataOptions options)
            {

                QueryRelativeExpression = (IQueryable<SYS_Codingrules>queryable) =>
                {

                    queryable = queryable.Where(x => x.isDel != 1);
                    return queryable;

                 };
             return base.GetPageData(options);
             }


        public string GetSYS_Codingrules(string TBActionType, string position, string parameter, string inputstr)
        {

            var SYS_Code = string.Empty;


            var Getdata = _repository.FindAsIQueryable(x => x.TableActionType == TBActionType && x.prefixCode == parameter).FirstOrDefault();

            if (Getdata == null) { return SYS_Code; }
            string SeparatorStr = Getdata.Separator;
            if (Getdata != null)
            {
                var prefixCode = string.Empty;
                var DateCode = string.Empty;

                if (!string.IsNullOrEmpty(Getdata.prefixCode)) prefixCode = Getdata.prefixCode.ToString();

                if (!string.IsNullOrEmpty(Getdata.DateCode)) DateCode = DateTime.Now.AddHours(-8).ToString(Getdata.DateCode.Replace(",", "")) + "";
                var tranCode = prefixCode + DateCode;
                int pos = 0;

                if (int.TryParse(position, out pos))
                {
                    if (!DateCode.IsNullOrEmpty()) { DateCode = DateCode + SeparatorStr; }
                    //if (!inputstr.IsNullOrEmpty()) { inputstr = inputstr + SeparatorStr; }
             

                    if (pos == 1) tranCode = inputstr + DateCode; //参数+前缀+日期
                    if (pos == 2) tranCode =  DateCode   + inputstr ; //前缀+日期+参数

                    //if (pos == 3) tranCode = prefixCode + SeparatorStr + inputstr + SeparatorStr + DateCode;//前缀+参数+日期

                    //if (pos == 4) tranCode = inputstr + SeparatorStr + DateCode + SeparatorStr + prefixCode;// 参数+日期+后缀


                    if (pos == 5) tranCode = inputstr  + DateCode  ;//参数+日期

                }
                SYS_Code = tranCode + 1.ToString().PadLeft(Getdata.SerialNumber.GetInt(), '0');

                //if (Getdata.LastDate != DateTime.Now.ToString(Getdata.DateCode.Replace(",", "")))
                //{

                //}
                //else
                //{

                //    MES_Code = tranCode + Getdata.LastNumber;
                //}


                SYS_Code = getCode(SYS_Code, TBActionType);//编码验证  

                //最后更新
                //var lastnumber = (int.Parse(MES_Code.Substring(MES_Code.Length - (int)Getdata.SerialNumber, (int)Getdata.SerialNumber))+1).ToString().PadLeft(Getdata.SerialNumber.GetInt(), '0');
                //var lastdate = DateTime.Now.ToString(Getdata.DateCode.Replace(",", ""));
                //string sql = " update MES_Codingrules set LastNumber='"+ lastnumber + "',LastDate='" + lastdate + "' where TableActionType='" + Getdata.TableActionType+"'";
                //var s = DBServerProvider.SqlDapper.ExecuteScalar(sql,  null);


            }
            //getMes_Code gCode = new getMes_Code();
            //gCode.codename = "MES_Code";
            //gCode.codevlue = MES_Code.ToString();
            return SYS_Code;
        }

        private class getSYS_Code
        {
            public string codename { get; set; }
            public string codevlue { get; set; }
        }
        private string getCode(string MES_Code, string TBActionType)
        {
            string MES_Code2 = string.Empty;
            var Getdata = _repository.FindAsIQueryable(x => x.TableActionType == TBActionType).FirstOrDefault();
            string MES_CodeA  = MES_Code.Substring(0, MES_Code.Length - (int)Getdata.SerialNumber);
            string searchsql = "select TOP 1 MAX(" + Getdata.TableAction + ") as MES_Cod  from " + Getdata.TableActionType + " where CHARINDEX('" + MES_CodeA + "'," + Getdata.TableAction + ") > 0";
            var searchcount = DBServerProvider.SqlDapper.QueryFirst<object>(searchsql, null);
            var data = (IDictionary<string, object>)searchcount;
            var SQL_Cod = data["MES_Cod"];

            if (SQL_Cod != null)
            {
                    var SQL_Codstr = SQL_Cod.ToString();
                    var nownumber = (int.Parse(SQL_Codstr.Substring(SQL_Codstr.Length - (int)Getdata.SerialNumber, (int)Getdata.SerialNumber)) + 1);
                    //var lastnumber = (nownumber + 1).ToString().PadLeft(Getdata.SerialNumber.GetInt(), '0');
                    //var lastdate = DateTime.Now.ToString(Getdata.DateCode.Replace(",", ""));
                    MES_Code2 = MES_Code.Substring(0, MES_Code.Length - Getdata.SerialNumber.GetInt()) + nownumber.ToString().PadLeft(Getdata.SerialNumber.GetInt(), '0');
                return MES_Code2;
            }
            else
            {
                return MES_Code;
            }
          
                    
                 
        }
    }
}
