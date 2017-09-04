using System;
using System.Collections;
using System.Collections.Generic;

namespace Quartz.Text
{
    public sealed class Tokenizer : IEnumerable<Token>
    {
        public string Str;
        public char ControlChar;

        public Tokenizer(string str, char controlChar = Token.DefaultControlChar)
        {
            Str = str;
            ControlChar = controlChar;
        }

        public IEnumerator<Token> GetEnumerator() => new Enumerator(Str, ControlChar);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<Token>
        {
            private readonly string _str;
            private readonly char _controlChar;
            private int _index;
            private bool _hasInvalidCode;

            public Token Current { get; private set; }
            object IEnumerator.Current => Current;

            public Enumerator(string str, char controlChar = Token.DefaultControlChar)
                : this()
            {
                _index = -1;
                _str = str;
                _controlChar = controlChar;
            }

            public bool MoveNext()
            {
                if (!HasNext) return false;

                List<Code> codes = null;
                while (HasNext)
                {
                    if (Peek() != _controlChar) break;
                    Next();
                    if (!HasNext || !((Code) char.ToLower(Peek())).IsValid())
                    {
                        Back();
                        _hasInvalidCode = true;
                        break;
                    }
                    if (codes == null)
                    {
                        codes = new List<Code>();
                    }
                    codes.Add((Code) char.ToLower(Next()));
                }

                if (codes != null)
                {
                    Current = new Token.Codes(codes);
                    return true;
                }

                // start with next character after code (or 0 if Text is the first token)
                var startIndex = _index + 1;
                while (HasNext)
                {
                    if (_hasInvalidCode)
                    {
                        // include control char
                        Next();

                        if (HasNext)
                        {
                            // include code if any.
                            Next();
                        }
                        _hasInvalidCode = false;
                        continue;
                    }
                    if (Peek() == _controlChar)
                    {
                        break;
                    }
                    Next();
                }

                Current = new Token.Text(_str.Substring(startIndex, _index - startIndex + 1));
                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public void Dispose()
            {
            }

            private bool HasNext => _index != _str.Length - 1;
            private void Back() => _index--;
            private char Peek() => _str[_index + 1];
            private char Next() => _str[++_index];
        }
    }
}
