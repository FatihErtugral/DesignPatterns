
using System;

namespace _000_Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id;
        private static object _lockObject = new object();

        public Guid Id
        {
            get { return Singleton._id; }
        }

        private Singleton(Guid id) // Not: Multithread uygulama için Constructor statik olarak tasarlanabilir.
        {
            _id = id;
        }
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if(_instance == null)
                        _instance = new Singleton(Guid.NewGuid());
                }
            }

            return _instance;
        }
    }
}
