using GameConsole;
using System.Xml.Linq;

namespace GameConsole
{
    public class Adult : Visitor
    {
        public Adult(string name) : base(name) { }

        public override void Interact(Player player)
        {
            Console.WriteLine($"{Name} appreciates the zoo's conservation efforts and makes a donation.");
            player.Money += 7; // Increase player's money for interaction
            Console.WriteLine("+7 coins.\n");
        }
    }
}