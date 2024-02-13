using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine()
            Console.WriteLine("Hello World!");

            // Console.ReadLine()
            Console.WriteLine("Enter your name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Hello, " + name1);
            Console.ReadLine();
            // Convert.ToInt32()
            int number = Convert.ToInt32("42");

            // string.ToLower()
            string text1 = "Hello World!";
            string lowerCaseText = text1.ToLower();

            // string.ToUpper()
            string text2 = "Hello World!";
            string upperCaseText = text2.ToUpper();

            // string.Contains()
            string text3 = "Hello World!";
            bool containsWorld = text3.Contains("World");

            // string.Split()
            string names = "Ali, Veli, Ayşe";
            string[] nameArray = names.Split(',');


            // Print outputs
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Lowercase text: " + lowerCaseText);
            Console.WriteLine("Uppercase text: " + upperCaseText);
            Console.WriteLine("Does the text contain 'World'? " + containsWorld);
            Console.WriteLine("Names:");
            foreach (string name in nameArray)
            {
                Console.WriteLine(name.Trim()); // Trim() is used to remove spaces
            }


            // Sum() method
            // Calculates the sum of all numbers in an array.
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = numbers.Sum();
            Console.WriteLine("Sum of the Array: " + sum);

            // Sort() method
            // Sorts an array.
            int[] arrayToSort = { 5, 3, 1, 4, 2 };
            Array.Sort(arrayToSort);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrayToSort));

            // IndexOf() method
            // Finds the first index of a specified item in an array.
            int[] array = { 1, 2, 3, 4, 5 };
            int index = Array.IndexOf(array, 3); // index = 2
            Console.WriteLine("Index of the Searched Number: " + index);




            Add();
            // Add2() method
            int result = Add2(10);
            Console.WriteLine("Result: " + result);

            //Add3() method 
            int number1 = 100;
            int number2 = 101;
            var result2 = Add3(ref number1, number2);
            var result3 = Add4(out number1, number2);

            Console.WriteLine("Result2: " + result2 + number1);
            Console.WriteLine("Result3: " + result3 + number1);

            //ref keyword 
            // Using ref keyword to pass a variable by reference
            // `ref` keyword allows the method to modify the original variable
            int value = 10;
            ModifyValue(ref value);
            Console.WriteLine(value); // Output: 20

            //out keyword
            // Using out keyword to return multiple values from a method
            int resultQuotient, resultRemainder;
            Divide(12, 3, out resultQuotient, out resultRemainder);
            Console.WriteLine("Quotient: " + resultQuotient); // Output: 3
            Console.WriteLine("Remainder: " + resultRemainder); // Output: 1

            // Method Overloading

            Console.WriteLine(Multiply(4,3));
            Console.WriteLine(Multiply(4,3,2));

            //Method to calculate factorial of a number
            int number4 = 4;
            int factorial = CalculateFactorial(number4);
            Console.WriteLine("Factorial of " + number4 + " is: " + factorial);

            //params keyword
            Console.WriteLine(Add5(1,3,5,7));

            Console.ReadLine();


        }
        static void Add()
        {
            Console.WriteLine("Added");
        }

        //Default parameter is written at the end.
        static int Add2(int number1, int number2 = 37)
        {
            return number1 + number2;
        }

        // ref keyword 
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }
        // Method that modifies the value passed by reference using `ref` keyword
        static void ModifyValue(ref int number)
        {
            // The value of `number` is modified and it affects the original variable
            number = number * 2;
        }



        //out keyword 
        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }

        // Method that returns multiple values using `out` keyword
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            // `out` parameters must be assigned inside the method
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }


        // Method Overloading

        static int Multiply(int number1, int number2)
        { 
            return number1 * number2; 
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        // Method to calculate factorial of a number
        static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1; // 0! = 1
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        //params keyword 
        static int Add5(params int[] numbers)
        {
           return numbers.Sum();
        }


    }
}
