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


        public async Task<StrongholdInfo> GetClansStrongholdAsync(int clanId)
        {
            var response = await GetResponseAsync<Dictionary<string, StrongholdInfo>>("wot/stronghold/claninfo/?"
                .AddParamIfNotExist("clan_id", clanId));
            return response.Data.First().Value;
        }

        public async Task<List<ClanReserves>> GetClanReservesAsync()
        {
            var response = await GetResponseAsync<List<ClanReserves>>("wot/stronghold/clanreserves/?");
            return response.Data;
        }

        public async Task<DateTime?> ActivateReserveAsync(int reserveLevel, string reserveType)
        {
            var response = await PostResponseAsync<DateTime?>("wot/stronghold/activateclanreserve/?"
                .AddParamIfNotExist("reserve_level", reserveLevel).AddParamIfNotExist("reserve_type", reserveType));
            return response.Data;
        }


        public async Task<List<GlobalFrontMap>> GetGlobalFrontMapsAsync(int? frontId)
        {
            var response = await GetResponseAsync<List<GlobalFrontMap>>("wot/globalmap/fronts/?".AddParamIfNotExist("front_id", frontId));
            return response.Data;
        }


        public async Task<List<ClanInfo>> SearchClansAsync(string search = null, int limit = 20, int pageNumber = 1)
        {
            var response = await GetResponseAsync<List<ClanInfo>>("wot/clans/list/?"
                .AddParamIfNotExist("search", search).AddParamIfNotExist("limit", limit).AddParamIfNotExist("page_no", pageNumber));
            return response.Data;
        }

        public async Task<Clan> GetClanByIdAsync(int clanId)
        {
            var response = await GetResponseAsync<Dictionary<string, Clan>>("wot/clans/info/?"
                .AddParamIfNotExist("clan_id", clanId).AddParamIfNotExist("members_key","id").AddParamIfNotExist("extra", "private.online_members"));
            return response.Data.First().Value;
        }

        public async Task<ClanMemberInfo> GetClanMemberInfoAsync(int accountId)
        {
            var response = await GetResponseAsync<Dictionary<string, ClanMemberInfo>>("wot/clans/accountinfo/?");
            return response.Data.First().Value;
        }

        public async Task<ClansRoles> GetClanRolesAsync()
        {
            var response = await GetResponseAsync<Dictionary<string, ClansRoles>>("wot/clans/glossary/?");
            return response.Data.First().Value;
        }
    }
}
