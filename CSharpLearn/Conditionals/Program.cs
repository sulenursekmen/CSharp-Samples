using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number1 = 20;

            // Using if-else statements to check the value of number1
            if (number1 == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number1 == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 || 20");
            }

            // Using ternary conditional operator to achieve the same
            Console.WriteLine(number1 == 10 ? "Number is 10" : number1 == 20 ? "Number is 20" : "Number is not 10 || 20");

            // Switch case to determine the day corresponding to the entered number
            Console.WriteLine("Please enter a day number (1-7):");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName = "";

            switch (dayNumber)
            {
                case 1: dayName = "Monday"; break;
                case 2: dayName = "Tuesday"; break;
                case 3: dayName = "Wednesday"; break;
                case 4: dayName = "Thursday"; break;
                case 5: dayName = "Friday"; break;
                case 6: dayName = "Saturday"; break;
                case 7: dayName = "Sunday"; break;
                default: dayName = "Invalid day number"; break;
            }

            // Using if-else statements to check the range of number1
            if (number1 >= 0 && number1 <= 100)
            {
                Console.WriteLine("The number is between 0 and 100.");
            }
            else if (number1 < 0)
            {
                Console.WriteLine("The number is less than 0.");
            }
            else
            {
                Console.WriteLine("The number is greater than 100.");
            }

            // Printing the day corresponding to the entered number
            Console.WriteLine($"The day corresponding to the entered number: {dayName}");
            int number = 15;

            // Check if the number is non-negative
            if (number >= 0)
            {
                Console.WriteLine("Number is non-negative.");

                // If the number is non-negative, check if it is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is even.");
                }
                else
                {
                    Console.WriteLine("Number is odd.");
                }
            }
            else
            {
                // If the number is negative, print a message
                Console.WriteLine("Number is negative.");
            }

            Console.ReadLine();
        }
    }
}
