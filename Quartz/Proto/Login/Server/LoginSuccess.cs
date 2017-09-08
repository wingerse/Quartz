using System;
using EncodingLib;

namespace Quartz.Proto.Login.Server
{
    public sealed class LoginSuccess : IOutPacket
    {
        public const int Id = 2;

        public Guid Uuid { get; set; }
        public string Username { get; set; }
        
        public int GetId() => 2;

        public void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(Uuid.ToString());
            writer.WriteStringProto(Username);
        }
    }
}
