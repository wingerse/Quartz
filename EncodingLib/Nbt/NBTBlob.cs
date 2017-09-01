namespace EncodingLib.Nbt
{
    public sealed class NbtBlob
    {
        public static readonly NbtBlob Empty = new NbtBlob(null, null);
        
        public string Name { get; set; }
        public Tag.Compound Root { get; set; }

        public NbtBlob(string name, Tag.Compound root)
        {
            Name = name;
            Root = root;
        }

        public bool IsEmpty => Root == null;
    }
}