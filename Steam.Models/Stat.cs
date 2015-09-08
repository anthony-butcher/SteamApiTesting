namespace Steam.Models
{
    using System.Diagnostics;
    using Newtonsoft.Json;

    [DebuggerDisplay("{name} - {value}")]
    public class Stat
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }
    }
}