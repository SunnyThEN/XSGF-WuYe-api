using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MESTOP.Core.BaseProvider;
using MESTOP.Entity.DomainModels;
using MESTOP.Core.Extensions.AutofacManager;
namespace MESTOP.Sys.IRepositories
{
    public partial interface ISys_MenuRepository : IDependency,IRepository<Sys_Menu>
    {
    }
}

