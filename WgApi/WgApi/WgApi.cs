using System;
using WgApi.Services;

namespace WgApi
{
    public class WgApi : IWgApi
    {
        private readonly string _accessToken;
        private readonly string _applicationId;
        private readonly string _baseUrl;

        public WgApi(string applicationId, string accessToken = null, string baseUrl = null) : this()
        {
            _applicationId = applicationId;
            _accessToken = accessToken;
            _baseUrl = baseUrl ?? "https://api.worldoftanks.eu";
        }

        private WgApi()
        {
            WorldOfTanks = new WorldOfTanksService(_applicationId, _accessToken, _baseUrl);
            WorldOfTanksBlitz = new WorldOfTanksBlitzService(_applicationId, _accessToken, _baseUrl);
            WorldOfTanksConsole = new WorldOfTanksConsoleService(_applicationId, _accessToken, _baseUrl);
            WorldOfWarplanes = new WorldOfWarplanesService(_applicationId, _accessToken, _baseUrl);
            WorldOfWarships = new WorldOfWarshipsService(_applicationId, _accessToken, _baseUrl);
            Wargaming = new WargamingNetService(_applicationId, _accessToken, _baseUrl);
        }

        public WorldOfTanksService WorldOfTanks { get; }

        public WorldOfTanksBlitzService WorldOfTanksBlitz { get; }

        public WorldOfTanksConsoleService WorldOfTanksConsole { get; }

        public WorldOfWarplanesService WorldOfWarplanes { get; }

        public WorldOfWarshipsService WorldOfWarships { get; }
        public WargamingNetService Wargaming { get; }
    }
}
