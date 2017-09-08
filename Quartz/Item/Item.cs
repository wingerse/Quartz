namespace Quartz.Item
{
    public abstract partial class Item
    {
        public abstract short Id { get; }

        public static Item GetFromId(short id)
        {
            return new Air();
        }
    }
}
