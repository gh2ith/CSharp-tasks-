using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Warrior : GameCharacter
    {
        public Warrior(string name, string health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("Player1 uses special ability!");
        }



        public override int TakeDamage(int damage)
        {
            Health = Health - (damage-2) ;

            Console.WriteLine($"Player1 takes {damage} damage, but has a shield that reduces damage by 2. Health is now {Health}.");
            return Health;
        }

    }
}
