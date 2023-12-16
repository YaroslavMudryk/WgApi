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

        public async Task<WotAccount> GetAccountByIdAsync(int accountId)
        {
            var response = await GetResponseAsync<Dictionary<string, WotAccount>>("wot/account/info/?".AddParamIfNotExist("account_id", accountId.ToString()));
            return response.Data.First().Value;
        }

        public async Task<List<TankStatistics>> GetUsersTankStatisticsAsync(int accountId, int tankId)
        {
            var response = await GetResponseAsync<Dictionary<string, List<TankStatistics>>>("wot/account/tanks/?"
                .AddParamIfNotExist("tank_id", tankId.ToString())
                .AddParamIfNotExist("account_id", accountId.ToString()));
            return response.Data.First().Value;
        }

        public async Task<Achievement> GetAccountAchievementsAsync(int accountId)
        {
            var response = await GetResponseAsync<Dictionary<string, Achievement>>("wot/account/achievements/?"
                .AddParamIfNotExist("account_id", accountId.ToString()));
            return response.Data.First().Value;
        }
    }
}
