using System;

namespace human
{
    public class Samurai : Character
    {
        public Samurai(string n) : base(n, 8, 12, 125, 200) {}

        public void Attack(Character target)
        {
            if(target.Health > 50)
            {
                Console.WriteLine($"{this.Name} used Killing Blow. That delivered a lot of damage.");
                int dmg = this.Strength * 3;
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
            } else {
                Console.WriteLine($"{this.Name} used Killing Blow. {target.Name} was destroyed.");
                target.Health = 0;
            }
        }

        public void Meditate()
        {
            this.Health = 200;
            Console.WriteLine($"{this.Name} used Mediate. {this.Name}'s health is now {this.Health}"); 
        }
    }
}