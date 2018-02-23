using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnYardPolitics.Game.Players
{
    public enum TurnAbilities
    {
        Income, //Take one coin from the bank. This cannot be Challenged or Blocked. 
        ForeignAid, //Take two coins from the bank. This cannot be Challenged but it can be Blocked by the Duke. 
        Coup //Cause a player to give up an Influence card. Cannot be Challenged or Blocked. If you start your turn with 10+ coins, you must take this action.
    }
}
