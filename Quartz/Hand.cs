namespace Quartz
{
    public enum Hand
    {
        MainHand,
        Offhand
    }

    public static class HandEx
    {
        public static bool IsValid(this Hand e)
        {
            return e == Hand.MainHand || e == Hand.Offhand;
        }
    }
}
