using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.SimpleFactory
{
    public class SimpleFactory
    {
        public static IGame CreateGame(string type)
        {
            if (type == null)
                return null;

            IGame game = null;

            switch (type)
            {
                case "chess":
                    game = new ChessGame();
                    break;
                case "solitaire":
                    game = new SolitaireGame();
                    break;
            }

            return game;
        }

    }
}
