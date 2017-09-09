﻿using System;
using EncodingLib;

namespace Quartz.Proto.Login.Server
{
    public sealed class LoginSuccess : OutPacket
    {
        public const int IdConst = 2;

        public Guid Uuid { get; set; }
        public string Username { get; set; }
        
        public override int Id => 2;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(Uuid.ToString());
            writer.WriteStringProto(Username);
        }
    }
}
