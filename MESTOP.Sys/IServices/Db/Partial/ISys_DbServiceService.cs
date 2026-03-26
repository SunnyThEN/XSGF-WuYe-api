/*
*所有关于Sys_DbService类的业务代码接口应在此处编写
*/
using MESTOP.Core.BaseProvider;
using MESTOP.Entity.DomainModels;
using MESTOP.Core.Utilities;
using System.Linq.Expressions;
using System;

namespace MESTOP.Sys.IServices
{
    public partial interface ISys_DbServiceService
    {
        WebResponseContent CreateDb(Guid id);
    }
 }
