using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Human
    {
        public Human()
        {
            Name = String.Empty;
            Age = 0;
        }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1}", Name, Age);
        }
    }
}
