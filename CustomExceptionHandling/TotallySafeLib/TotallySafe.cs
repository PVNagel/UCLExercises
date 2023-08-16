using System;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            if (positionInArray < 0)
            {
                throw new NegativeIndexOutOfRangeException("The input must not be negative.");
            }

            if (positionInArray >= intArray.Length)
            {
                throw new IndexOutOfRangeException("The input was too large");
            }
            return intArray[positionInArray];
        }
    }
}