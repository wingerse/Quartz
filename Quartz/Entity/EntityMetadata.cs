using System;
using System.Collections.Generic;
using EncodingLib;
using EncodingLib.Nbt;
using Quartz.Block;
using Quartz.Item;
using Quartz.Proto;
using Quartz.Text.Chat;
using Quartz.World;

namespace Quartz.Entity
{
    public sealed class EntityMetadata
    {
        public Dictionary<byte, Entry> Map { get; set; }
        
        public EntityMetadata(Dictionary<byte, Entry> map) => Map = map;
        
        public abstract class Entry
        {
            private Entry()
            {
            }
    
            public abstract byte Type { get; }
            public abstract void Write(PrimitiveWriter writer);
    
            public sealed class Byte : Entry
            {
                public sbyte Value { get; set; }
                public Byte(sbyte value) => Value = value;
                public override byte Type => 0;
                public override void Write(PrimitiveWriter writer) => writer.WriteSByte(Value);
            }

            public sealed class Varint : Entry
            {
                public int Value { get; set; }
                public Varint(int value) => Value = value;
                public override byte Type => 1;
                public override void Write(PrimitiveWriter writer) => writer.WriteVarint(Value);
            }

            public sealed class Float : Entry
            {
                public float Value { get; set; }
                public Float(float value) => Value = value;
                public override byte Type => 2;
                public override void Write(PrimitiveWriter writer) => writer.WriteFloat(Value);
            }

            public sealed class String : Entry
            {
                public string Value { get; set; }
                public String(string value) => Value = value;
                public override byte Type => 3;
                public override void Write(PrimitiveWriter writer) => writer.WriteStringProto(Value);
            }

            public sealed class Chat : Entry
            {
                public ChatRoot Value { get; set; }
                public Chat(ChatRoot value) => Value = value;
                public override byte Type => 4;
                public override void Write(PrimitiveWriter writer) => writer.WriteChatRootProto(Value);
            }

            public sealed class Slot : Entry
            {
                public ItemStack Value { get; set; }
                public Slot(ItemStack value) => Value = value;
                public override byte Type => 5;
                public override void Write(PrimitiveWriter writer) => writer.WriteItemStackProto(Value);
            }

            public sealed class Bool : Entry
            {
                public bool Value { get; set; }
                public Bool(bool value) => Value = value;
                public override byte Type => 6;
                public override void Write(PrimitiveWriter writer) => writer.WriteBool(Value);
            }

            public sealed class Rotation : Entry
            {
                public float X { get; set; }
                public float Y { get; set; }
                public float Z { get; set; }
                public Rotation(float x, float y, float z) => (X, Y, Z) = (x, y, z);
                public override byte Type => 7;
                public override void Write(PrimitiveWriter writer)
                {
                    writer.WriteFloat(X);
                    writer.WriteFloat(Y);
                    writer.WriteFloat(Z);
                }
            }

            public sealed class Position : Entry
            {
                public BlockPos Value { get; set; }
                public Position(BlockPos value) => Value = value;
                public override byte Type => 8;
                public override void Write(PrimitiveWriter writer) => writer.WriteBlockPosProto(Value);
            }

            public sealed class OptPosition : Entry
            {
                public BlockPos? Value { get; set; }
                public OptPosition(BlockPos? value) => Value = value;
                public override byte Type => 9;
                public override void Write(PrimitiveWriter writer)
                {
                    writer.WriteBool(Value.HasValue);
                    if (!Value.HasValue) return;
                    writer.WriteBlockPosProto(Value.Value);
                }
            }

            public sealed class Direction : Entry
            {
                public World.Direction Value { get; set; }
                public Direction(World.Direction value) => Value = value;
                public override byte Type => 10;
                public override void Write(PrimitiveWriter writer) => writer.WriteVarint((int)Value);
            }

            public sealed class OptUuid : Entry
            {
                public Guid Value { get; set; }
                public OptUuid(Guid value) => Value = value;
                public override byte Type => 11;
                public override void Write(PrimitiveWriter writer) => writer.WriteUuidProto(Value);
            }

            public sealed class OptBlockId : Entry
            {
                public BlockStateId Value { get; set; }
                public OptBlockId(BlockStateId value) => Value = value;
                public override byte Type => 12;
                public override void Write(PrimitiveWriter writer) => writer.WriteVarint(Value.Short);
            }

            public sealed class NbtTag : Entry
            {
                public NbtBlob Value { get; set; }
                public NbtTag(NbtBlob value) => Value = value;
                public override byte Type => 13;
                public override void Write(PrimitiveWriter writer) => writer.WriteNbtBlob(Value);
            }
        }
    }

    public static class EntityMetadataEx
    {
        public static void WriteEntityMetadataProto(this PrimitiveWriter writer, EntityMetadata entityMetadata)
        {
            foreach (var pair in entityMetadata.Map)
            {
                writer.WriteByte(pair.Key);
                writer.WriteByte(pair.Value.Type);
                pair.Value.Write(writer);
            }
            writer.WriteByte(0xff);
        }
    }
}
