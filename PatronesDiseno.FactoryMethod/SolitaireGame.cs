using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.FactoryMethod
{
    public class SolitaireGame : IGame
    {
        public string Player;

        public SolitaireGame(string player)
        {
            Player = player;
        }

        public void Start()
        {
            Console.WriteLine("Inicia el juego de solitario");
        }
    }
}
