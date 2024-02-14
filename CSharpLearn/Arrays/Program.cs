using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Single-dimensional array (string type)
            string[] students = new string[5]; // A string array to store student names
            students[0] = "A";
            students[1] = "B";
            students[2] = "C";
            students[3] = "D";
            students[4] = "E";

            // Two-dimensional array (string type)
            string[,] regions = new string[5, 3] // A two-dimensional array to store city names
            {
                {"İstanbul", "İzmit ", "Edirne " }, // First row: cities in Marmara region
                {"Ankara ", "Konya ", "Kırıkkale " }, // Second row: cities in Central Anatolia region
                {"Antalya ", "Adana  ", "Mersin " }, // Third row: cities in Mediterranean region
                {"Rize ", "Trabzon ", "Samsun " }, // Fourth row: cities in Black Sea region
                {"İzmir ", "Muğla", "Manisa " }, // Fifth row: cities in Aegean region
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (global::System.Int32 j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                  
                } 
                Console.WriteLine("************");
            }


            // Adding new students to the single-dimensional array
            students[3] = "F";
            students[4] = "G";

            // Adding new cities to the two-dimensional array
            regions[4, 0] = "Aydın";
            regions[4, 1] = "Denizli";
            regions[4, 2] = "Uşak";

            // Accessing elements of the single-dimensional array
            Console.WriteLine("List of students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("************");

            // Accessing elements of the two-dimensional array
            Console.WriteLine("List of cities in Turkey:");
            for (int i = 0; i < regions.GetLength(0); i++)
            {
                for (int j = 0; j < regions.GetLength(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            // Sorting elements of the single-dimensional array alphabetically
            Array.Sort(students);
            Console.WriteLine("Students sorted alphabetically:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Reversing the elements of the single-dimensional array
            Array.Reverse(students);
            Console.WriteLine("Reversed student list:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
