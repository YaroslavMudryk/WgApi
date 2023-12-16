using WgApi.Helpers.Extensions;
using WgApi.Models;

namespace WgApi.Services
{
    public class WorldOfTanksService : BaseService
    {
        public WorldOfTanksService(string applicationId, string accessToken, string baseUrl) : base(applicationId, accessToken, baseUrl)
        {
        }

        public async Task<List<WgAccount>> SearchAccountsAsync(string search)
        {
            var response = await GetResponseAsync<List<WgAccount>>("wot/account/list/?".AddParamIfNotExist("search", search));
            return response.Data;
        }
    }
}
