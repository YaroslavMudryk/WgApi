namespace WgApi.Console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WgApi("test1", "test2");

            var result = await client.Wargaming.SearchAccountsAsync("Test");

            var rs = await client.WorldOfTanks.GetAccountByIdAsync(result.First().AccountId);

            var a = await client.WorldOfTanks.SearchAccountsAsync(result.First().Nickname);
        }
    }
}
