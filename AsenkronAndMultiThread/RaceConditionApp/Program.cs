using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceConditionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exampleValue=0;

            Parallel.ForEach(Enumerable.Range(1, 100000).ToList(), (x) =>
            {
                exampleValue = x;
            });

            Console.WriteLine(exampleValue);
            Console.ReadLine();
        }
    }
}
