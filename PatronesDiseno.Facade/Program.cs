using System;

namespace PatronesDiseno.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();

            int count = fileManager.CountCharacters("text.txt");

            Console.WriteLine("La cantidad de caracteres en el archivo son: " + count);

            Console.ReadLine();
        }
    }
}
