using BarnYardPolitics.Game.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnYardPolitics.Game
{
    public class Game
    {
        public void GameStart()
        {
            bool gameStarted = true;
            // Collect Connected Players.
            List<Player> connectedPlayers = new List<Player>();
            // Decide which player goes first by dice roll.
            // Assign the turn order based off the dice roll.
            int[] TurnOrder = new int[connectedPlayers.Count];
            PlayersTurn();
        }
        public void PlayersTurn()
        {
            CardAbilities cardAbilities = new CardAbilities(); // Going to need a collection of all abilities. CardAbilities is only setup for Card Actions and not taking Coin.
            //Move to the first players turn in the turn order array
            //Give the player a copy of the Abilities object.
            //Player picks a card ability or a turn ability.
            //Turn timer begins.
            int turnTimer = 60;
            //Check if player has influence.
            CheckPlayerInfluence(player);
            if (TurnOrder.Count = 1){
                EndGame(Player player);
            }
            //Turn is ended and passed onto the next player in the turn order created in the GameStart.
        }
        private void CheckPlayerInfluence(player)
        {
            if (player.influence = 0)
            {
                //remove player from turns.
            }
        }
        public bool EndGame()
        {
            // Declare Winner.
            // Game Cleanup.
            bool gameEnded = true;
            return gameEnded;
        }
    }
}
