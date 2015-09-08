namespace Steam.UnitTests
{
    using NUnit.Framework;
    using Steam.Data.Api;
    using Steam.DI;
    using Steam.Models;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetPlayerTest()
        {
            var playerRepository = Container.Resolve<IPlayerRepository>();

            var result = playerRepository.Get(Constants.SteamIds.Mine);
        }

        [Test]
        public void GetPlayerStatsTest()
        {
            var playerRepository = Container.Resolve<IPlayerRepository>();

            var result = playerRepository.GetPlayerStats(Constants.SteamIds.Mine, Enums.SteamGames.CsGo);
        }
    }
}