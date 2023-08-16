using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;            // Defines age of the tree.
        private int height;         // Defines height of the tree.
        private bool treeAlive;     // Defines if the tree is alive or not (bool).
        private int numOranges;     // Number of oranges on the tree.
        private int orangesEaten;   // Number of eaten oranges from the tree.

        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 0)
                {
                    this.age = age;
                }
                else
                {
                    this.age = -1;
                }
            }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }

        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {
            orangesEaten = 0;

            // Tree age incrementet by 1
            age = age + 1;

            // Tree is alive while age is under 80
            if (age >= 80)
            {
                treeAlive = false;
                numOranges = 0;
            }

            if (treeAlive == true)
            {
                // Tree height incrementet by 2 if age is under 80.
                height = height + 2;

                // The tree does not give fruit the first year, but afterwards increases its production by 5 oranges per. year (Fruit does not carry over)
                if (age > 1)
                {
                    numOranges = (age * 5 - 5);
                }
            }
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count;
                numOranges = numOranges - count;
            }
        }
    }
}
