using System;

namespace Car
{
    class Program
    {
        static void Main(string [] args)
        {
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
                    
                    }
                    break;
                    case ConsoleKey.D2:
                    {

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
