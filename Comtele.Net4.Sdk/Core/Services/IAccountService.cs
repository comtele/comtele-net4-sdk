using Comtele.Net4.Sdk.Core.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comtele.Net4.Sdk.Core.Services
{
    public interface IAccountService
    {
        ServiceResult<List<AccountDetailResource>> GetAllAccounts();
        Task<ServiceResult<List<AccountDetailResource>>> GetAllAccountsAsync();

        AccountDetailResource GetAccountByUsername(string username);
        Task<AccountDetailResource> GetAccountByUsernameAsync(string username);
    }
}
