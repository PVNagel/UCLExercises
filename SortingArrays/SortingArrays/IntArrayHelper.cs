using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    public class IntArrayHelper
    {
        public int[] Sort(int[] intArray)
        {
            int[] result = new int[intArray.Length];

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            return result;
        }

        public int[] Reverse(int[] intArray)
        {
            int[] result = new int[intArray.Length];

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            return result;
        }
    }
}
