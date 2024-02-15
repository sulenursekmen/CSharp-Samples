using System;

namespace Classes
{
    public class Car
    {
        //field
        //public string Name;
        // Properties

        public string Model { get; set; }
        public int Year { get; set; }

        private string _firstName;

        //Encapsulation
        public string Name 
        {
            get 
            {
                return "New " + _firstName;
            } 
            set 
            {
                _firstName = value;
            } 
        }

        
        // Methods
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }

        public void Brake()
        {
            Console.WriteLine("Car is braking.");
        }
    }
}
