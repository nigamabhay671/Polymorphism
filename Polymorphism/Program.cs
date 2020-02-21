using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism p = new Polymorphism();
            p.Add();
            p.Add(2, 3);
            p.Add(1, 2, 3);

            Console.WriteLine("Hello World!");
        }
    }
}
