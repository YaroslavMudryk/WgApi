using WgApi.Services;

namespace WgApi
{
    public interface IWgApi
    {
        WorldOfTanksService WorldOfTanks { get; }
        WorldOfTanksBlitzService WorldOfTanksBlitz { get; }
        WorldOfTanksConsoleService WorldOfTanksConsole { get; }
        WorldOfWarplanesService WorldOfWarplanes { get; }
        WorldOfWarshipsService WorldOfWarships { get; }
        public WargamingNetService Wargaming { get; }
    }
}
