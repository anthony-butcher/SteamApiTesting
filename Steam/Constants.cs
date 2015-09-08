namespace Steam
{
    public class Constants
    {
        public const string ApiBaseUrl = "http://api.steampowered.com";
        public const string ApiKey = "8D8B2DAFA0C7A5F0DA2B4FA32548A006";

        public class SteamIds
        {
            public const string Mine = "76561197969877387";
        }

        public class ApiInterfaces
        {
            public const string SteamUser = "ISteamUser";
            public const string SteamUserStats = "ISteamUserStats";
            public const string SteamNews = "ISteamNews";
            public const string PlayerService = "IPlayerService";
        }

        public class ApiMethods
        {
            public const string GetNewsForApp = "GetNewsForApp";
            public const string GetGlobalAchievementPercentagesForApp = "GetGlobalAchievementPercentagesForApp";
            public const string GetGlobalStatsForGame = "GetGlobalStatsForGame";
            public const string GetPlayerSummaries = "GetPlayerSummaries/v0002";
            public const string GetFriendList = "GetFriendList";
            public const string GetPlayerAchievements = "GetPlayerAchievements";
            public const string GetUserStatsForGame = "GetUserStatsForGame/v0002";
            public const string GetOwnedGames = "GetOwnedGames";
            public const string GetRecentlyPlayedGames = "GetRecentlyPlayedGames";
            public const string IsPlayingSharedGame = "IsPlayingSharedGame";
            public const string GetSchemaForGame = "GetSchemaForGame";
            public const string GetPlayerBans = "GetPlayerBans";
        }
    }
}