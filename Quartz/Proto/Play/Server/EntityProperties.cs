using System;
using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class EntityProperties : OutPacket
    {
        public int EntityId { get; set; }
        public List<Property> Properties { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteInt(Properties.Count);
            foreach (var p in Properties)
            {
                writer.WriteStringProto(p.Key);
                writer.WriteDouble(p.Value);
                writer.WriteVarint(p.Modifiers.Count);
                foreach (var m in p.Modifiers)
                {
                    writer.WriteUuidProto(m.Uuid);
                    writer.WriteDouble(m.Amount);
                    writer.WriteByte((byte)m.Operation);
                }
            }
        }

        public sealed class Property
        {
            public string Key { get; set; }
            public double Value { get; set; }
            public List<Modifier> Modifiers { get; set; }
        }

        public sealed class Modifier
        {
            public Guid Uuid { get; set; }
            public double Amount { get; set; }
            public OperationEnum Operation { get; set; }
            
            public enum OperationEnum
            {
                Add,
                AddPercent,
                MultiplyPercent
            }
        }
    }
}
