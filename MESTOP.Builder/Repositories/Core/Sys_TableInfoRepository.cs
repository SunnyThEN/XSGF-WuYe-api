using MESTOP.Builder.IRepositories;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.EFDbContext;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Builder.Repositories
{
    public partial class Sys_TableInfoRepository : RepositoryBase<Sys_TableInfo>, ISys_TableInfoRepository
    {
        public Sys_TableInfoRepository(SysDbContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_TableInfoRepository GetService
        {
            get { return AutofacContainerModule.GetService<ISys_TableInfoRepository>(); }
        }
    }
}

