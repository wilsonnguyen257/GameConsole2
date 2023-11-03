namespace GameConsole
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name, 50, true)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, a mammal, growls!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} eats a hearty meal.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} plays with a ball to the delight of visitors.");
        }
    }
}
