using System;

namespace PatronesDiseno.SimpleFactory
{
    class Program
    {

        /// <summary>
        /// Este se considera un patron de diseño, el patron real es Factorymethod pero se utiliza bastante el SimpleFactory tambien.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            IGame game = SimpleFactory.CreateGame("chess");
            IGame game2 = SimpleFactory.CreateGame("solitaire");

            Console.WriteLine(game.GetType().Name);
            Console.WriteLine(game2.GetType().Name);

            Console.ReadLine();
        }
    }
}
