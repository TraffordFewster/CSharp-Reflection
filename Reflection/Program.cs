using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("FIAT", "124 Spider", "SUPERCAR", "2019", 200000.00m);
            Car Car2 = new Car("GMC", "1500 Regular Cab", "ASJ8 SAJN", "1993", 5999.99m);
            Car Car3 = new Car("BMW", "3 Series", "NASH L89A", "2020", 200000.00m);
            Console.WriteLine(Car1);
            Console.WriteLine(Car2);
            Console.WriteLine(Car3);
            Console.ReadLine();
        }
    }
}
