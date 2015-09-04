namespace Steam
{
    using System;
    using Steam.Models;

    public class EnumAdapters
    {
        public static string AdaptApiMethod(ApiMethods method)
        {
            switch (method)
            {
                case ApiMethods.GetNewsForApp:
                    return "GetNewsForApp";

                case ApiMethods.GetGlobalAchievementPercentagesForApp:
                    return "GetGlobalAchievementPercentagesForApp";

                case ApiMethods.GetGlobalStatsForGame:
                    return "GetGlobalStatsForGame";

                case ApiMethods.GetPlayerSummaries:
                    return "GetPlayerSummaries/v0002";

                case ApiMethods.GetFriendList:
                    return "GetFriendList";

                case ApiMethods.GetPlayerAchievements:
                    return "GetPlayerAchievements";

                case ApiMethods.GetUserStatsForGame:
                    return "GetUserStatsForGame/v0002";

                case ApiMethods.GetOwnedGames:
                    return "GetOwnedGames";

                case ApiMethods.GetRecentlyPlayedGames:
                    return "GetRecentlyPlayedGames";

                case ApiMethods.IsPlayingSharedGame:
                    return "IsPlayingSharedGame";

                case ApiMethods.GetSchemaForGame:
                    return "GetSchemaForGame";

                case ApiMethods.GetPlayerBans:
                    return "GetPlayerBans";

                default:
                    throw new ArgumentOutOfRangeException("method");
            }
        }

        public static string AdaptApiInterface(ApiInterfaces inter)
        {
            switch (inter)
            {
                case ApiInterfaces.SteamUser:
                    return "ISteamUser";
                case ApiInterfaces.SteamUserStats:
                    return "ISteamUserStats";
                case ApiInterfaces.SteamNews:
                    return "ISteamNews";
                case ApiInterfaces.PlayerService:
                    return "IPlayerService";
                default:
                    throw new ArgumentOutOfRangeException("inter");
            }
        }
    }
}