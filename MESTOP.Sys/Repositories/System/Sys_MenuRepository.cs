using MESTOP.Sys.IRepositories;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Core.EFDbContext;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Sys.Repositories
{
    public partial class Sys_MenuRepository : RepositoryBase<Sys_Menu>, ISys_MenuRepository
    {
        public Sys_MenuRepository(SysDbContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_MenuRepository Instance
        {
            get { return AutofacContainerModule.GetService<ISys_MenuRepository>(); }
        }
    }
}

