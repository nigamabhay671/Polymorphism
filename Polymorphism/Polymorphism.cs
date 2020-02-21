using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Polymorphism
    {
        public void Add()
        {
            int a = 10;
            int b = 3;
            int c = a + b;
            Console.WriteLine(c) ;
        }
        public void Add(int a,int b)
        {           
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a,int b,int d)
        {
            int c = a + b+d;
            Console.WriteLine(c);
        }

    }
}
