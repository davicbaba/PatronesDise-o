using System;

namespace PatronesDiseno.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonOne = Singleton.GetInstance();
            Singleton singletonTwo = Singleton.GetInstance();

            if (singletonOne == singletonTwo)
            {
                Console.WriteLine("Solo hay una unica instancia");
            }

            ThreadSafeSingleton threadSafeSingletonOne = ThreadSafeSingleton.GetInstance();
            ThreadSafeSingleton threadSafeSingletonTwo = ThreadSafeSingleton.GetInstance();
            if (threadSafeSingletonOne == threadSafeSingletonTwo)
            {
                Console.WriteLine("Solo hay una instancia thread/safe");
            }
            Console.ReadLine();
        }
    }
}
