using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class UnlockRecipes : OutPacket
    {
        public const int IdConst = 0x31;
        
        public ActionEnum Action { get; set; }
        public bool CraftingBookOpen { get; set; }
        public bool FilteringCraftable { get; set; }
        public List<int> RecipeIds { get; set; }
        /// <summary>
        /// Can be null.
        /// Only present when Action == Init.
        /// </summary>
        public List<int> RecipeIds2 { get; set; }

        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint((int)Action);
            writer.WriteBool(CraftingBookOpen);
            writer.WriteBool(FilteringCraftable);
            writer.WriteVarint(RecipeIds.Count);
            foreach(var i in RecipeIds)
                writer.WriteVarint(i);
            
            if (Action == ActionEnum.Init)
            {
                writer.WriteVarint(RecipeIds2.Count);
                foreach(var i in RecipeIds2)
                    writer.WriteVarint(i);
            }
        }

        public enum ActionEnum
        {
            Init, 
            Add,
            Remove
        }
    }
}
