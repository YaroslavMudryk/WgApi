namespace WgApi.Console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WgApi("test1", "test2");

            var result = await client.WorldOfTanks.SearchAccountsAsync("Rozvidnyk");

            var rozvidnyk = result.First();

            var a = await client.WorldOfTanks.GetAccountByIdAsync(rozvidnyk.AccountId);

            var maxFragsTank = a.Statistics.Frags.MaxBy(s => s.Value);

            var rs = await client.WorldOfTanks.GetUsersTankStatisticsAsync(rozvidnyk.AccountId, Convert.ToInt32(maxFragsTank.Key));

            var da = await client.WorldOfTanks.GetAccountAchievementsAsync(rozvidnyk.AccountId);
        }
    }
}
