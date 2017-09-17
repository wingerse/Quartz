using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Quartz.Proto;
using Quartz.Proto.Handshaking.Client;
using Quartz.Proto.Status.Client;
using Quartz.Proto.Status.Server;
using Quartz.Text.Chat;

namespace Quartz
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var listener = new TcpListener(IPAddress.Any, 25565);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClientAsync().Result;
                HandleClient(client).ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        client.Dispose();
                        Console.WriteLine(t.Exception.InnerExceptions[0].ToString());
                    }
                });    
            }
        }

        private static async Task HandleClient(TcpClient client)
        {
            var reader = new PacketReader(client.GetStream());
            var writer = new PacketWriter(client.GetStream());

            var packet = await reader.ReadPacketAsync();
            var nextState = ((Handshake)packet).NextState;

            if (nextState == Handshake.NextStateEnum.Status)
            {
                reader.State = State.Status;
                writer.State = State.Status;
                var p = await reader.ReadPacketAsync();
                var _ = (Request)p;
                var msg = StringComponent.Parse("&4&lQuartz server!", '&');
                await writer.WritePacketAsync(new Response()
                {
                    Description = new ChatRoot(msg),
                    OnlinePlayers = 1000,
                    MaxPlayers = 10000,
                    VersionName = "1.12.1",
                    VersionProtocol = 316
                });
                var ping = (Ping)await reader.ReadPacketAsync();
                await writer.WritePacketAsync(new Pong {Payload = ping.Payload});
                client.Dispose();
            }
            else
            {
                client.Dispose();
            }
        }
    }
}
