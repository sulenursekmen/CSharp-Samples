using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Value Types
            // Integer Data Types   
            // The 'int' type's range is between -2,147,483,648 and 2,147,483,647 (-2^31 to +2^31-1) / 32 bits  
            int number1 = 10;
            int number2 = 20;
            // The 'long' type's range is between -2^63 (-9,223,372,036,854,775,808) and +2^63-1 (9,223,372,036,854,775,807) / 64 bits 
            long number3 = 30;
            // The 'short' type's range is between -2^15  (-32,768) and +2^15-1 (32,767) / 16 bits  
            short number4 = 35;
            // The 'byte' type's range is between -128 and +127 / 8 bits
            byte number5 = 6;

            // {0}{1} indicates index
            Console.WriteLine("Number1 is {0}{1}{2}{3}{4}", number1, number2, number3, number4, number5);

            // Boolean Data Type
            // Occupies 1 bit of memory, can hold either 'true' or 'false'
            bool isLoading = true;

            // Char Data Type
            // Written with single quotes, occupies 16 bits of memory  
            char character = 'a';

            Console.WriteLine(isLoading.ToString() + (int)character);


            // Floating Point Numbers 
            // The 'double' type holds 64 bits, providing 15-16 digits of precision
            double number6 = 5.4;
            // The 'decimal' type holds larger 28-digit numbers, appending 'M' at the end to indicate decimal
            decimal number7 = 10.8M;
            Console.WriteLine(number6.ToString() + " / " + number7.ToString());

            //enum
            Console.WriteLine((int)Days.Sunday);

            // var 
            var example = "Sule Nur";
            Console.WriteLine(example);

            // String Variable
            // A string variable is essentially an array of characters.

            // Console.WriteLine("Hello to C# Again");
            // Waits for the user to perform an operation (press a key)
            Console.ReadLine(); 
        }

        // Enum Data Type
        enum Days
        {
            Monday=5, Tuesday, Wednesday, Friday, Sunday
        }

    }
}
