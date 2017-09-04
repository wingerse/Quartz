using System.Collections.Generic;

namespace Quartz.Text
{
    public abstract class Token
    {
        public const char DefaultControlChar = '§';

        private Token()
        {
        }

        public abstract override string ToString();

        public sealed class Text : Token
        {
            public string Value { get; }

            public Text(string value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return Value;
            }
        }

        public sealed class Codes : Token
        {
            public List<Code> Value { get; }

            public Codes(List<Code> value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return string.Join(",", Value);
            }
        }
    }
}
