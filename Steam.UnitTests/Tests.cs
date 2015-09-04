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
            var repositories = Container.Resolve<IPlayerRepository>();

            var result = repositories.Get(Constants.SteamIds.Mine);
        }
    }
}