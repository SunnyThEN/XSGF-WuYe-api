/*
*所有关于SYS_Codingrules类的业务代码接口应在此处编写
*/
using MESTOP.Core.BaseProvider;
using MESTOP.Entity.DomainModels;
using MESTOP.Core.Utilities;
using System.Linq.Expressions;
namespace SYS.IServices
{
    public partial interface ISYS_CodingrulesService
    {

        public string GetSYS_Codingrules(string TBActionType, string position, string parameter,string inputstr);
    }
 }
