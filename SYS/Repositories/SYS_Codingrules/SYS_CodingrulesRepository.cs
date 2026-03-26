/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹SYS_CodingrulesRepository编写代码
 */
using SYS.IRepositories;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.EFDbContext;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace SYS.Repositories
{
    public partial class SYS_CodingrulesRepository : RepositoryBase<SYS_Codingrules> , ISYS_CodingrulesRepository
    {
    public SYS_CodingrulesRepository(SysDbContext dbContext)
    : base(dbContext)
    {

    }
    public static ISYS_CodingrulesRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ISYS_CodingrulesRepository>(); } }
    }
}
