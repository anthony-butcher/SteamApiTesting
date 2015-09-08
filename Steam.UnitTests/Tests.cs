namespace Steam.UnitTests
{
    using NUnit.Framework;
    using Steam.Data.Api;
    using Steam.DI;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var playerRepository = Container.Resolve<IPlayerRepository>();

            var result = playerRepository.Get(Constants.SteamIds.Mine);
        }
    }
}