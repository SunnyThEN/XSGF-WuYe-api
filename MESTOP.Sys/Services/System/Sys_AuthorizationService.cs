/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Sys_AuthorizationService与ISys_AuthorizationService中编写
 */
using MESTOP.Sys.IRepositories;
using MESTOP.Sys.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Sys.Services
{
    public partial class Sys_AuthorizationService : ServiceBase<Sys_Authorization, ISys_AuthorizationRepository>
    , ISys_AuthorizationService, IDependency
    {
    public Sys_AuthorizationService(ISys_AuthorizationRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISys_AuthorizationService Instance
    {
      get { return AutofacContainerModule.GetService<ISys_AuthorizationService>(); } }
    }
 }
