using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodingLib.Nbt
{
    /// <summary>
    /// Represents an NBT Tag.
    /// </summary>
    public abstract class Tag
    {
        public const int MaxNestLevel = 512;

        // private constructor so no external class can inherit.
        private Tag()
        {
        }

        internal abstract TypeID ID { get; }
        internal abstract void Write(PrimitiveWriter writer);
        internal abstract void Read(PrimitiveReader reader, int level);
        public abstract override string ToString();

        internal static Tag CreateTagFromID(TypeID id)
        {
            switch (id)
            {
                case TypeID.Byte: return new Byte();
                case TypeID.Short: return new Short();
                case TypeID.Int: return new Int();
                case TypeID.Long: return new Long();
                case TypeID.Float: return new Float();
                case TypeID.Double: return new Double();
                case TypeID.ByteArray: return new ByteArray();
                case TypeID.String: return new String();
                case TypeID.List: return new List();
                case TypeID.Compound: return new Compound();
                case TypeID.IntArray: return new IntArray();
                default:
                    throw new NBTException("Invalid TypeID.");
            }
        }

        private static void ThrowMaxNestLevel()
        {
            throw new NBTException($"Maximum allowed nest level({MaxNestLevel}) reached.");
        }

        public sealed class Byte : Tag
        {
            public sbyte Value { get; set; }

            public static implicit operator sbyte(Byte tag) => tag.Value;
            public static implicit operator Byte(sbyte x) => new Byte(x);

            public Byte()
            {
            }

            public Byte(sbyte val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Byte;
            internal override void Write(PrimitiveWriter writer) => writer.WriteSByte(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadSByte();
            public override string ToString() => Value.ToString();
        }

        public sealed class Short : Tag
        {
            public short Value { get; set; }

            public static implicit operator short(Short tag) => tag.Value;
            public static implicit operator Short(short x) => new Short(x);

            public Short()
            {
            }

            public Short(short val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Short;
            internal override void Write(PrimitiveWriter writer) => writer.WriteShort(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadShort();
            public override string ToString() => Value.ToString();
        }

        public sealed class Int : Tag
        {
            public int Value { get; set; }
            
            public static implicit operator int(Int tag) => tag.Value;
            public static implicit operator Int(int x) => new Int(x);

            public Int()
            {
            }

            public Int(int val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Int;
            internal override void Write(PrimitiveWriter writer) => writer.WriteInt(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadInt();
            public override string ToString() => Value.ToString();
        }

        public sealed class Long : Tag
        {
            public long Value { get; set; }
            
            public static implicit operator long(Long tag) => tag.Value;
            public static implicit operator Long(long x) => new Long(x);

            public Long()
            {
            }

            public Long(long val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Long;
            internal override void Write(PrimitiveWriter writer) => writer.WriteLong(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadLong();
            public override string ToString() => Value.ToString();
        }

        public sealed class Float : Tag
        {
            public float Value { get; set; }
            
            public static implicit operator float(Float tag) => tag.Value;
            public static implicit operator Float(float x) => new Float(x);

            public Float()
            {
            }

            public Float(float val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Float;
            internal override void Write(PrimitiveWriter writer) => writer.WriteFloat(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadFloat();
            public override string ToString() => Value.ToString();
        }

        public sealed class Double : Tag
        {
            public double Value { get; set; }
            
            public static implicit operator double(Double tag) => tag.Value;
            public static implicit operator Double(double x) => new Double(x);

            public Double()
            {
            }

            public Double(double val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Double;
            internal override void Write(PrimitiveWriter writer) => writer.WriteDouble(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadDouble();
            public override string ToString() => Value.ToString();
        }

        public sealed class ByteArray : Tag
        {
            public byte[] Value { get; set; }
            
            public static implicit operator byte[](ByteArray tag) => tag.Value;
            public static implicit operator ByteArray(byte[] x) => new ByteArray(x);

            internal ByteArray()
            {
            }

            public ByteArray(byte[] val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.ByteArray;

            internal override void Write(PrimitiveWriter writer)
            {
                writer.WriteInt(Value.Length);
                writer.Write(Value, 0, Value.Length);
            }

            internal override void Read(PrimitiveReader reader, int _)
            {
                var len = reader.ReadInt();
                if (len < 0)
                {
                    throw new NBTException("Negative length.");
                }
                Value = new byte[len];
                reader.ReadFully(Value, 0, Value.Length);
            }

            public override string ToString() => $"byte[{Value.Length}]";

            public byte this[int i]
            {
                get => Value[i];
                set => Value[i] = value;
            }
        }

        public sealed class String : Tag
        {
            public string Value { get; set; }
            
            public static implicit operator string(String tag) => tag.Value;
            public static implicit operator String(string x) => new String(x);

            internal String()
            {
            }

            public String(string val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.String;
            internal override void Write(PrimitiveWriter writer) => writer.WriteString(Value);
            internal override void Read(PrimitiveReader reader, int _) => Value = reader.ReadString();
            public override string ToString() => $"\"{Value}\"";
        }

        public sealed class List : Tag, IEnumerable<Tag>
        {
            public List<Tag> Value { get; }
            
            public static implicit operator List<Tag>(List tag) => tag.Value;
            public static implicit operator List(List<Tag> x) => new List(x);

            public List()
            {
                Value = new List<Tag>();
            }

            public List(List<Tag> val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.List;

            internal override void Write(PrimitiveWriter writer)
            {
                if (Value.Any())
                {
                    writer.WriteByte((byte) Value[0].ID);
                }
                else
                {
                    writer.WriteByte((byte) TypeID.End);
                }
                writer.WriteInt(Value.Count);
                foreach (var tag in Value)
                {
                    if (tag.ID != Value[0].ID)
                    {
                        throw new NBTException("Tags are not the same in the list.");
                    }
                    tag.Write(writer);
                }
            }

            internal override void Read(PrimitiveReader reader, int level)
            {
                level++;
                if (level > MaxNestLevel)
                {
                    ThrowMaxNestLevel();
                }

                var id = (TypeID) reader.ReadByte();
                var length = reader.ReadInt();

                if (length <= 0)
                {
                    return;
                }

                Value.Capacity = length;
                for (var i = 0; i < length; i++)
                {
                    var tag = CreateTagFromID(id);
                    tag.Read(reader, level);
                    Value.Add(tag);
                }
            }

            public IEnumerator<Tag> GetEnumerator() => Value.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
            
            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.Append("[");
                builder.Append(string.Join(",", Value));
                builder.Append("]");
                return builder.ToString();
            }

            public void Add(Tag tag)
            {
                Value.Add(tag);
            }

            public T Get<T>(int index)
                where T : Tag
            {
                return (T) Value[index];
            }
        }

        public sealed class Compound : Tag
        {
            public Dictionary<string, Tag> Value { get; }
            
            public static implicit operator Dictionary<string, Tag>(Compound tag) => tag.Value;
            public static implicit operator Compound(Dictionary<string, Tag> x) => new Compound(x);

            public Compound()
            {
                Value = new Dictionary<string, Tag>();
            }

            public Compound(Dictionary<string, Tag> val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.Compound;

            internal override void Write(PrimitiveWriter writer)
            {
                foreach (var pair in Value)
                {
                    writer.WriteByte((byte) pair.Value.ID);
                    writer.WriteString(pair.Key);
                    pair.Value.Write(writer);
                }
                writer.WriteByte((byte) TypeID.End);
            }

            internal override void Read(PrimitiveReader reader, int level)
            {
                level++;
                if (level > MaxNestLevel)
                {
                    ThrowMaxNestLevel();
                }

                while (true)
                {
                    var id = (TypeID) reader.ReadByte();
                    if (id == TypeID.End)
                    {
                        break;
                    }

                    var tag = CreateTagFromID(id);
                    var name = reader.ReadString();
                    tag.Read(reader, level);
                    this[name] = tag;
                }
            }

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.Append("{");
                builder.Append(string.Join(",", Value.Select(p => $"\"{p.Key}\":{p.Value}")));
                builder.Append("}");
                return builder.ToString();
            }

            public Tag this[string key]
            {
                get => Value[key];
                set => Value[key] = value;
            }

            public T Get<T>(string key)
                where T : Tag
            {
                return (T) Value[key];
            }
        }

        public sealed class IntArray : Tag
        {
            public int[] Value { get; set; }
            
            public static implicit operator int[](IntArray tag) => tag.Value;
            public static implicit operator IntArray(int[] x) => new IntArray(x);

            internal IntArray()
            {
            }

            public IntArray(int[] val)
            {
                Value = val;
            }

            internal override TypeID ID => TypeID.IntArray;

            internal override void Write(PrimitiveWriter writer)
            {
                writer.WriteInt(Value.Length);
                foreach (var i in Value)
                {
                    writer.WriteInt(i);
                }
            }

            internal override void Read(PrimitiveReader reader, int _)
            {
                var length = reader.ReadInt();
                if (length < 0)
                {
                    throw new NBTException("Negative length.");
                }
                Value = new int[length];
                for (var i = 0; i < Value.Length; i++)
                {
                    Value[i] = reader.ReadInt();
                }
            }

            public override string ToString() => $"int[{Value.Length}]";

            public int this[int i]
            {
                get => Value[i];
                set => Value[i] = value;
            }
        }
    }
}
