using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Quartz.Text.Chat
{
    [JsonConverter(typeof(Converter))]
    public sealed class ChatColor
    {
        private readonly string _value;

        public static readonly ChatColor Black = new ChatColor("black");
        public static readonly ChatColor DarkBlue = new ChatColor("dark_blue");
        public static readonly ChatColor DarkGreen = new ChatColor("dark_green");
        public static readonly ChatColor DarkCyan = new ChatColor("dark_aqua");
        public static readonly ChatColor DarkRed = new ChatColor("dark_red");
        public static readonly ChatColor Purple = new ChatColor("dark_purple");
        public static readonly ChatColor Gold = new ChatColor("gold");
        public static readonly ChatColor Gray = new ChatColor("gray");
        public static readonly ChatColor DarkGray = new ChatColor("dark_gray");
        public static readonly ChatColor Blue = new ChatColor("blue");
        public static readonly ChatColor BrightGreen = new ChatColor("green");
        public static readonly ChatColor Cyan = new ChatColor("aqua");
        public static readonly ChatColor Red = new ChatColor("red");
        public static readonly ChatColor Pink = new ChatColor("light_purple");
        public static readonly ChatColor Yellow = new ChatColor("yellow");
        public static readonly ChatColor White = new ChatColor("white");
        public static readonly ChatColor Reset = new ChatColor("reset");

        private static readonly ChatColor[] Values = {
            Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, Purple, Gold, Gray, DarkGray, Blue, BrightGreen, Cyan, Red,
            Pink, Yellow, White, Reset
        };
        private static readonly Dictionary<string, ChatColor> ReverseMapping;
        
        static ChatColor()
        {
            ReverseMapping = Values.ToDictionary(e => e._value);
        }

        private ChatColor(string value)
        {
            _value = value;
        }

        public override string ToString() => _value;

        private sealed class Converter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                writer.WriteValue(value.ToString());
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                JsonSerializer serializer)
            {
                if (reader.TokenType != JsonToken.String)
                {
                    throw new JsonSerializationException(
                        $"{nameof(ChatColor)} should be a string but it's a {reader.TokenType}");
                }
                if (!ReverseMapping.TryGetValue((string) reader.Value, out ChatColor color))
                {
                    throw new JsonSerializationException($"Invalid {nameof(ChatColor)}");
                }
                return color;
            }

            public override bool CanConvert(Type objectType) => objectType == typeof(ChatColor);
        }
    }
}
