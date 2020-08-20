using System;
using Tests;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World(10);
            Human human = new Human { Name = "Anton", Age = 18 };
            Human human1 = new Human { Name = "Alex", Age = 24 };
            Human human2 = new Human { Name = "Andrey", Age = 36 };
            Human human3 = new Human { Name = "Mick", Age = 13 };
            Human human4 = new Human { Name = "Jeff", Age = 55 };
            try
            {
                world[0] = human;
                world[1] = human1;
                world[2] = human2;
                world[3] = human3;
                world[4] = human4;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            for (int i = 0; i < world.Size; i++)
            {
                if(world[i]?.Name != null)
                Console.WriteLine("{0} {1}", world[i]?.Name, world[i]?.Age);
            }
            Console.WriteLine("В мире живет {0} человек", world.Count);
        }
    }
}
