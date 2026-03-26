/*
*所有关于Sys_Authorization类的业务代码接口应在此处编写
*/
using MESTOP.Core.BaseProvider;
using MESTOP.Entity.DomainModels;
using MESTOP.Core.Utilities;
using System.Linq.Expressions;
namespace MESTOP.Sys.IServices
{
    public partial interface ISys_AuthorizationService
    {
        string AuthorizationCode(string sYSstr, string mACcode);
        bool getAuthorization();
    }
 }
