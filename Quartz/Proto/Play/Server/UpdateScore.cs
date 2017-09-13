using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class UpdateScore : OutPacket
    {
        public string EntityName { get; set; }
        public ActionEnum Action { get; set; }
        public string ObjectiveName { get; set; }
        public int Value { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(EntityName);
            writer.WriteByte((byte)Action);
            writer.WriteStringProto(ObjectiveName);
            if (Action != ActionEnum.Remove)
            {
                writer.WriteVarint(Value);
            }
        }

        public enum ActionEnum
        {
            CreateOrUpdate,
            Remove
        }
    }
}
