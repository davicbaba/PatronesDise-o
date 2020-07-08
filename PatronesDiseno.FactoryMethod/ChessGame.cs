using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.FactoryMethod
{
    public class ChessGame : IGame
    {
        private string PlayerOne;
        private string PlayerTwo;

        public ChessGame(string playerOne, string playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        
        public void Start()
        {
            Console.WriteLine("Inicia el juego de ajedrez");
        }
    }
}
