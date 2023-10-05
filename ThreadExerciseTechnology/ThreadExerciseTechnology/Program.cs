namespace ThreadExerciseTechnology
{
    internal class Program
    {
        public static int mainSum;
        public static Object Key = new Object();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadWork);
            Thread t2 = new Thread(ThreadWork);
            Thread t3 = new Thread(ThreadWork);

            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t3.Name = "Thread 3";

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("\nMain Sum:" + mainSum);
            Console.ReadLine();
        }

        static void ThreadWork()
        {
            Random random = new Random();
            int mySum = 0;
            int rndNumber = 0;

            for (int i = 0; i < 1000; i++)
            {
                rndNumber = random.Next(9);
                mySum = mySum + rndNumber;
                lock (Key)
                {
                    mainSum = mainSum + rndNumber;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name + " : " + mySum);
        }
    }
}