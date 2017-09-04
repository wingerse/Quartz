using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Quartz.Text.Chat
{
    public sealed class ClickEvent
    {
        [JsonProperty("action", Required = Required.Always)]
        public ActionEnum Action { get; set; }
        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }

        public ClickEvent(ActionEnum action, string value)
        {
            Action = action;
            Value = value;
        }

        [JsonConverter(typeof(Converter))]
        public sealed class ActionEnum
        {
            private readonly string _value;
            
            public static readonly ActionEnum OpenUrl = new ActionEnum("open_url");
            public static readonly ActionEnum RunCommand = new ActionEnum("run_command");
            public static readonly ActionEnum SuggestCommand = new ActionEnum("suggest_command");
            public static readonly ActionEnum ChangePage = new ActionEnum("change_page");

            private static readonly Dictionary<string, ActionEnum> ReverseMapping;
            private static readonly ActionEnum[] Values = {OpenUrl, RunCommand, SuggestCommand, ChangePage};
            
            private ActionEnum(string value)
            {
                _value = value;
            }

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
