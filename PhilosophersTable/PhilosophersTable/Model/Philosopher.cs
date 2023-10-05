using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosophersTable.Model
{
    public class Philosopher
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Chopstick LeftChopstick { get; set; }
        public Chopstick RightChopstick { get; set; }
        public bool HasEaten { get; set; }

        public Philosopher(int id, string name, Chopstick leftChopstick, Chopstick rightChopstick)
        {
            Id = id;
            Name = name;
            LeftChopstick = leftChopstick;
            RightChopstick = rightChopstick;
            HasEaten = false;
        }
    }
}
