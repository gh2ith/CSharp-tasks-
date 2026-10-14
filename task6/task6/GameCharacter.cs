using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal abstract class GameCharacter
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health  = 100;

        public int Health1
        {
            get { return Health; }
            set {

                if (value >= 0 && value <= 100) {
                    Health1 = value;
                }   

                    else
                    {
                        Console.WriteLine("Health cannot be negative.");
                    }

                }
            } 



        public GameCharacter(string name, string health)
        {
            this._name = name;
            this.Health = int.Parse(health);
        }
        public abstract void UseSpecialAbility();

        public virtual int TakeDamage(int damage)
        {
            Health = Health - damage;
            return Health;
        }

        public int Heal()
        {
            Health = Health + 10;
            if (Health > 100)
            {
                Health = 100;
            }
            Console.WriteLine($"Healed by 10. Health is now {Health}.");
            return Health;
        }
        public int Heal(int amount)
        {
            Health = Health + amount;
            if (Health > 100)
            {
                Health = 100;
                Console.WriteLine("Health cannot exceed 100, setting to 100.");
            }
            Console.WriteLine($"Healed by {amount}. Health is now {Health}.");
            return Health;
        }


    }
}
