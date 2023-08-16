using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Choice;
            int MenuOption;
            int x;
            int y;

            // Creates an instance of the calculator
            Calculator calculator = new Calculator();

            // Selects the case associated with user input.
            do
            {
                menu();
                // Takes user input.
                MenuOption = int.Parse(Console.ReadLine());
                clear();

                switch (MenuOption)
                {
                    case 1:
                        Console.WriteLine("Which numbers do you want to add?");
                        Console.WriteLine("Please enter your first value:");
                        x = int.Parse(Console.ReadLine());
                        clear();

                        Console.WriteLine("Please enter your second value:");
                        y = int.Parse(Console.ReadLine());
                        clear();

                        Console.WriteLine(calculator.Add(x, y));
                        break;

                    case 2:
                        Console.WriteLine("Which numbers do you want to subtract?");
                        Console.WriteLine("Please enter your first value:");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter your second value:");
                        y = int.Parse(Console.ReadLine());

                        Console.WriteLine(calculator.Subtract(x, y));
                        break;

                    case 3:
                        Console.WriteLine("Which numbers do you want to divide?");
                        Console.WriteLine("Please enter your first value:");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter your second value:");
                        y = int.Parse(Console.ReadLine());

                        Console.WriteLine(calculator.Divide(x, y));
                        break;

                    case 4:
                        Console.WriteLine("Which numbers do you want to multiply?");
                        Console.WriteLine("Please enter your first value:");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter your second value:");
                        y = int.Parse(Console.ReadLine());

                        Console.WriteLine(calculator.Multiply(x, y));
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                clear();
                Console.WriteLine("ENTER Y TO GO BACK TO THE MENU");
                Console.WriteLine("OR");
                Console.WriteLine("ENTER ANY KEY TO EXIT");
                Choice = Convert.ToChar(Console.ReadLine());
                clear();

            } while (Char.ToUpper(Choice) == 'Y');
        }
        /*
         *  Prints a Menu for the user. 
         */
        public static void menu()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("*       WELCOME TO YOUR CALCULATOR         *");
            Console.WriteLine("*         PLEASE SELECT AN OPTION          *");
            Console.WriteLine("********************************************");
            Console.WriteLine("*                                          *");
            Console.WriteLine("* 1. Add                                   *");
            Console.WriteLine("* 2. Subtract                              *");
            Console.WriteLine("* 3. Divide                                *");
            Console.WriteLine("* 4. Multiply                              *");
            Console.WriteLine("* 5. EXIT                                  *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("********************************************");
            Console.WriteLine();
        }
        public static void clear()
        {
            Console.Clear();
        }
    }
}