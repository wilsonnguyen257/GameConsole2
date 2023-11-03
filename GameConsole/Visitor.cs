namespace GameConsole
{
    public class Visitor : LivingBeing, IInteractable
    {
        public Visitor(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: 'Hello!'");
        }

        public virtual void Interact(Player player)
        {
            Console.WriteLine($"{Name} enjoys their visit to the zoo.");
            player.Money += 1; // Increase player's money for interaction
            Console.WriteLine("+1 coins.\n");
        }
    }
}
