using System;
using System.Collections.Generic;
using System.Text;
using Tests;

namespace Indexers
{
    public class World
    {
        private Human[] humans;
        private int count;
        private int size;

        public World(int countHumans)
        {
            if (countHumans <= 0)
                throw new ArgumentOutOfRangeException("Людей должно быть больше");

            this.size = countHumans;
            this.count = 0;
            humans = new Human[size];
        }

        public Human this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    throw new ArgumentOutOfRangeException("Индекс человека вышел за границы");
                return humans[index];
            }

            set 
            {
                if (index < 0 || index >= size)
                    throw new ArgumentOutOfRangeException("Индекс человека вышел за границы");
                if (value is Human && count < size)
                {
                    humans[index] = value;
                    count++;
                }
                if (value == null)
                {
                    humans[index] = value;
                    count--;
                }
            }
        }

        public Int32 Count { get { return count; } }
        public Int32 Size { get { return size; } }
    }
}
