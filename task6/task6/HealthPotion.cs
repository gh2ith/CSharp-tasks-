using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class HealthPotion : ICollectible
    {

        public int PotionName { get; set; }
        public void Collect()
        {
            Console.WriteLine("Health potion collected! Health restored.");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);
                character.Heal(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"number is invalid: {ex.Message}");
            }
        }
    }
}
