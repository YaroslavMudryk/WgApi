namespace WgApi.Console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WgApi("test1", "test2");

            var result = await client.Wargaming.SearchAccountsAsync("Rozvidnyk");

            var rs = await client.Wargaming.GetAccountInfoAsync(result.First().AccountId);

            var a = await client.WorldOfTanks.SearchAccountsAsync(result.First().Nickname);
        }
    }
}
