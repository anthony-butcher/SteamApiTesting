namespace Steam.Models
{
    public class Enums
    {
        public enum SteamGames
        {
            CsGo = 730
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
}