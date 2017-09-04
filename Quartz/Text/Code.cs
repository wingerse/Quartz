namespace Quartz.Text
{
    public enum Code
    {
        Black = '0',
        DarkBlue = '1',
        DarkGreen = '2',
        DarkCyan = '3',
        DarkRed = '4',
        Purple = '5',
        Gold = '6',
        Gray = '7',
        DarkGray = '8',
        Blue = '9',
        BrightGreen = 'a',
        Cyan = 'b',
        Red = 'c',
        Pink = 'd',
        Yellow = 'e',
        White = 'f',

        Reset = 'r',
        Obfuscated = 'k',
        Bold = 'l',
        StrikeThrough = 'm',
        Underlined = 'n',
        Italic = 'o'
    }

    public static class CodeEx
    {
        public static bool IsValid(this Code code) => code.IsColor() || code.IsFormatting();

        public static bool IsColor(this Code code)
        {
            switch (code)
            {
                case Code.Black:
                case Code.DarkBlue:
                case Code.DarkGreen:
                case Code.DarkCyan:
                case Code.DarkRed:
                case Code.Purple:
                case Code.Gold:
                case Code.Gray:
                case Code.DarkGray:
                case Code.Blue:
                case Code.BrightGreen:
                case Code.Cyan:
                case Code.Red:
                case Code.Pink:
                case Code.Yellow:
                case Code.White:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsFormatting(this Code code)
        {
            switch (code)
            {
                case Code.Reset:
                case Code.Obfuscated:
                case Code.Bold:
                case Code.StrikeThrough:
                case Code.Underlined:
                case Code.Italic:
                    return true;
                default:
                    return false;
            }
        }
    }
}
