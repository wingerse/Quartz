using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class CraftingBookData : InPacket
    {
        public TypeEnum Type { get; private set; }
        public int RecipeId { get; private set; }
        public bool CraftingBookOpen { get; private set; }
        public bool CraftingFilter { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Type = (TypeEnum)reader.ReadVarint();
            switch (Type)
            {
                case TypeEnum.DisplayedRecipe:
                    RecipeId = reader.ReadInt();
                    break;
                case TypeEnum.CraftingBookStatus:
                    CraftingBookOpen = reader.ReadBool();
                    CraftingFilter = reader.ReadBool();
                    break;
                default:
                    throw new InvalidPacketException(nameof(Type), Type);
            }
        }

        public enum TypeEnum
        {
            DisplayedRecipe,
            CraftingBookStatus
        }
    }
}
