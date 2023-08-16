namespace StringChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "HelloO World";
            int countO = 0;
            int countX = 0;

            if (input != string.Empty)
            {
                foreach (char c in input.ToLower())
                {
                    if (c == 'o')
                    {
                        countO++;
                    }

                    else if (c == 'x')
                    {
                        countX++;
                    }
                }
            }

            bool isTrue = false;
            if (countO == countX)
            {
                isTrue = true;
            }

            Console.WriteLine($"For the string: {input}, the amount of o's = {countO} and the amount of x's = {countX}");
            Console.WriteLine($"Are there equal amount of x and o's?: {isTrue}");
            Console.ReadLine();
        }
    }
}