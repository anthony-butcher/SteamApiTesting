namespace Steam.Models
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Newtonsoft.Json;

    [DebuggerDisplay("{SteamId} - {GameName}")]
    public class PlayerStats
    {
        [JsonProperty(PropertyName = "steamID")]
        public string SteamId { get; set; }

        [JsonProperty(PropertyName = "gameName")]
        public string GameName { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty(PropertyName = "achievements")]
        public List<Stat> Achievements { get; set; }
    }
}