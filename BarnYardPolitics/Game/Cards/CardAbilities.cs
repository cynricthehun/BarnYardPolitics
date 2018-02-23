using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnYardPolitics.Game
{
    public enum CardAbilities
    {
        Taxes, //Take three coins from the bank. Can be Challenged. 
        Assassinate, //Costs three coins. Force one player to give up an Influence card of their choice. Can be Challenged. Can be Blocked by the Contessa.
        Steal, //Take two coins from another player. Can be Challenged. Can be Blocked by another Captain or an Ambassador. 
        SwapInfluence //Draw two Influence cards from the deck, look at them and mix them with your current Influence card(s). Place two cards back in the deck and shuffle the deck. Can be Challenged. Cannot be Blocked. 
    }
}
