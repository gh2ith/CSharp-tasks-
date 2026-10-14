using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game started.");
            
            Warrior warrior = new Warrior("Player1", "100");
            Console.WriteLine("Player1 Joined the game!");          

            Wizard wizard = new Wizard("Player2", "100");
            Console.WriteLine("Player2 Joined the game!\n");

            List<GameCharacter> characters = new List<GameCharacter> { warrior, wizard };

            foreach (GameCharacter character in characters)
            {
                character.UseSpecialAbility();
            }

            warrior.TakeDamage(20);
            wizard.TakeDamage(30);

            warrior.Heal();
            wizard.Heal();

        }
    }
}
