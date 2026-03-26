/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下SYS_CodingrulesService与ISYS_CodingrulesService中编写
 */
using SYS.IRepositories;
using SYS.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace SYS.Services
{
    public partial class SYS_CodingrulesService : ServiceBase<SYS_Codingrules, ISYS_CodingrulesRepository>
    , ISYS_CodingrulesService, IDependency
    {
    public SYS_CodingrulesService(ISYS_CodingrulesRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISYS_CodingrulesService Instance
    {
      get { return AutofacContainerModule.GetService<ISYS_CodingrulesService>(); } }
    }
 }
