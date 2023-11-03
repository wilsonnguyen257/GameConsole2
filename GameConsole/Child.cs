namespace GameConsole
{
    public class Child : Visitor
    {
        public Child(string name) : base(name) { }

        public override void Interact(Player player)
        {
            Console.WriteLine($"{Name} is amazed by the animals and learns a lot!");
            player.Money += 3; // Increase player's money for interaction
            Console.WriteLine("+3 coins.\n");
        }
    }

}
