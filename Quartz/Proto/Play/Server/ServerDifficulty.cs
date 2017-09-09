﻿using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ServerDifficulty : OutPacket
    {
        public const int IdConst = 0x0d;

        public Difficulty Difficulty { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteByte((byte)Difficulty);
        }
    }
}
