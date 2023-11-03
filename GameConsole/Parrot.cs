namespace GameConsole
{
    public class Parrot : Bird
    {
        public Parrot(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, the parrot, talks!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} eats seeds and nuts.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} entertains the visitors by mimicking their words.");
        }
    }
}
