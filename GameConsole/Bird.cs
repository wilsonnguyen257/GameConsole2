namespace GameConsole
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name, 30, true)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, a bird, chirps!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} pecks at some seeds.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} flutters around playfully.");
        }
    }
}
