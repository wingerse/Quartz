using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Quartz.Text.Chat
{
    [JsonConverter(typeof(Converter))]
    public sealed class ChatColor
    {
        public string Name { get; }
        public sbyte Numeric { get; }
        
        private ChatColor(sbyte numeric, string name)
        {
            Numeric = numeric;
            Name = name;
        }

        public static readonly ChatColor Black = new ChatColor(0, "black");
        public static readonly ChatColor DarkBlue = new ChatColor(1, "dark_blue");
        public static readonly ChatColor DarkGreen = new ChatColor(2, "dark_green");
        public static readonly ChatColor DarkCyan = new ChatColor(3, "dark_aqua");
        public static readonly ChatColor DarkRed = new ChatColor(4, "dark_red");
        public static readonly ChatColor Purple = new ChatColor(5, "dark_purple");
        public static readonly ChatColor Gold = new ChatColor(6, "gold");
        public static readonly ChatColor Gray = new ChatColor(7, "gray");
        public static readonly ChatColor DarkGray = new ChatColor(8, "dark_gray");
        public static readonly ChatColor Blue = new ChatColor(9, "blue");
        public static readonly ChatColor BrightGreen = new ChatColor(10, "green");
        public static readonly ChatColor Cyan = new ChatColor(11, "aqua");
        public static readonly ChatColor Red = new ChatColor(12, "red");
        public static readonly ChatColor Pink = new ChatColor(13, "light_purple");
        public static readonly ChatColor Yellow = new ChatColor(14, "yellow");
        public static readonly ChatColor White = new ChatColor(15, "white");
        public static readonly ChatColor Reset = new ChatColor(-1, "reset");

        private static readonly ChatColor[] Values = {
            Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, Purple, Gold, Gray, DarkGray, Blue, BrightGreen, Cyan, Red,
            Pink, Yellow, White, Reset
        };
        private static readonly Dictionary<string, ChatColor> FromName;
        
        static ChatColor()
        {
            FromName = Values.ToDictionary(e => e.Name);
        }

        public override string ToString() => Name;

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
                if (!FromName.TryGetValue((string) reader.Value, out ChatColor color))
                {
                    throw new JsonSerializationException($"Invalid {nameof(ChatColor)}");
                }
                return color;
            }

            public override bool CanConvert(Type objectType) => objectType == typeof(ChatColor);
        }
    }
}
