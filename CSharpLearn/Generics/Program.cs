using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // Creates a list of strings
            list.Add("A"); // Adds "A" to the list
            Console.WriteLine(list.Count); // Prints the count of the list (1)
            Console.WriteLine(list[0]); // Prints the first item in the list ("A")

            MyList<string> list2 = new MyList<string>(); // Creates an instance of MyList<string>
            list2.Add("A"); // Adds "A" to the list
            Console.WriteLine(list2.Count); // Prints the count of the list (1)

            Console.ReadLine(); // Waits for a key press
        }

        class MyList<T> // Generic class definition
        {
            T[] _array; // Array to store items
            T[] _tempArray; // Temporary array to store items during resizing

            public MyList() // Constructor
            {
                _array = new T[0]; // Initializes the array with size 0
            }

            public void Add(T item) // Adds an item to the list
            {
                _tempArray = _array; // Stores the current array in a temporary variable
                _array = new T[_array.Length + 1]; // Creates a new array with one more element

                for (int i = 0; i < _tempArray.Length; i++) // Copies the elements from the temporary array to the new array
                {
                    _array[i] = _tempArray[i];
                }

                _array[_array.Length - 1] = item; // Adds the new item to the last index of the new array
            }

            public int Count // Gets the number of items in the list
            {
                get { return _array.Length; } // Returns the length of the array
                //set { _count = value; } // This line would allow setting the count manually, but it's commented out because it's not used in this example
            }
        }
    }
}
