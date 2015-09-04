namespace Steam.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class PlayerStatsResponse
    {
        public PlayerStats playerStats { get; set; }
    }

    public class PlayerStats
    {
        public string steamID { get; set; }
        public string gameName { get; set; }
        public List<Stat> stats { get; set; }
        public List<Stat> achievements { get; set; }
    }

    public class GetPlayerSummariesResponse
    {
        public GetPlayerSummariesWrapper response { get; set; }
    }

    public class GetPlayerSummariesWrapper
    {
        public List<Player> players { get; set; } 
    }

    public class Player
    {
        public string steamId { get; set; }
        public CommunityVisibilityState communityvisibilitystate { get; set; }
        public int profilestate { get; set; }
        public string personaname { get; set; }
        public DateTime lastlogoff { get; set; }
        public string profile { get; set; }
        public string avatar { get; set; }
        public string avatarmedium { get; set; }
        public string avatarfull { get; set; }
        public PersonaStates personastate { get; set; }
        public string primaryclanid { get; set; }
        public DateTime timecreated { get; set; }
        public string loccountrycode { get; set; }
    }

    [DebuggerDisplay("{name} - {value}")]
    public class Stat
    {
        public string name { get; set; }
        public object value { get; set; }
    }
}