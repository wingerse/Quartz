﻿using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class OpenSignEditor : OutPacket
    {
        public const int IdConst = 0x2a;

        public BlockPos Location { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
        }
    }
}
