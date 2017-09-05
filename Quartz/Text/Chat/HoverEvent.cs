using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Quartz.Text.Chat
{
    public sealed class HoverEvent
    {
        [JsonProperty("action", Required = Required.Always)]
        public ActionEnum Action { get; set; }
        [JsonProperty("value", Required = Required.Always)]
        public ChatComponent Value { get; set; }

        public HoverEvent(ActionEnum action, ChatComponent value)
        {
            Action = action;
            Value = value;
        }

        [JsonConverter(typeof(Converter))]
        public sealed class ActionEnum
        {
            private readonly string _value;
            
            private ActionEnum(string value)
            {
                _value = value;
            }
            
            public static readonly ActionEnum ShowText = new ActionEnum("show_text");
            public static readonly ActionEnum ShowItem = new ActionEnum("show_item");
            public static readonly ActionEnum ShowEntity = new ActionEnum("show_entity");

            private static readonly Dictionary<string, ActionEnum> ReverseMapping;
            private static readonly ActionEnum[] Values = {ShowText, ShowItem, ShowEntity};

            static ActionEnum()
            {
                ReverseMapping = Values.ToDictionary(e => e._value);
            }

            public override string ToString() => _value;

            private sealed class Converter : JsonConverter
            {
                public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
                {
                    writer.WriteValue(((ActionEnum)value).ToString());
                }

                public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
                {
                    if (reader.TokenType != JsonToken.String)
                    {
                        throw new JsonSerializationException($"{nameof(ActionEnum)} has to be a string");
                    }
                    if (!ReverseMapping.TryGetValue((string)reader.Value, out ActionEnum a))
                    {
                        throw new JsonSerializationException($"Invalid {nameof(ActionEnum)}");
                    }
                    return a;
                }

                public override bool CanConvert(Type objectType) => objectType == typeof(ActionEnum);
            }
        }
    }
}
