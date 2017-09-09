using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Quartz.Text.Chat
{
    /// <summary>
    /// A chat component. All members of this class (Not including subclasses) can be null.
    /// </summary>
    public abstract class ChatComponent
    {
        [JsonProperty("bold", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Bold { get; set; }

        [JsonProperty("italic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Italic { get; set; }

        [JsonProperty("underlined", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Underlined { get; set; }

        [JsonProperty("strikethrough", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Strikethrough { get; set; }

        [JsonProperty("obfuscated", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Obfuscated { get; set; }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatColor Color { get; set; }

        [JsonProperty("insertion", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Insertion { get; set; }

        [JsonProperty("clickEvent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ClickEvent ClickEvent { get; set; }

        [JsonProperty("hoverEvent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HoverEvent HoverEvent { get; set; }

        [JsonProperty("extra", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ChatComponent> Extra { get; set; }

        private bool ShouldSerializeExtra() => Extra != null && Extra.Count != 0;
        
        internal ChatComponent()
        {
        }

        public sealed class Converter : JsonConverter
        {
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                JsonSerializer serializer)
            {
                var tok = JToken.Load(reader);
                switch (tok)
                {
                    case JArray x:
                        var arr = x.ToObject<ChatComponent[]>(serializer);
                        if (arr.Length == 0) throw new JsonSerializationException("0 length arrays not allowed");
                        var first = arr[0];
                        var list = first.Extra ?? new List<ChatComponent>();
                        list.AddRange(arr.Skip(1));
                        first.Extra = list;
                        return first;
                    case JObject x:
                        var dic = (IDictionary<string, JToken>)x;
                        if (dic.ContainsKey("text")) return x.ToObject<StringComponent>(serializer);
                        else if (dic.ContainsKey("translate")) return x.ToObject<TranslationComponent>(serializer);
                        else if (dic.ContainsKey("keybind")) return x.ToObject<KeybindComponent>(serializer);
                        else if (dic.ContainsKey("score")) return x.ToObject<ScoreComponent>(serializer);
                        else if (dic.ContainsKey("selector")) return x.ToObject<SelectorComponent>(serializer);
                        else throw new JsonSerializationException("Invalid component");
                    case JValue x:
                        return new StringComponent(x.Value.ToString());
                    default:
                        throw new JsonSerializationException("Component should be an array, object or primitive.");
                }
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
                throw new NotImplementedException();

            public override bool CanWrite => false;
            public override bool CanConvert(Type objectType) => objectType == typeof(ChatComponent);
        }
    }

    public sealed class StringComponent : ChatComponent
    {
        [JsonProperty("text", Required = Required.Always)]
        public string Text { get; set; }

        public StringComponent(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Parses a legacy minecraft string into a StringComponent.
        /// Invalid codes are turned into regular text.
        /// </summary>
        public static StringComponent Parse(string legacy, char controlChar = Token.DefaultControlChar)
        {
            var root = new StringComponent(string.Empty);
            var lastComponent = root;
            var lastColorComponent = root;
            var lastFormattingComponent = root;

            void AppendLastFormattingCom()
            {
                if (lastFormattingComponent.Text != string.Empty && lastFormattingComponent != root)
                {
                    if (lastColorComponent.Extra == null) lastColorComponent.Extra = new List<ChatComponent>();
                    lastColorComponent.Extra.Add(lastFormattingComponent);
                }
            }

            void AppendLastColorCom()
            {
                if (lastColorComponent.Text != string.Empty && lastColorComponent != root)
                {
                    if (root.Extra == null) root.Extra = new List<ChatComponent>();
                    root.Extra.Add(lastColorComponent);
                }
            }

            var tokenizer = new Tokenizer(legacy, controlChar);
            foreach (var token in tokenizer)
            {
                switch (token)
                {
                    case Token.Codes x:
                        var codes = x.Value;
                        RemoveRedundantCodes(codes);
                        if (codes[0].IsColor())
                        {
                            AppendLastFormattingCom();
                            AppendLastColorCom();
                            lastColorComponent = new StringComponent(string.Empty);
                            lastFormattingComponent = new StringComponent(string.Empty);
                            lastColorComponent.Color = ColorCodeToChatColor(codes[0]);
                            if (codes.Count > 0)
                            {
                                foreach (var code in codes.Skip(1))
                                {
                                    SetFormattingStyle(lastColorComponent, code);
                                }
                            }
                            lastComponent = lastColorComponent;
                        }
                        else
                        {
                            AppendLastFormattingCom();
                            lastFormattingComponent = new StringComponent(string.Empty);
                            foreach (var code in codes)
                            {
                                SetFormattingStyle(lastFormattingComponent, code);
                            }
                            lastComponent = lastFormattingComponent;
                        }
                        break;
                    case Token.Text x:
                        lastComponent.Text += x.Value; // =+ needed because tokenizer may return string and string again consecutively.
                        break;
                }
            }
            AppendLastFormattingCom();
            AppendLastColorCom();

            return root;
        }

        /// <summary>
        /// Removes any code which is to the left of a color code, because color code overrides everything.
        /// </summary>
        private static void RemoveRedundantCodes(List<Code> codes)
        {
            var index = codes.FindLastIndex(c => c.IsColor());
            if (index == -1) return;
            codes.RemoveRange(0, index);
        }

        private static void SetFormattingStyle(StringComponent component, Code code)
        {
            switch (code)
            {
                case Code.Obfuscated:
                    component.Obfuscated = true;
                    break;
                case Code.Bold:
                    component.Bold = true;
                    break;
                case Code.Italic:
                    component.Italic = true;
                    break;
                case Code.StrikeThrough:
                    component.Strikethrough = true;
                    break;
                case Code.Underlined:
                    component.Underlined = true;
                    break;
            }
        }

        private static ChatColor ColorCodeToChatColor(Code color)
        {
            switch (color)
            {
                case Code.Black: return ChatColor.Black;
                case Code.DarkBlue: return ChatColor.DarkBlue;
                case Code.DarkGreen: return ChatColor.DarkGreen;
                case Code.DarkCyan: return ChatColor.DarkCyan;
                case Code.DarkRed: return ChatColor.DarkRed;
                case Code.Purple: return ChatColor.Purple;
                case Code.Gold: return ChatColor.Gold;
                case Code.Gray: return ChatColor.Gray;
                case Code.DarkGray: return ChatColor.DarkGray;
                case Code.Blue: return ChatColor.Blue;
                case Code.BrightGreen: return ChatColor.BrightGreen;
                case Code.Cyan: return ChatColor.Cyan;
                case Code.Red: return ChatColor.Red;
                case Code.Pink: return ChatColor.Pink;
                case Code.Yellow: return ChatColor.Yellow;
                case Code.White: return ChatColor.White;
                default: return ChatColor.Reset;
            }
        }
    }

    public sealed class TranslationComponent : ChatComponent
    {
        [JsonProperty("translate", Required = Required.Always)]
        public string Translate { get; set; }

        [JsonProperty("with", Required = Required.Always)]
        public ChatComponent[] With { get; set; }

        public TranslationComponent(string translate, ChatComponent[] with)
        {
            Translate = translate;
            With = with;
        }
    }

    public sealed class KeybindComponent : ChatComponent
    {
        [JsonProperty("keybind", Required = Required.Always)]
        public string Keybind { get; set; }

        public KeybindComponent(string keybind)
        {
            Keybind = keybind;
        }
    }

    public sealed class ScoreComponent : ChatComponent
    {
        [JsonProperty("score", Required = Required.Always)]
        public Score ScoreProperty { get; set; }

        public ScoreComponent(Score scoreProperty)
        {
            ScoreProperty = scoreProperty;
        }

        public sealed class Score
        {
            [JsonProperty("name", Required = Required.Always)]
            public string Name { get; set; }

            [JsonProperty("objective", Required = Required.Always)]
            public string Objective { get; set; }

            [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Value { get; set; }
        }
    }

    public sealed class SelectorComponent : ChatComponent
    {
        [JsonProperty("selector", Required = Required.Always)]
        public string Selector { get; set; }

        public SelectorComponent(string selector)
        {
            Selector = selector;
        }
    }
}
