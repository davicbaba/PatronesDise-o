using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.FactoryMethod
{
    /// <summary>
    /// Creador 
    /// </summary>
    public abstract class Board
    {
        private IGame Game;

        private string[] Players;

        public Board(string[] players)
        {
            Players = players;
        }

        /// <summary>
        /// Metodo fabrica
        /// </summary>
        /// <returns></returns>
        public abstract IGame CreateGame();


        /// <summary>
        /// Metodo plantilla
        /// </summary>
        public void Initialize()
        {
            Game = CreateGame();

            Game.Start();
        }

        public string[] GetPlayers()
        {
            return Players;
        }

    }
}
