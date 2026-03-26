/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Demo_ProductService与IDemo_ProductService中编写
 */
using MESTOP.DbTest.IRepositories;
using MESTOP.DbTest.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace MESTOP.DbTest.Services
{
    public partial class Demo_ProductService : ServiceBase<Demo_Product, IDemo_ProductRepository>
    , IDemo_ProductService, IDependency
    {
    public Demo_ProductService(IDemo_ProductRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IDemo_ProductService Instance
    {
      get { return AutofacContainerModule.GetService<IDemo_ProductService>(); } }
    }
 }
