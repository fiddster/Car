using System;

namespace Car
{
    class Program
    {
        static void Main(string [] args)
        {
            Car myCar = new Car("Tesla", "Model 3", "ABC123");

            Console.WriteLine($"{myCar.Brand}, {myCar.Model}, {myCar.RegistrationNumber}");

            Console.WriteLine($"current velocity: {myCar.Velocity}");

            myCar.RegistrationNumber = "HELLOWORLD";

            Console.WriteLine($"{myCar.Brand}, {myCar.Model}, {myCar.RegistrationNumber}");
        }

        
        
    }
}
