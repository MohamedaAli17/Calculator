using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Lab2
    {
        public static void test_lab2()
        {
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("Please choose from number 1 to 4: ");
                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program GOODBYE");
                        break;
                    default:
                        Console.WriteLine("Please enter a correct number");
                        break;
                }

            }

        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to my calculation app thingy");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("3.Division");
            Console.WriteLine("4. Exit");
        }

        static void Addition()
        {
            Console.WriteLine("Enter the first number: ");
            string userInput1String = Console.ReadLine();

            
            if (double.TryParse(userInput1String, out double userInput1))
            {
                Console.WriteLine("Enter the second number: ");
                string userInput2String = Console.ReadLine();

                
                if (double.TryParse(userInput2String, out double userInput2))
                {
                    double answer = userInput1 + userInput2;

                    Console.WriteLine($"The sum is: {answer}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
            }
        }
        static void Subtraction() 
        {
            Console.WriteLine("Enter the first number: ");
            string userInput1String = Console.ReadLine();


            if (double.TryParse(userInput1String, out double userInput1))
            {
                Console.WriteLine("Enter the second number: ");
                string userInput2String = Console.ReadLine();


                if (double.TryParse(userInput2String, out double userInput2))
                {
                    double answer = userInput1 - userInput2;

                    Console.WriteLine($"The sum is: {answer}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid integer or decimal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer or decimal.");
            }
        }
        
        static void Multiplication()
        {
            Console.WriteLine("Enter the first number: ");
            string userInput1String = Console.ReadLine();


            if (double.TryParse(userInput1String, out double userInput1))
            {
                Console.WriteLine("Enter the second number: ");
                string userInput2String = Console.ReadLine();


                if (double.TryParse(userInput2String, out double userInput2))
                {
                    double answer = userInput1 * userInput2;

                    Console.WriteLine($"The sum is: {answer}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid integer or decimal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer or decimal.");
            }

        }
        
        static void Division()
        {
            Console.WriteLine("Enter the first number: ");
            string userInput1String = Console.ReadLine();


            if (double.TryParse(userInput1String, out double userInput1))
            {
                Console.WriteLine("Enter the second number: ");
                string userInput2String = Console.ReadLine();


                if (double.TryParse(userInput2String, out double userInput2))
                {
                    double answer = userInput1 / userInput2;

                    Console.WriteLine($"The sum is: {answer}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid integer or decimal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer or decimal.");
            }

        }
    }
}
