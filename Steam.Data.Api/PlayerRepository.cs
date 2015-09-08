namespace Steam.Data.Api
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;
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
                Constants.ApiInterfaces.SteamUser,
                Constants.ApiMethods.GetPlayerSummaries,
                Constants.ApiKey,
                steamId);

            var result = this.GetResult<GetPlayerSummariesResponse>(url);

            return result.response.players.FirstOrDefault();
        }

        public PlayerStats GetPlayerStats(string steamId, Enums.SteamGames game)
        {
            var url = String.Format("{0}/{1}/{2}?key={3}&steamid={4}&appid={5}",
                Constants.ApiBaseUrl,
                Constants.ApiInterfaces.SteamUserStats,
                Constants.ApiMethods.GetUserStatsForGame,
                Constants.ApiKey,
                steamId,
                (int)game);

            var result = this.GetResult<PlayerStatsResponse>(url);

            return result.playerStats;
        }

        private T GetResult<T>(string url)
        {
            var result = this._webClient.Get(url);

            var deserialized = JsonConvert.DeserializeObject<T>(result);

            return deserialized;
        }
    }
}