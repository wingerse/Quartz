namespace Quartz.Item
{
    public abstract partial class Item
    {
        public sealed class Air : Item
        {
            public const short IdConst = 0;
            public override short Id => IdConst;
        }
    }
}
