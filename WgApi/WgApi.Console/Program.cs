namespace WgApi.Console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WgApi("41449282bd410a217000d01702c80fc5", "13851dfcc94c7c9952c09f38d2ee281dd531f6f9");

            var result = await client.WorldOfTanks.SearchAccountsAsync("Test");

            var tankist = result.First();

            var a = await client.WorldOfTanks.GetAccountByIdAsync(tankist.AccountId);

            var myClan = await client.WorldOfTanks.GetClanByIdAsync(a.ClanId);

            var maxFragsTank = a.Statistics.Frags.MaxBy(s => s.Value);

            var rs = await client.WorldOfTanks.GetUsersTankStatisticsAsync(tankist.AccountId, Convert.ToInt32(maxFragsTank.Key));

            var da = await client.WorldOfTanks.GetAccountAchievementsAsync(tankist.AccountId);
        }
    }
}
