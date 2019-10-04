using System;

namespace Car
{
    class Program
    {
        static void Main(string [] args)
        {
            Car[] carList = new Car[10];
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
                            Console.WriteLine("Add car");
                            Console.WriteLine();
                            Console.WriteLine("Brand: ");
                            Console.WriteLine("Model: ");
                            //Console.WriteLine("Registration number: ");

                            Console.SetCursorPosition("Brand: ".Length + 2, 2);
                            string brand = Console.ReadLine();

                            Console.SetCursorPosition("Model: ".Length + 2, 3);
                            string model = Console.ReadLine();

                            carList[carListCounter++] = new Car(brand, model);
                        }
                    break;

                    case ConsoleKey.D2:
                    {
                            Console.WriteLine("Brand".PadRight(30, ' ') + "Model".PadRight(30, ' '));
                            Console.WriteLine("".PadRight(60, '-'));

                            foreach (Car car in carList)
                            {
                                if (car == null) continue;

                                Console.WriteLine($"{car.Brand}".PadRight(30, ' ') + $"{car.Model}".PadRight(30, ' '));
                            }

                            Console.WriteLine("<Press any key to continue>");
                            Console.ReadKey(true);

                    }
                    break;

                    case ConsoleKey.D3:
                    {

                    }
                    break;

                    case ConsoleKey.D4:
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
            Console.WriteLine("3. Simulate speed");
            Console.WriteLine("4 Exit program");

        }
        
        
    }
}
