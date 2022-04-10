using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Nicholas");

            Console.WriteLine($"I am {h1.Name}. My attributes are strength = {h1.Strength}, intelligence = {h1.Intelligence}, dexterity = {h1.Dexterity}, health = {h1.Health}.");
            
            Human h2 = new Human("Bobbothy", 5, 2, 7, 100);

            Console.WriteLine($"I am {h2.Name}. My attributes are strength = {h2.Strength}, intelligence = {h2.Intelligence}, dexterity = {h2.Dexterity}, Health = {h2.Health}.");
            
            h1.Attack(h2);
        }
    }
}


