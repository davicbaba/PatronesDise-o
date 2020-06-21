using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Singleton
{
    public class ThreadSafeSingleton
    {
        private volatile static ThreadSafeSingleton _uniqueInstance;
        private static object _lockObject;

        private ThreadSafeSingleton()
        {
        }

        static ThreadSafeSingleton()
        {
            _lockObject = new object();
        }
        public static ThreadSafeSingleton GetInstance()
        {
            lock (_lockObject)
            {
                if (_uniqueInstance == null)
                    _uniqueInstance = new ThreadSafeSingleton();
            }
            
            return _uniqueInstance;
        }

    }
}
