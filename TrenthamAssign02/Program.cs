using System;

namespace TrenthamAssign02
{
    class Program
    {
        public 

        static void Main(string[] args)
        {
            Dignity dignity = new Dignity();
            DragonBuilder builder = new DragonBuilder();
            string choice = "";

            while (choice != "7")
            {
                Console.WriteLine("1. Add a dragon " +
                             "2. Get number of dragons in the dignity" +
                             "3. Find the largest dragon" +
                             "4. Find the largest dragon of a type" +
                             "5. Get the count of good" +
                             "6. Get the count of bad dragons" +
                             "7. Quit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1" :
                        builder.BuildDragon();
                        dignity.AddDragon(builder.GetDragon());
                        break;
                    case "2":
                        Console.WriteLine($"There are {dignity.Count()} in the dignity.");
                        break;
                    case "3":
                        Dragon dragon = dignity.GetLargest();
                        Console.WriteLine($"The largest dragon is: {dragon.ToString()}");
                        break;
                    case "4":
                        Console.WriteLine("Enter the type of dragon you are looking for: ");
                        string type = Console.ReadLine();

                        break;
                    case "5":
                        Console.WriteLine("");
                        break;
                    case "6":
                        Console.WriteLine("");
                        break;
                    case "7":
                        Console.WriteLine("Program ending...");
                        break;
                        
                }
            }

        }
        
        public void GetDragon()
        {
            Console.WriteLine();
        }
    }
}
