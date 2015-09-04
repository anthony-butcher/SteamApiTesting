namespace Steam.Models
{
    public enum ApiInterfaces
    {
        SteamUser,
        SteamUserStats,
        SteamNews,
        PlayerService
    }

    public enum Enums
    {
        CsGo = 730
    }

    public enum ApiMethods
    {
        GetNewsForApp,
        GetGlobalAchievementPercentagesForApp,
        GetGlobalStatsForGame,
        GetPlayerSummaries,
        GetFriendList,
        GetPlayerAchievements,
        GetUserStatsForGame,
        GetOwnedGames,
        GetRecentlyPlayedGames,
        IsPlayingSharedGame,
        GetSchemaForGame,
        GetPlayerBans
    }

    public enum PersonaStates
    {
        Offline = 0,
        Online = 1,
        Busy = 2,
        Away = 3,
        Snooze = 4,
        LookingToTrade = 5,
        LookingToPlay = 6
    }

    public enum CommunityVisibilityState
    {
        NotVisible = 1,
        Public = 3
    }
}