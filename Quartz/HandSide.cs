namespace Quartz
{
    public enum HandSide
    {
        Left,
        Right
    }

    public static class HandSideEx
    {
        public static bool IsValid(this HandSide e)
        {
            return e == HandSide.Left || e == HandSide.Right;
        }
    }
}
