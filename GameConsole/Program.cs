using GameConsole;
using System;

namespace ZooGame
{
    public class Program
    {
        public static void Main()
        {

            Player player = new Player(100);

            Zoo zoo = new Zoo();

            Visitor Alice = new Child("Alice");
            Visitor Bob = new Child("Bob");
            Visitor Wilson = new Adult("Wilson");
            Visitor Helen = new Adult("Helen");

            zoo.AddVisitors(Helen);
            zoo.AddVisitors(Wilson);
            zoo.AddVisitors(Alice);
            zoo.AddVisitors(Bob);

            // Create some animals
            Mammal lion = new Lion("Leo");
            Bird parrot = new Parrot("Polly");
            Reptile snake = new Snake("Sly");

            // Add animals to the zoo
            zoo.AddAnimal(lion);
            zoo.AddAnimal(parrot);
            zoo.AddAnimal(snake);


            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to the Zoo Management Game!");
                Console.WriteLine("1. Open Zoo for the Day");
                Console.WriteLine("2. Buy an Animal from Supplier");
                Console.WriteLine("3. Sell an Animal to Customer");
                Console.WriteLine("4. Check Balance and Inventory");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        zoo.OpenForDay(player);
                        break;
                    case 2:
                        zoo.BuyAnimalFromSupplier(player);
                        break;
                    case 3:
                        zoo.SellAnimalToCustomer(player);
                        break;
                    case 4:
                        zoo.CheckBalanceAndInventory(player);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting the game. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
