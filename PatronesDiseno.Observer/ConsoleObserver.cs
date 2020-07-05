using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Observer
{
    public class ConsoleObserver : IObserver
    {
        public void Update(EarthQuake earthQuake)
        {
            Console.WriteLine("Movimiento sismico! ");
            Console.WriteLine($"Ubicacion ({earthQuake.Latitude} {earthQuake.Logitude})");
            Console.WriteLine($"Magnitud {earthQuake.Magnitude}");
            Console.WriteLine($"Fecha {earthQuake.DateTime}");


        }
    }
}
