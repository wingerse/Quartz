using Quartz.MojangApi;
using Quartz.Text.Chat;

namespace Quartz.Entity
{
    public class Player
    {
        public PlayerProfile Profile { get; set; }
        public Gamemode Gamemode { get; set; }
        public int Ping { get; set; } 
        /// <summary>
        /// Can be null.
        /// </summary>
        public ChatRoot DisplayName { get; set; }
    }
}
