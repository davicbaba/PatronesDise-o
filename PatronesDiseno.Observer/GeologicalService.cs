using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Observer
{
    /// <summary>
    /// sujeto concreto
    /// </summary>
    public class GeologicalService : ISubject
    {

        private List<IObserver> Observers;
        public GeologicalService()
        {
            Observers = new List<IObserver>();
        }

        public void NotifyObservers(EarthQuake earthQuake)
        {
            Console.WriteLine("Antes de notificar a los observadores");

            foreach(IObserver observer in Observers)
            {
                observer.Update(earthQuake);
            }
            Console.WriteLine("Los observadores han sido notificados");

        }

        public void Suscribe(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unsuscribe(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Tremble()
        {
            EarthQuake earthQuake = new EarthQuake(100,150, 5.7, DateTime.Now);

            NotifyObservers(earthQuake);
        }
    }
}
