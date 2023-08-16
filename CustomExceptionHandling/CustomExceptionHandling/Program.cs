using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int posValue = TotallySafe.GetValueAtPosition(9);
            Console.WriteLine(posValue);
            }

            catch (NegativeIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            Console.Clear();

            try
            {
                int myInt = TotallySafe.StringToInt("test");
                Console.WriteLine(myInt);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            Console.Clear();

            try
            {
                double result = TotallySafe.Divider(0);
                Console.WriteLine(result);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}