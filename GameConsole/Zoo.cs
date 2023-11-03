namespace GameConsole
{
    public class Zoo
    {
        private List<Animal> _animals;
        private List<Visitor> _visitors;

        public Zoo()
        {
            _animals = new List<Animal>(); // Initialize the animals list
            _visitors = new List<Visitor>(); // Initialize the visitors list
        }

        public void OpenForDay(Player player)
        {
            Console.WriteLine("The zoo is now open for the day!");

            // Simulate visitors coming to the zoo
            foreach (Visitor visitor in _visitors)
            {
                InteractWithAnimals(player, visitor);
            }
        }

        private void InteractWithAnimals(Player player, Visitor visitor)
        {
            Random random = new Random();
            int index = random.Next(_animals.Count);
            Animal animal = _animals[index];

            // Interact with the animal
            animal.Interact();

            // Visitor interaction
            visitor.Interact(player);
        }

        public List<Animal> GetAnimalsForSale()
        {
            // This method returns only the animals that are available for sale
            List<Animal> availableAnimals = new List<Animal>();
            foreach (Animal animal in _animals)
            {
                if (animal.IsAvailableForSale)
                {
                    availableAnimals.Add(animal);
                }
            }
            return availableAnimals;
        }

        public void AddVisitors(Visitor visitor)
        {
            _visitors.Add(visitor);
        }

        public void BuyAnimalFromSupplier(Player player)
        {
            List<Animal> animalsForSale = GetAnimalsForSale();
            Console.WriteLine("Animals available for purchase from supplier:");
            foreach (Animal animal in animalsForSale)
            {
                Console.WriteLine($"{animal.Name} - {animal.Price} coins");
            }
            Console.Write("Select the animal you want to buy: ");
            int selected = int.Parse(Console.ReadLine()) - 1;
            if (selected >= 0 && selected < animalsForSale.Count)
            {
                Animal animalToBuy = animalsForSale[selected];
                if (player.Money >= animalToBuy.Price)
                {
                    _animals.Add(animalToBuy);
                    player.Money -= animalToBuy.Price;
                    Console.WriteLine($"You bought a {animalToBuy.Name} for {animalToBuy.Price} coins.");
                }
                else
                {
                    Console.WriteLine("Not enough money to buy this animal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        public void SellAnimalToCustomer(Player player)
        {
            Console.WriteLine("Animals available to sell to customers:");
            int i = 0;
            foreach (Animal animal in _animals)
            {
                i += 1;
                Console.WriteLine($"{i}.{animal.Name} - {animal.Price} coins");
            }
            Console.Write("Select the animal you want to sell: ");
            int selected = int.Parse(Console.ReadLine()) - 1;
            if (selected >= 0 && selected < _animals.Count)
            {
                Animal animalToSell = _animals[selected];
                _animals.RemoveAt(selected);
                player.Money += animalToSell.Price;
                Console.WriteLine($"You sold a {animalToSell.Name} for {animalToSell.Price} coins.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        public void CheckBalanceAndInventory(Player player)
        {
            Console.WriteLine($"Your balance: {player.Money} coins");
            Console.WriteLine("Animals in the zoo:");
            for (int i = 0; i < _animals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_animals[i].Name}");
            }
        }

        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                _animals.Add(animal);
                Console.WriteLine($"{animal.Name} has been added to the zoo!");
            }
            else
            {
                Console.WriteLine("Invalid animal. Cannot add to the zoo.");
            }
        }
    }
}
