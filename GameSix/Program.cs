using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of enemies: ");
            int nEnemies = Convert.ToInt32(Console.ReadLine());

            Foe[] enemies = new Foe[nEnemies];

            for (int i = 0; i< nEnemies; i++)
            {
                Console.Write($"Name of Enemies {i+1}: ");
                string name = Console.ReadLine();

                enemies[i] = new Foe(name);

            }

            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine(enemies[i].GetName());
            }


            Console.WriteLine(Foe.PowerUpCount);

            Console.WriteLine("Obrigado por ter usado este programa!");

            Console.WriteLine("Merci d’utiliser ce programme!");


            
        }


    }
}
