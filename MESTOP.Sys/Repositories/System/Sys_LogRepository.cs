using MESTOP.Sys.IRepositories;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Core.EFDbContext;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Sys.Repositories
{
    public partial class Sys_LogRepository : RepositoryBase<Sys_Log>, ISys_LogRepository
    {
        public Sys_LogRepository(SysDbContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_LogRepository GetService
        {
            get { return AutofacContainerModule.GetService<ISys_LogRepository>(); }
        }
    }
}

