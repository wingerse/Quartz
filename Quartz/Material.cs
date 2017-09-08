namespace Quartz
{
    public abstract class Material
    {
        public short NumericId { get; }
        public string Name { get; }
        
        protected Material(short numericId, string name)
        {
            NumericId = numericId;
            Name = name;
        }
    }
}
