using System;

namespace PatronesDiseno.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] chessPlayers = { "PeterParker", "Clark Kent" };

            Board chessBoard = new ChessBoard(chessPlayers);

            chessBoard.Initialize();

            string[] solitary = { "Jack Sparrow" };

            Board solitaryBoard = new SolitaireBoard(solitary);

            solitaryBoard.Initialize();

            Console.ReadLine();
        }
    }
}
