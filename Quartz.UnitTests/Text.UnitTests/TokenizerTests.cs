using System.Diagnostics;
using System.Linq;
using Quartz.Text;
using Xunit;
using Xunit.Abstractions;

namespace Quartz.UnitTests.Text.UnitTests
{
    public class TokenizerTests
    {
        private readonly ITestOutputHelper _output;

        public TokenizerTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Produces_Correct_Tokens()
        {
            var test = "§1R§2e§3d§4s§5t§6o§7n§8e §9§l§mC§ar§be§ca§dt§ei§fo§1n§§";
            var tokenizer = new Tokenizer(test);
            var list = tokenizer.ToList();
            foreach (var t in list)
            {
                _output.WriteLine(t.ToString());
            }
            
            Assert.Equal('1', (char)((Token.Codes)list[0]).Value[0]);
            Assert.Equal("R", ((Token.Text)list[1]).Value);
            Assert.Equal('m', (char)((Token.Codes)list[16]).Value[2]);
        }

        [Fact]
        public void Invalid_Token_And_String_Returned_As_One()
        {
            var test = "&4&tabc";
            var tokenizer = new Tokenizer(test, '&');
            var list = tokenizer.ToList();
            Assert.Equal(2, list.Count);
            Assert.Equal(Code.DarkRed, ((Token.Codes)list[0]).Value[0]);
            Assert.Equal("&tabc", ((Token.Text)list[1]).Value);
        }
    }
}
