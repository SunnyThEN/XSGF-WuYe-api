using MESTOP.Sys.IRepositories;
using MESTOP.Sys.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Sys.Services
{
    public partial class Sys_LogService : ServiceBase<Sys_Log, ISys_LogRepository>, ISys_LogService, IDependency
    {
        public Sys_LogService(ISys_LogRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_LogService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_LogService>(); }
        }
    }
}

