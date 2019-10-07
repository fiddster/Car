using System;
using System.Threading;

namespace Car
{
    class Program
    {
        static Car[] carList = new Car[10];

        static void Main(string [] args)
        {
            int carListCounter = 0;

            bool programShouldRun = true;
            
            while (programShouldRun)
            {
                Console.Clear();
                
                PrintMainMenu();

                ConsoleKeyInfo keyPress = Console.ReadKey();
                
                Console.Clear();
                
                switch (keyPress.Key)
                {
                    case ConsoleKey.D1:
                    {
                            Console.WriteLine("Registration number:");
                            Console.SetCursorPosition("Registration number:".Length + 2, 0);
                            string registrationNumber = Console.ReadLine();

                            Console.WriteLine("Choose car");
                            Console.WriteLine("1. Tesla Model 3");
                            Console.WriteLine("2. Volvo 240");

                            ConsoleKeyInfo choise = Console.ReadKey(true);

                            Car newCar = null;

                            if (choise.Key == ConsoleKey.D1)
                            {
                                newCar = new TeslaModel3(registrationNumber);
                            }
                            else if(choise.Key == ConsoleKey.D2)
                            {
                                newCar = new Volvo240(registrationNumber);
                            }

                            carList[carListCounter++] = newCar;
                        }
                    break;

                    case ConsoleKey.D2:
                    {
                            Console.WriteLine("Brand".PadRight(15, ' ') + "Model".PadRight(15, ' ') + "Registration number");
                            Console.WriteLine("".PadRight(50, '-'));

                            foreach (Car car in carList)
                            {
                                if (car == null) continue;

                                Console.WriteLine(  $"{car.Brand}".PadRight(15, ' ') + 
                                                    $"{car.Model}".PadRight(15, ' ') + 
                                                    $"{car.RegistrationNumber}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("<Press any key to continue>");
                            Console.ReadKey(true);

                    }
                    break;

                    case ConsoleKey.D3:
                    {
                            Console.WriteLine("Current registration number:");
                            Console.WriteLine("New registration number:");

                            Console.SetCursorPosition("Current registration number:".Length + 2, 0);
                            string currentRegistrationNumber = Console.ReadLine();

                            
                            Console.SetCursorPosition("New registration number:".Length + 2, 1);
                            string newRegistrationNumber = Console.ReadLine();

                            Car carToEdit = SearchCarByRegistrationNumber(currentRegistrationNumber);

                            if(carToEdit != null)
                            {
                                carToEdit.SetRegistrationNumber(newRegistrationNumber);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Car with registration number: {currentRegistrationNumber} could not be found");
                                Thread.Sleep(1500);
                            }

                    }
                    break;

                    case ConsoleKey.D4:
                    {
                            Console.WriteLine("Length of simulation (Seconds): ");

                            Console.SetCursorPosition("Length of simulation (Seconds): ".Length, 0);

                            var seconds = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("Brand".PadRight(15, ' ') +"Model".PadRight(15, ' ')+ "Velocity km/h");
                            Console.WriteLine("".PadRight(60, '-'));

                            foreach (Car car in carList)
                            {
                                if (car == null) continue;
                                car.Accelerate(seconds);

                                Console.WriteLine(car.Brand.PadRight(15, ' ') + car.Model.PadRight(15, ' ') + car.Velocity);
                            }

                            Console.WriteLine();
                            Console.WriteLine("<Press any key to continue>");
                            Console.ReadKey(true);
                    }
                    break;

                    case ConsoleKey.D5:
                    {
                        programShouldRun = false;
                    }
                    break;  

                    default:
                        break;
                }

            }
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Add car");
            Console.WriteLine("2. List car");
            Console.WriteLine("3. Change registration number");
            Console.WriteLine("4. Simulate speed");
            Console.WriteLine("5. Exit program");

        }
        
        public static Car SearchCarByRegistrationNumber(string value)
        {
            Car carToReturn = null;
            foreach (Car car in carList)
            {
                if (car == null) continue;
                else if (car.RegistrationNumber.Equals(value))
                {
                    carToReturn = car;
                    return carToReturn;
                }
            }
            return carToReturn;
        }
    }
}
