/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Sys_DictionaryService与ISys_DictionaryService中编写
 */
using MESTOP.Sys.IRepositories;
using MESTOP.Sys.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Sys.Services
{
    public partial class Sys_DictionaryService : ServiceBase<Sys_Dictionary, ISys_DictionaryRepository>
    , ISys_DictionaryService, IDependency
    {
    public Sys_DictionaryService(ISys_DictionaryRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISys_DictionaryService Instance
    {
      get { return AutofacContainerModule.GetService<ISys_DictionaryService>(); } }
    }
 }
