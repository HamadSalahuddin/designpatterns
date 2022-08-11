using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;
            var db3 = SingletonDataContainer.Instance;
            var db4 = SingletonDataContainer.Instance;

            Console.WriteLine($"db hascode {db.GetHashCode()}");
            Console.WriteLine($"db2 hascode {db2.GetHashCode()}");
            Console.WriteLine($"db3 hascode {db3.GetHashCode()}");
            Console.WriteLine($"db4 hascode {db4.GetHashCode()}");
        }
    }
}
