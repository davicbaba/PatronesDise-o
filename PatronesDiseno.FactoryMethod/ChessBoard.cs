using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.FactoryMethod
{
    public class ChessBoard : Board
    {
        public ChessBoard(string[] players) : base(players)
        {
        }

        public override IGame CreateGame()
        {
            string[] players = GetPlayers();

            string playerOne = "Blanco";
            string playerTwo = "Negro";


            if(players != null && players.Length == 2)
            {
                playerOne = players[0];
                playerTwo = players[1];
            }

            ChessGame chessGame = new ChessGame(playerOne, playerTwo);
            return chessGame;
        }
    }
}
