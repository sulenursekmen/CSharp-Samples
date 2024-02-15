using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Model = "Toyota Camry";
            car.Year = 2020;

            Car car2 = new Car 
            {
               Model="Astra",
               Year=2005,
               Name= "Opel",
            };

            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Name);


            car.StartEngine();

            car.Accelerate();

            car.Brake();

            car.StopEngine();

            

            Console.ReadLine();

        }
    }
}
