using PhilosophersTable.Model;

namespace PhilosophersTable
{
    internal class Program
    {
        static int PhilosophersWhoHaveEaten = 0;
        static Object EatReport = new Object();

        static void Main(string[] args)
        {
            // Initialize Chopsticks
            Chopstick cs1 = new Chopstick(1);
            Chopstick cs2 = new Chopstick(2);
            Chopstick cs3 = new Chopstick(3);
            Chopstick cs4 = new Chopstick(4);
            Chopstick cs5 = new Chopstick(5);

            // Initialize Philosophers
            Philosopher philosopher1 = new Philosopher(1, "Socrates" , cs1, cs2);
            Philosopher philosopher2 = new Philosopher(2, "Aristotle", cs2, cs3);
            Philosopher philosopher3 = new Philosopher(3, "Karl Marx", cs3, cs4);
            Philosopher philosopher4 = new Philosopher(4, "Confucius", cs4, cs5);
            Philosopher philosopher5 = new Philosopher(5, "John Locke", cs5, cs1);

            // Initialize Threads
            Thread t1 = new Thread(() => Eat(philosopher1));
            Thread t2 = new Thread(() => Eat(philosopher2));
            Thread t3 = new Thread(() => Eat(philosopher3));
            Thread t4 = new Thread(() => Eat(philosopher4));
            Thread t5 = new Thread(() => Eat(philosopher5));

            // Start Threads
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            // Join Threads
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();

            if (PhilosophersWhoHaveEaten == 5)
            {
                Console.WriteLine("\nAll Philosophers have finished eating!");
            }
        }

        public static void Eat(Philosopher philosopher)
        {
            while (philosopher.HasEaten == false)
            {
                lock (philosopher.LeftChopstick)
                {
                    lock (philosopher.RightChopstick)
                    {
                        Console.WriteLine(philosopher.Name + " is eating.");
                        Thread.Sleep(1000);
                        Console.WriteLine(philosopher.Name + " has stopped eating.");
                        philosopher.HasEaten = true;
                        lock (EatReport)
                        {
                            PhilosophersWhoHaveEaten = PhilosophersWhoHaveEaten + 1;
                            Console.WriteLine("Philosophers who have eaten: " + PhilosophersWhoHaveEaten + "/5");
                        }
                    }
                }
            }
        }
    }
}