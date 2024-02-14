using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            ForEachLoop();

            Console.ReadLine();

        }

        private static void ForEachLoop()
        {
            //ForeachLoop

            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                { 1, "Alice" },
                { 2, "Bob" },
                { 3, "Charlie" }
            };

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"Öğrenci ID: {student.Key}, İsim: {student.Value}");
            }
        }

        private static void DoWhileLoop()
        {
            //Example 1
            int number = 20;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            Console.ReadLine();

            //Example 2

            //This example asks the user to enter five numbers. If the user enters an empty input or a non-integer value, the program considers the input invalid and terminates the loop. The program ends when the user makes a valid input five times.
            int count = 0;

            do
            {
                Console.WriteLine("Please enter a number (or press Enter to exit): ");
                string input = Console.ReadLine();

                // Check if the user pressed Enter or entered a non-integer input
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int number2))
                {
                    break;
                }

                Console.WriteLine($"You entered: {number2}");
                count++;
            } while (count < 5); // Change this to the desired count of numbers to enter
            Console.WriteLine("Exiting the program.");
        }

        private static void WhileLoop()
        {
            //While Loop

            //Example 1
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //Example 2
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);

            while (randomNumber != 5)
            {
                Console.WriteLine("Random number: " + randomNumber);
                randomNumber = rnd.Next(1, 10);
            }
        }

        public static void ForLoop()
        {
            //For Loop
            Console.WriteLine("Prime numbers from 1 to 100:");

            // Check each number from 2 to 100 to see if it's prime.
            for (int num = 2; num <= 100; num++)
            {
                bool isPrime = true;

                // Check if the number is divisible by any number from 2 to its square root.
                // If it is, then it's not prime.
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // If the number is prime, print it.
                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }


            //Ask the user to enter a number and display all the prime numbers up to that number.

            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers up to " + userInput + ":");

            for (int num = 2; num <= userInput; num++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
