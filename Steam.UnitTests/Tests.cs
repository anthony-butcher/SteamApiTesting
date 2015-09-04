namespace Steam.UnitTests
{
    using NUnit.Framework;
    using Steam.Models;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var webClient = new WebClient();

            var result = webClient.QueryApi(
                ApiInterfaces.SteamUserStats,
                ApiMethods.GetUserStatsForGame,
                Enums.CsGo,
                "76561197969877387");

            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<Steam.Models.PlayerStatsResponse>(result);
        }

        [Test]
        public void Test2()
        {
            var webClient = new WebClient();

            var result = webClient.QueryApi(
                ApiInterfaces.SteamUser,
                ApiMethods.GetPlayerSummaries,
                Enums.CsGo,
                "76561197969877387");

            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<Steam.Models.PlayerStatsResponse>(result);
        }
    }
}