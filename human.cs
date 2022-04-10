using System;

namespace human
{
    public class Human
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
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string n)
        {
            Name = n;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            health = h;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
            return target.health;
        }
    }
}
