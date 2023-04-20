using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Foe loki = new Foe("Loki");

            loki.SetName("   Grindalokki   ");

            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");
            
        }
    }
}
