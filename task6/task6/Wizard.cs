using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, string health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("\nThe wizard uses a powerful spell!\n");
        }

        public override int TakeDamage(int damage)
        {
            Health = Health - damage;
            Console.WriteLine($"The wizard takes {damage} damage. Health is now {Health}.\n");
            return Health;
        }   
            

    }
}
