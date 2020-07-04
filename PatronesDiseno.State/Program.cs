using System;

namespace PatronesDiseno.State
{
    class Program
    {
        static void Main(string[] args)
        {
            MicrowaveOven microwaveOven = new MicrowaveOven();

            TimeSpan duration = TimeSpan.FromMinutes(10);

            microwaveOven.Start(duration);

            microwaveOven.OpenDoor();

            microwaveOven.Stop();

            microwaveOven.OpenDoor();

            Console.ReadLine();
        }
    }
}
