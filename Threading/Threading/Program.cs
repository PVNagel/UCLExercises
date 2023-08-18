namespace Threading
{
    internal class Program
    {
        static object lockObject = new object();

        static void Main(string[] args)
        {
            // Metode som argument til Thread
            Thread thread1 = new Thread( PrintHelloWorldMethod );

            // Lambda udtryk som argument til Thread
            Thread thread2 = new Thread(() => PrintHelloWorld( "Hello world (lambda)" ));

            // Anonym metode som argument til Thread
            Thread thread3 = new Thread(delegate () { PrintHelloWorld( "Hello world (anonym)"); });

            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Vent på, at alle tråde er færdige
            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Alle tråde er færdige.");
        }

        static void PrintHelloWorldMethod()
        {
            lock (lockObject)
            {
                PrintHelloWorld("Hello world (metode)");
            }
        }

        static void PrintHelloWorld(string message)
        {
            lock (lockObject)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}