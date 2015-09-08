namespace Steam.Utils
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class UnixDateConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long val;
            if (value is DateTime)
            {
                val = ((DateTime)value).ToUnixTime();
            }
            else
            {
                throw new Exception("Expected date object value.");
            }
            writer.WriteValue(val);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ((Int64) reader.Value).FromUnixTime();
        }
    }
}