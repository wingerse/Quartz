using System;
using System.Collections.Generic;
using System.Linq;
using EncodingLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quartz.Entity;
using Quartz.Text.Chat;

namespace Quartz.Proto.Status.Server
{
    public sealed class Response : OutPacket
    {
        public string VersionName { get; set; }
        public int VersionProtocol { get; set; }
        public ChatRoot Description { get; set; }
        public int MaxPlayers { get; set; }
        public int OnlinePlayers { get; set; }
        
        public IEnumerable<Player> PlayerSample { get; set; }
        public string Favicon { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            var o = new JObject(
                new JProperty("version",
                    new JObject(
                        new JProperty("name", VersionName),
                        new JProperty("protocol", VersionProtocol)
                    )
                ),
                new JProperty("players",
                    new JObject(
                        new JProperty("max", MaxPlayers),
                        new JProperty("online", OnlinePlayers)
                    )
                ),
                new JProperty("description", JObject.FromObject(Description))
            );
            if (PlayerSample != null)
            {
                ((JObject)o["players"]).Add("sample", new JArray(PlayerSample.Select(p => new {name = p.Profile.Name, id = p.Profile.Id.ToString()})));
            }
            if (Favicon != null)
            {
                o.Add("favicon", new JValue("data:image/png;base64," + Favicon));
            }
            writer.WriteStringProto(o.ToString(Formatting.None));
        }
    }
}
