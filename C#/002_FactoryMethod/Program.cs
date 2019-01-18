using System;

namespace _002_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new MySqlFactory());
            factory.Start();

            Console.WriteLine();

            Factory factory2 = new Factory(new DB2Factory());
            factory2.Start();
        }
    }
}
