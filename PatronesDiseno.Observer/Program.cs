using System;

namespace PatronesDiseno.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver observer = new ConsoleObserver();

            GeologicalService subject = new GeologicalService();

            subject.Suscribe(observer);

            subject.Tremble();

            subject.Unsuscribe(observer);

            subject.Tremble();


            Console.ReadLine();
        }
    }
}
