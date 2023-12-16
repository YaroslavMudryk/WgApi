﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace WgApi.Helpers.Converters
{
    public class UnixEpochTimeToDateTimeJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonNumber = reader.GetInt64();

            return DateTimeOffset
                .FromUnixTimeSeconds(jsonNumber)
                .UtcDateTime;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var unixTime = ((DateTimeOffset)value).ToUnixTimeSeconds();

            writer.WriteNumberValue(unixTime);
        }
    }
}
