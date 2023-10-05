using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosophersTable.Model
{
    public class Chopstick
    {
        public int Id { get; set; }
        public bool IsUsed { get; set; }

        public Chopstick(int id)
        {
            Id = id;
            IsUsed = false;
        }
    }
}
