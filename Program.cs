using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja n1 = new Ninja("Nicholas");
            // n1.showSats();

            Wizard w1 = new Wizard("Bobbothy");
            // w1.showSats();

            Samurai s1 = new Samurai("Ezio");
            // s1.showSats();

            // w1.Attack(s1);
            // s1.Meditate();
            // s1.Attack(w1);
            s1.Attack(n1);
            s1.Attack(n1);
            s1.Attack(n1);
            s1.Attack(n1);
        }
    }
}


