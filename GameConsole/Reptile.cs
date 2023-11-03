namespace GameConsole
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name, 20, true)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, a reptile, hisses!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} suns itself on a rock after eating.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} slithers through an obstacle course.");
        }
    }
}
