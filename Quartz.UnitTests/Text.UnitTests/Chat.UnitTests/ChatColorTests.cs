using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quartz.Text.Chat;
using Xunit;
using Xunit.Abstractions;

namespace Quartz.UnitTests.Text.UnitTests.Chat.UnitTests
{
    public class ChatColorTests
    {
        private readonly ITestOutputHelper _output;

        public ChatColorTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Json_Serialization()
        {
            var color = ChatColor.Black;
            var str = JsonConvert.SerializeObject(color);
            var color2 = JsonConvert.DeserializeObject<ChatColor>(str);
            Assert.Equal(color, color2);
        }
    }
}
