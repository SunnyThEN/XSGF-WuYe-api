/*
 *所有关于RMS_PaymentDetails类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*RMS_PaymentDetailsService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
using RMS.IRepositories;

namespace RMS.Services
{
    public partial class RMS_PaymentDetailsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRMS_PaymentDetailsRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public RMS_PaymentDetailsService(
            IRMS_PaymentDetailsRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="pageData"></param>
        /// <returns></returns>
        public override WebResponseContent Export(PageDataOptions pageData)
        {
            WebResponseContent webResponse = new WebResponseContent();
            //设置最大导出的数量
            //Limit = 1000;
            //指定导出的字段
            //ExportColumns = x => new { x.SellNo, x.TranNo, x.CreateDate };

            //查询要导出的数据后，在生成excel文件前处理
            //list导出的实体，ignore过滤不导出的字段
            ExportOnExecuting = (List<RMS_PaymentDetails> list, List<string> ignore) =>
            {

                return webResponse.OK();
            };

            return base.Export(pageData);
        }
    }
}
