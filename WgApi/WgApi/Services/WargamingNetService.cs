using WgApi.Helpers.Extensions;
using WgApi.Models;

namespace WgApi.Services
{
    public class WargamingNetService  : BaseService
    {
        public WargamingNetService(string applicationId, string accessToken, string baseUrl) : base(applicationId, accessToken, baseUrl)
        {
        }

        public async Task<Dictionary<string, List<Server>>> GetServersAsync()
        {
            var response = await GetResponseAsync<Dictionary<string, List<Server>>>("wgn/servers/info/?");
            return response.Data;
        }

        public async Task<List<WgAccount>> SearchAccountsAsync(string search)
        {
            var response = await GetResponseAsync<List<WgAccount>>("wgn/account/list/?".AddParamIfNotExist("search", search));
            return response.Data;
        }

        public async Task<WgAccount> GetAccountInfoAsync(int accountId)
        {
            var response = await GetResponseAsync<Dictionary<string, WgAccount>>("wgn/account/info/?".AddParamIfNotExist("account_id", accountId.ToString()));
            return response.Data.First().Value;
        }
    }
}