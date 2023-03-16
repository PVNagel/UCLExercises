using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shift(this string input, int amount)
        {
            // As long as input is not null
            if (input != null)
            {
                // If input is smaller than shift amount, so that the input will run more than a full trip around the input.
                if (input.Length < amount || -input.Length < -amount)
                {
                    // If shift amount is smaller than 0, input length is added to the amount.
                    if (amount < 0)
                    {
                        amount = amount + input.Length;
                    }
                    // If shift amount is larger than 0, input length is subtracted from the amount.
                    else if (amount > 0)
                    {
                        amount = amount - input.Length;
                    }
                }

                // If shift amount is smaller than 0 shift to the left
                if (amount < 0)
                {
                    // Absolute value of amount (Ex. -15 becomes 15)
                    amount = -amount;

                    // Returns combination of first right side of amount input, followed by left side of amount input.
                    return input[amount..] + input[..amount];
                }

                // If shift amount is bigger than 0 shift to the right
                else if (amount > 0)
                {
                    return input[(input.Length - amount)..] + input[..(input.Length - amount)];
                }

                // If amount is 0, return the original input.
                else if (amount == 0)
                {
                    return input;
                }

                // Else return an empty string.
                else
                    return "";
            }
            // If input is null, return an empty string.
            else
                return "";
        }

        //// Returns empty string if input is null
        //if (input == null)
        //{
        //    return "";
        //}

        //// If amount is positive
        //else if (amount > 0)
        //{
        //    // Converting input string to an array.
        //    int index = 0;
        //    char[] inputArray = new char[input.Length];
        //    foreach (char c in input)
        //    {
        //        inputArray[index++] = c;
        //    }

        //    // Array for holding the amount of moving elements of inputArray.
        //    char[] tempArray = new char[amount];
        //    for (int i = 0; i < amount; i++)
        //    {
        //        tempArray[i] = inputArray[inputArray.Length - (i + 1)];
        //    }

        //    // Shifting rest of input array x amount to the right.
        //    for (int i = inputArray.Length - amount; i != 0; i--)
        //    {
        //        inputArray[i] = inputArray[i - 1];
        //    }

        //    // Putting the last elements of original input back into the new array at the start of the array.
        //    index = 0;
        //    foreach (char c in tempArray)
        //    {
        //        inputArray[index++] = c;
        //    }

        //    // Converting char array to a string
        //    string output = new string(inputArray);
        //    return output;
        //}

        //// If amount is negative
        //else if (amount < 0)
        //{
        //    // Converting input string to an array.
        //    int index = 0;
        //    char[] inputArray = new char[input.Length];
        //    foreach (char c in input)
        //    {
        //        inputArray[index++] = c;
        //    }

        //    // Array for holding the amount of moving elements of inputArray.
        //    char[] tempArray = new char[Math.Abs(amount)];
        //    for (int i = 0; i < Math.Abs(amount); i++)
        //    {
        //        tempArray[i] = inputArray[i];
        //    }

        //    // Shifting rest of input array x amount to the left.
        //    for (int i = 0; i < inputArray.Length - 1; i++)
        //    {
        //        inputArray[i] = inputArray[i + 1];
        //    }

        //    // Putting the last elements of original input back into the new array at the start of the array.
        //    index = inputArray.Length + amount;
        //    foreach (char c in tempArray)
        //    {
        //        inputArray[index++] = c;
        //    }

        //    // Converting char array to a string
        //    string output = new string(inputArray);
        //    return output;
        //}

        //// Returns original input if amount is 0.
        //return input;
    }
}
