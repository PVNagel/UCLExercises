using System.Data;

namespace AgeOfGroupWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfPhilip = 23;
            int ageOfRuben = 26;
            int ageOfVuong = 21;
            int ageOfBenjamin = 20;
            int ageOfValdemar = 24;
            int ageOfChristoffer = 35;
            int howManyBoys = 6;

            Console.WriteLine("Age of THE BOYS");
            Console.WriteLine("Philip: " + ageOfPhilip);
            Console.WriteLine("Ruben: " + ageOfRuben);
            Console.WriteLine("Vuong: " + ageOfVuong);
            Console.WriteLine("Benjamin: " + ageOfBenjamin);
            Console.WriteLine("Valdemar: " + ageOfValdemar);
            Console.WriteLine("Christoffer: " + ageOfChristoffer);
            Console.WriteLine();
            
            int averageAge = (ageOfPhilip + ageOfRuben + ageOfVuong + ageOfBenjamin + ageOfValdemar + ageOfChristoffer) / howManyBoys;

            Console.WriteLine("Average age of THE BOYS: " + averageAge);
            Console.WriteLine();

            // ReadLine to keep console open for testing.
            Console.WriteLine("PRESS ENTER TO GET THE SAME WITH ARRAYS");
            Console.ReadLine();
            Console.Clear();

            /*
             *  PART 2 MED ARRAYS
             */

            int[] ageArray = { ageOfPhilip, ageOfRuben, ageOfVuong, ageOfBenjamin, ageOfValdemar, ageOfChristoffer };
            string[] nameArray = { "Philip", "Ruben", "Vuong", "Benjamin", "Valdemar", "Christoffer" };

            // Resets averageAge for new calculator in part 2.
            averageAge = 0;

            for (int i = 0; i < ageArray.Length; i++)
            {
                averageAge = averageAge + ageArray[i];
            }

            double averageDecimalAge = (double)averageAge / howManyBoys;

            int counter = 0;
            while(counter < ageArray.Length)
            {
                Console.WriteLine( "Age of " + nameArray[counter] + " is: " + ageArray[counter] );
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("The average age of the boys is: " + averageDecimalAge);
            Console.WriteLine();
            Console.WriteLine("Time to search for a number");
            Console.WriteLine("Which one would you like to check if it is in the array?:");
            int searchNumber = int.Parse( Console.ReadLine() );

            // Resets counter
            counter = 0;
            while( counter < ageArray.Length)
            {
                if (searchNumber == ageArray[counter])
                {
                    Console.WriteLine("The number you searched for is in the Array!");
                    break;
                }
                counter++;
            }

            if (counter == ageArray.Length)
            {
                Console.WriteLine("The number you searched for is unfortunately not in the array.");

            }
            Console.ReadLine();
            Console.Clear();

            // PART 3
            Console.WriteLine("How many people are in your group?:");

            try
            {
                int groupSize = int.Parse(Console.ReadLine());

                int[] ageOfGroupMembers = new int[groupSize];

                counter = 0;
                while (counter < groupSize)
                {
                    Console.WriteLine("What is the age of group member " + counter + ":");
                    ageOfGroupMembers[counter] = int.Parse(Console.ReadLine());
                    Console.Clear();
                    counter++;
                }

                Console.WriteLine();
                Console.WriteLine("HERE IS YOUR GROUP:");

                int count2 = 0;
                while (count2 < groupSize)
                {
                    Console.WriteLine("Group member nr " + count2 + " is " + ageOfGroupMembers[count2] + " years old.");
                    count2++;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}   