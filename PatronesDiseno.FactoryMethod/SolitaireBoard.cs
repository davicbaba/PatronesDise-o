using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.FactoryMethod
{
    public class SolitaireBoard : Board
    {
        public SolitaireBoard(string[] players) : base(players)
        {
        }

        public override IGame CreateGame()
        {
            string[] players = GetPlayers();

            string player = "Jugador";

            if (players != null && players.Length > 0)
            {
                player = players[0];
            }

            SolitaireGame solitaireGame = new SolitaireGame(player);

            return solitaireGame;
        }
    }
}
