using Newtonsoft.Json;
using Xunit;
using Quartz.Text.Chat;

namespace Quartz.UnitTests.Text.UnitTests.Chat.UnitTests
{
    public class ChatTests
    {
        [Fact]
        public void Correct_Serialization()
        {
            var chat = new ChatRoot(new StringComponent("hello world"));
            var str = JsonConvert.SerializeObject(chat);
            Assert.Equal("{\"text\":\"hello world\"}", str);
        }

        [Fact]
        public void Correct_Deserialization()
        {
            var str =
                "{\"text\":\"hello world\",\"bold\":true,\"clickEvent\":{\"action\":\"open_url\",\"value\":\"google.com\"},\"hoverEvent\":{\"action\":\"show_text\",\"value\":{\"text\":\"hi i\'m a hover event\"}},\"extra\":[{\"translate\":\"something\",\"with\":[{\"text\":\"gui\"}]}]}";
            var chat = JsonConvert.DeserializeObject<ChatRoot>(str);
            Assert.Equal("google.com", chat.Root.ClickEvent.Value);
        }

        [Fact]
        public void Error_On_Bad_Root()
        {
            var str = "\"hello world\"";
            Assert.ThrowsAny<JsonException>(() => JsonConvert.DeserializeObject<ChatRoot>(str));
            var str2 = "True";
            Assert.ThrowsAny<JsonException>(() => JsonConvert.DeserializeObject<ChatRoot>(str2));
        }
    }
}
