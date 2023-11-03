using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Snake : Reptile
    {
        public Snake(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name}, the snake, hisses softly!");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} swallows its food whole.");
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} fascinates the visitors with its slithering movements.");
        }
    }
}

