using Newtonsoft.Json;
using Quartz.Text.Chat;
using Xunit;

namespace Quartz.UnitTests.Text.UnitTests.Chat.UnitTests
{
    public class StringComponentTests
    {
        [Fact]
        public void Parse_RedundantRemoved()
        {
            var str = "&f&la&6&l&o&f&la";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"\",\"extra\":[{\"text\":\"a\",\"bold\":true,\"color\":\"white\"},{\"text\":\"a\",\"bold\":true,\"color\":\"white\"}]}", res);
        }

        [Fact]
        public void Parse_Root_Text()
        {
            var str = "hello world";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"hello world\"}", res);
        }

        [Fact]
        public void Parse_Root_Text_And_Extra()
        {
            var str = "hahaha &l fresh meat&4a";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"hahaha \",\"extra\":[{\"text\":\" fresh meat\",\"bold\":true},{\"text\":\"a\",\"color\":\"dark_red\"}]}", res);
        }

        [Fact]
        public void Parse_Bad_Code_Becomes_Text()
        {
            var str = "hahaha &h fresh meat&4a";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"hahaha &h fresh meat\",\"extra\":[{\"text\":\"a\",\"color\":\"dark_red\"}]}", res);

            str = "&hhahaha &h fresh meat&4a";
            com = StringComponent.Parse(str, '&');
            res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"&hhahaha &h fresh meat\",\"extra\":[{\"text\":\"a\",\"color\":\"dark_red\"}]}", res);
        }

        [Fact]
        public void Parse_Accept_Capitalized_Code()
        {
            var str = "&Fhello world";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"\",\"extra\":[{\"text\":\"hello world\",\"color\":\"white\"}]}", res);
        }
        
        [Fact]
        public void Parse_Bad_Code_All_Along()
        {
            var str = "&&&&&&&&&&AA";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"&&&&&&&&&&AA\"}", res);
        }
        
        [Fact]
        public void Parse_Bad_Code_All_Along_Odd()
        {
            var str = "&&&&&&&&&&&AA";
            var com = StringComponent.Parse(str, '&');
            var res = JsonConvert.SerializeObject(com);
            Assert.Equal("{\"text\":\"&&&&&&&&&&\",\"extra\":[{\"text\":\"A\",\"color\":\"green\"}]}", res);
        }
    }
}
