using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Observer
{
    public interface ISubject
    {
        void Suscribe(IObserver observer);

        void Unsuscribe(IObserver observer);
        void NotifyObservers(EarthQuake earthQuake);
    }
}
