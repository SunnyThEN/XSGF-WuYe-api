/*
 *所有关于RMS_PropertyDetails类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*RMS_PropertyDetailsService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
    public partial class RMS_PropertyDetailsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRMS_PropertyDetailsRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public RMS_PropertyDetailsService(
            IRMS_PropertyDetailsRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }


        public override WebResponseContent Update(SaveModel saveModel)
        {
            WebResponseContent webResponse = new WebResponseContent();
            //注意：如果要给其他字段设置值，请在此处设置,如：（代码生成器上将字段编辑行设置为0，然后点生成model）
            //saveModel.MainData["Remark"] = "值";//Remark改为你的字段

            //编辑方法保存数据库前处理
            UpdateOnExecuting = (RMS_PropertyDetails order, object addList, object updateList, List<object> delKeys) =>
            {
             
                //如果要手动设置某些字段的值,值不是前端提交的（代码生成器里面编辑行必须设置为0并生成model
                //注意:必须设置上面saveModel.MainData["Remark"] = "值";
                //order.Remark = "888";

                //删除明细表Id
                var guids = delKeys?.Select(x => (Guid)x);

                //如果设置code=-1会,不会执行后面的数据库保存，前端会提示成功
                //webResponse.Code = "-1";
                //return webResponse.OK("返回提示");

                return webResponse.OK();
            };

            //编辑方法保存数据库后处理
            //此方法中已开启了事务，如果在此方法中做其他数据库操作，请不要再开启事务
            // 在保存数据库后的操作，此时已进行数据提交，但未提交事务，如果返回false，则会回滚提交
          //  表 order2 = null;
            //UpdateOnExecuted = (表 order, object addList, object updateList, List<object> delKeys) =>
            //{
            //    order2 = order;//外面申明对象，用于下面if(res.Status)自定义业务逻辑取数
            //                   //如果是一对多表,在这里根据主键id查询出来后单独处理业务逻辑
            //                   //新增的明细
            //    List<表List> add = addList as List<表List>;
            //    //修改的明细
            //    List<表List> update = updateList as List<表List>;
            //    //删除的行的主键
            //    var guids = delKeys?.Select(x => (Guid)x);
            //    //保存到数据库后，这里可以再查询数据库写业务操作
            //    //注意EF版,这里如果是执行的sql，只能使用ef执行sql，如:repository.DbContext.Database.xx
            //    return webResponse.OK();
            //};

            var res = base.Update(saveModel);
            //这里在保存成功后做一些其他操作
       
            return res;
        }
    }
}
