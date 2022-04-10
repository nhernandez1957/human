using System;

namespace human
{
    public class Character
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Character(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            health = h;
        }

        // Build Attack method
        public int Attack(Character target, int amount)
        {
            int dmg = amount;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
            return target.health;
        }

        public void showSats()
        {
            Console.WriteLine($"Name:           {this.Name}");
            Console.WriteLine($"Strength:       {this.Strength}");
            Console.WriteLine($"Intelligence:   {this.Intelligence}");
            Console.WriteLine($"Dexterity:      {this.Dexterity}");
            Console.WriteLine($"Health:         {this.Health}");
        }
    }
}
