namespace Steam.Data.Api
{
    using System;
    using System.Linq;
    using Steam.Models;
    using Steam.Models.ResponseWrappers;

    public class PlayerRepository : IPlayerRepository
    {
        private readonly IWebClient _webClient;

        public PlayerRepository(IWebClient webClient)
        {
            if (webClient == null)
            {
                throw new ArgumentNullException("webClient");
            }

            this._webClient = webClient;
        }

        public Player Get(string steamId)
        {
            var url = String.Format("{0}/{1}/{2}?key={3}&steamids={4}",
                Constants.ApiBaseUrl,
                EnumAdapters.AdaptApiInterface(ApiInterfaces.SteamUser),
                EnumAdapters.AdaptApiMethod(ApiMethods.GetPlayerSummaries),
                Constants.ApiKey,
                steamId);

            var result = this._webClient.Get(url);

            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<GetPlayerSummariesResponse>(result);

            return deserialized.response.players.FirstOrDefault();
        }
    }
}