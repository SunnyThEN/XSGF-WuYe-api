/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹RMS_PropertyDetailsRepository编写代码
 */
using RMS.IRepositories;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.EFDbContext;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace RMS.Repositories
{
    public partial class RMS_PropertyDetailsRepository : RepositoryBase<RMS_PropertyDetails> , IRMS_PropertyDetailsRepository
    {
    public RMS_PropertyDetailsRepository(SysDbContext dbContext)
    : base(dbContext)
    {

    }
    public static IRMS_PropertyDetailsRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IRMS_PropertyDetailsRepository>(); } }
    }
}
