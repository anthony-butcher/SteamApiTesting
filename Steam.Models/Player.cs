namespace Steam.Models
{
    using System;
    using System.Diagnostics;
    using Newtonsoft.Json;
    using Steam.Utils;

    [DebuggerDisplay("{PersonaName} - {SteamId}")]
    public class Player
    {
        [JsonProperty(PropertyName = "steamid")]
        public string SteamId { get; set; }

        [JsonProperty(PropertyName = "communityvisibilitystate")]
        public CommunityVisibilityState CommunityVisibilityState { get; set; }

        [JsonProperty(PropertyName = "profilestate")]
        public int ProfileState { get; set; }

        [JsonProperty(PropertyName = "personaname")]
        public string PersonaName { get; set; }

        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "avatarmedium")]
        public string AvatarMedium { get; set; }

        [JsonProperty(PropertyName = "avatarfull")]
        public string AvatarFull { get; set; }

        [JsonProperty(PropertyName = "personastate")]
        public PersonaStates PersonaState { get; set; }

        [JsonProperty(PropertyName = "primaryclanid")]
        public string PrimaryClanId { get; set; }

        [JsonProperty(PropertyName = "loccountrycode")]
        public string LocCountryCode { get; set; }

        [JsonProperty(PropertyName = "lastlogoff")]
        [JsonConverter(typeof(UnixDateConverter))]
        public DateTime LastLogoff { get; set; }

        [JsonProperty(PropertyName = "timecreated")]
        [JsonConverter(typeof(UnixDateConverter))]
        public DateTime TimeCreated { get; set; }

    }
}