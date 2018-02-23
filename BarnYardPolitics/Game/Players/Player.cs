using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnYardPolitics.Game.Players
{
    class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FriendlyName { get; set; }
        public string LastKnownIp { get; set; }
        public int DiceRoll { get; set; }
    }
}
