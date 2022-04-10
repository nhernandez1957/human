using System;

namespace human
{
    public class Wizard : Character
    {
    // Constructor for Wizard
        public Wizard(string n) : base(n, 3, 25, 75, 50) {}
    
    
    // Methods for Wizard
        public void Attack(Character target)
        {
            Console.WriteLine($"{this.Name} attacked {target.Name}.");
            target.Health -= 5 * target.Intelligence;
            this.Health += 5 * target.Intelligence;
            Console.WriteLine($"{target.Name} was hit with Super Thought. {target.Name} now has {target.Health}.");
            Console.WriteLine($"{this.Name} gained {5 * target.Intelligence} health. {this.Name} now has {this.Health} health.");
        }

        public void Heal(Character target)
        {
            int amount = target.Intelligence * 10;
            Console.WriteLine($"{this.Name} healed {target.Name} with Regeneration.");
            target.Health += amount;
            Console.WriteLine($"{target.Name}'s health is now {target.Health}.");
        }
    }
}