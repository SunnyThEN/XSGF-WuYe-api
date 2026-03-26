using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MESTOP.Core.BaseProvider;
using MESTOP.Entity.DomainModels;
using MESTOP.Core.Extensions.AutofacManager;
namespace MESTOP.Builder.IRepositories
{
    public partial interface ISys_TableInfoRepository : IDependency,IRepository<Sys_TableInfo>
    {
    }
}

