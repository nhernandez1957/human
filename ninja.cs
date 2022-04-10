using System;

namespace human
{
    public class Ninja : Character
    {
        public Ninja(string n) : base(n, 6, 17, 175, 100) {}

        public void Attack(Character target)
        {
            int attack = 5 * target.Dexterity;
            target.Health -= attack;
            Console.WriteLine($"{this.Name} used Dexterity Destroyer. {target.Name} now has {target.Health} health left.");
            Random randAttack = new Random();
            double chance = randAttack.Next(0, 100);
            Console.WriteLine(chance);
            if(chance > 80)
            {
                target.Health -= 10;
                Console.WriteLine($"{target.Name} lost an additional 10 health on a lucky strike.");
            }
        }

        public void Steal(Character target)
        {
            target.Health -= 5;
            this.Health += 5;
            Console.WriteLine($"{this.Name} used Steal. {this.Name}'s health is now {this.Health}.");
            Console.WriteLine($"{target.Name}'s health is now {target.Health}.");
        }
    }
}