namespace Quartz.Block
{
    public struct BlockStateId
    {
        public byte Id { get; }
        public byte Data { get; }
        
        public BlockStateId(byte id, byte data)
        {
            Id = id;
            Data = (byte)(data & 0xf);
        }

        public BlockStateId(ushort num)
        {
            Id = (byte)((num >> 4) & 0xff);
            Data = (byte)(num & 0xf);
        }

        public ushort Short => (ushort)((Id << 4) | Data);
    }
}
