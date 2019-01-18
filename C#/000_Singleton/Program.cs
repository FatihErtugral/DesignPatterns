using System;

namespace _000_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();

            Console.WriteLine(singleton1.Id.ToString());

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Id.ToString());

            Console.ReadKey();
        }
    }
}
