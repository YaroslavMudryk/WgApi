using WgApi.Models;
using WgApi.Models.ApiContracts;

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
    }
}
