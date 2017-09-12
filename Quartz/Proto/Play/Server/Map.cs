using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class Map : OutPacket
    {
        public const int IdConst = 0x24;

        public int MapId { get; set; }
        public byte Scale { get; set; }
        public bool ShowIcons { get; set; }
        public Icon[] Icons { get; set; }
        public byte Columns { get; set; }
        public byte Rows { get; set; }
        public byte X { get; set; }
        public byte Z { get; set; }
        public byte[] Data { get; set; }
            
        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(MapId);
            writer.WriteByte(Scale);
            writer.WriteBool(ShowIcons);
            writer.WriteVarint(Icons.Length);
            foreach (var i in Icons)
            {
                writer.WriteByte((byte)(((byte)i.Type << 4) | (i.Direction & 0x0f)));
                writer.WriteByte(i.X);
                writer.WriteByte(i.Z);
            }
            writer.WriteByte(Columns);
            if (Columns == 0) return;
            
            writer.WriteByte(Rows);
            writer.WriteByte(X);
            writer.WriteByte(Z);
            writer.WriteVarint(Data.Length);
            writer.Write(Data, 0, Data.Length);
        }

        public struct Icon
        {
            public byte Direction { get; }
            public TypeEnum Type { get; }
            public byte X { get; }
            public byte Z { get; }

            public Icon(double direction, TypeEnum type, byte x, byte z)
            {
                Direction = (byte)(direction * 16d / 360d);
                Type = type;
                X = x;
                Z = z;
            }

            public enum TypeEnum : byte
            {
                WhiteArrow,
                GreenArrow,
                RedArrow,
                BlueArrow,
                WhiteCross,
                RedPointer,
                WhiteCircle,
                SmallWhiteCircle,
                Mansion,
                Temple,
                BlueSquare
            }
        }
    }
}
