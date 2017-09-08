using System;
using EncodingLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quartz.Proto;

namespace Quartz.Text.Chat
{
    /// <summary>
    /// Represents the root of a chat.
    /// </summary>
    [JsonConverter(typeof(Converter))]
    public sealed class ChatRoot
    {
        public ChatComponent Root { get; set; }
        
        private static readonly JsonConverter RootConverter = new ChatComponent.Converter();
        
        public ChatRoot(ChatComponent root)
        {
            Root = root;
        }
        
        private sealed class Converter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, ((ChatRoot)value).Root);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var tok = JToken.Load(reader);
                if (!(tok is JObject || tok is JArray))
                {
                    throw new JsonSerializationException("Root component should be an array or object.");
                }
                
                serializer.Converters.Add(RootConverter);
                return new ChatRoot(tok.ToObject<ChatComponent>(serializer));
            }

            public override bool CanConvert(Type objectType) => objectType == typeof(ChatRoot);
        }
    }

    public static class ChatRootEx
    {
        public static void WriteChatRootProto(this PrimitiveWriter writer, ChatRoot chatRoot)
        {
            writer.WriteStringProto(JsonConvert.SerializeObject(chatRoot));
        }

        public static ChatRoot ReadChatRootProto(this PrimitiveReader reader)
        {
            return JsonConvert.DeserializeObject<ChatRoot>(reader.ReadStringProto(ProtoConsts.MaxStringChars));
        }
    }
}
