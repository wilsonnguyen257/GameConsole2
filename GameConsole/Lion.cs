using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Lion : Mammal
    {
        public Lion(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, the lion, roars!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} eats meat.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} impresses the visitors with its majestic mane.");
        }
    }
}
