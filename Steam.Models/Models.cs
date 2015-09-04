namespace Steam.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class PlayerStats
    {
        public string steamID { get; set; }
        public string gameName { get; set; }
        public List<Stat> stats { get; set; }
        public List<Stat> achievements { get; set; }
    }

    [DebuggerDisplay("{steamid}")]
    public class Player
    {
        public string steamid { get; set; }
        public CommunityVisibilityState communityvisibilitystate { get; set; }
        public int profilestate { get; set; }
        public string personaname { get; set; }
        [JsonProperty(ItemConverterType = typeof(MyDateConverter))]
        [JsonConverter(typeof(MyDateConverter))]
        public DateTime lastlogoff { get; set; }
        public string profile { get; set; }
        public string avatar { get; set; }
        public string avatarmedium { get; set; }
        public string avatarfull { get; set; }
        public PersonaStates personastate { get; set; }
        public string primaryclanid { get; set; }
        [JsonProperty(ItemConverterType = typeof(MyDateConverter))]
        public DateTime timecreated { get; set; }
        public string loccountrycode { get; set; }
    }

    public class MyDateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }
    }

    [DebuggerDisplay("{name} - {value}")]
    public class Stat
    {
        public string name { get; set; }
        public object value { get; set; }
    }
}