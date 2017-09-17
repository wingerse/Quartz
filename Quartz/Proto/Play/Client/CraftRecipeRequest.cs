using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class CraftRecipeRequest : InPacket
    {
        public sbyte WindowId { get; private set; }
        public int RecipeId { get; private set; }
        public bool MakeAll { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            WindowId = reader.ReadSByte();
            RecipeId = reader.ReadVarint();
            MakeAll = reader.ReadBool();
        }
    }
}
