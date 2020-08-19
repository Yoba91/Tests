using System;
using System.Globalization;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload overload = new Overload();
            string str = "Goodbye";
            int num = 10;
            Human h = new Human("Bob", 40);
            h.Print();
            Console.WriteLine(str);
            Console.WriteLine(num);
            overload.Method(ref str);
            overload.Method(ref num);
            overload.Method(ref h);
            overload.Method(h);
            Console.WriteLine(str);
            Console.WriteLine(num);
            h.Print();
        }
    }
}
