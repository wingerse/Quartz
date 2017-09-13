using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class CraftRecipeResponse : OutPacket
    {
        public sbyte WindowId { get; set; }
        public int RecipeId { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteSByte(WindowId);
            writer.WriteVarint(RecipeId);
        }
    }
}
