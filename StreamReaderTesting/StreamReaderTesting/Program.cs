namespace StreamReaderTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\phili\Documents\Code\UCL\Exercises\StreamReaderTesting\StreamReaderTesting\testingDocument.txt";
            StreamReader sr = new StreamReader(fileName);

            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }

            finally
            {
                sr.Close();
            }

        }
    }
}