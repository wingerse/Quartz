using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quartz.Text.Chat;
using Xunit;
using Xunit.Abstractions;

namespace Quartz.UnitTests.Text.UnitTests.Chat.UnitTests
{
    public class TextComponentTests
    {
        private readonly ITestOutputHelper _output;

        public TextComponentTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Correct_Serialization()
        {
            var str = JsonConvert.SerializeObject(
                new StringComponent("hello world")
                {
                    Bold = true,
                    ClickEvent = new ClickEvent(ClickEvent.ActionEnum.OpenUrl, "google.com"),
                    HoverEvent =
                        new HoverEvent(HoverEvent.ActionEnum.ShowText, new StringComponent("hi i'm a hover event")),
                    Extra = new List<ChatComponent>
                    {
                        new TranslationComponent("something", new ChatComponent[] {new StringComponent("gui")})
                    }
                }
            );
            Assert.Equal(
                "{\"text\":\"hello world\",\"bold\":true,\"clickEvent\":{\"action\":\"open_url\",\"value\":\"google.com\"},\"hoverEvent\":{\"action\":\"show_text\",\"value\":{\"text\":\"hi i\'m a hover event\"}},\"extra\":[{\"translate\":\"something\",\"with\":[{\"text\":\"gui\"}]}]}",
                str);
        }

        [Fact]
        public void Correct_Deserialization_RootObject()
        {
            var str =
                "{\"text\":\"hello world\",\"bold\":true,\"clickEvent\":{\"action\":\"open_url\",\"value\":\"google.com\"},\"hoverEvent\":{\"action\":\"show_text\",\"value\":{\"text\":\"hi i\'m a hover event\"}},\"extra\":[{\"translate\":\"something\",\"with\":[{\"text\":\"gui\"}]}]}";
            var obj = JsonConvert.DeserializeObject<ChatComponent>(str,
                new JsonSerializerSettings {Converters = new List<JsonConverter> {new ChatComponent.Converter()}});
            Assert.IsType<StringComponent>(obj);
            Assert.Equal("something", ((TranslationComponent) ((StringComponent) obj).Extra[0]).Translate);
            Assert.Equal("google.com", obj.ClickEvent.Value);
        }

        [Fact]
        public void Correct_Deserialization_RootPrimitive()
        {
            var str = "\"hello world\"";
            var obj = JsonConvert.DeserializeObject<ChatComponent>(str,
                new JsonSerializerSettings {Converters = new List<JsonConverter> {new ChatComponent.Converter()}});
            Assert.Equal("hello world", ((StringComponent) obj).Text);
        }

        [Fact]
        public void Correct_Deserialization_RootArray()
        {
            var str = "[\"hello\", 1, true, {\"text\":\"hey\"}]";
            var obj = JsonConvert.DeserializeObject<ChatComponent>(str,
                new JsonSerializerSettings {Converters = new List<JsonConverter> {new ChatComponent.Converter()}});
            Assert.IsType<StringComponent>(obj);
            var root = (StringComponent) obj;
            Assert.Equal("hello", root.Text);
            Assert.Equal("1", ((StringComponent) root.Extra[0]).Text);
            Assert.Equal("True", ((StringComponent) root.Extra[1]).Text);
            Assert.Equal("hey", ((StringComponent) root.Extra[2]).Text);
        }
    }
}
