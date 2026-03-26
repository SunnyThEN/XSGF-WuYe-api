using MESTOP.Core.BaseProvider;
using MESTOP.Core.Utilities;
using MESTOP.Entity.DomainModels;
using System.Threading.Tasks;

namespace MESTOP.Sys.IServices
{
    public partial interface ISys_UserService
    {

        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

