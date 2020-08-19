using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Overload
    {
        public bool Method (ref int num)
        {
            num = 5;
            return true;
        }

        public bool Method (ref string str)
        {
            str = "Hello world";
            return true;
        }

        public bool Method (ref Human human)
        {
            Human h = new Human();
            h.Name = "Alex";
            h.Age = 29;
            human = h;
            return true;
        }

        public bool Method(Human human)
        {
            human.Name = "Petr";
            human.Age = 33;
            return true;
        }
    }
}
