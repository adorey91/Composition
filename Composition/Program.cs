using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Composition");
            Console.WriteLine();

            // declaration
            // instantiation
            Player player = new Player();
            Enemy enemy = new Enemy();


            Console.WriteLine("Player Health: " + player.healthSystem.health);
            Console.WriteLine("Enemy Health: " + enemy.healthSystem.health);
            Console.WriteLine(); 

            player.healthSystem.TakeDamage(25);
            enemy.healthSystem.TakeDamage(30);

            Console.WriteLine("Player Health: " + player.healthSystem.health);
            Console.WriteLine("Enemy Health: " + enemy.healthSystem.health);
            Console.WriteLine();

            player.healthSystem.Heal(10);
            enemy.healthSystem.Heal(20);

            Console.WriteLine("Player Health: " + player.healthSystem.health);
            Console.WriteLine("Enemy Health: " + enemy.healthSystem.health);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey(true);
        }
    }
}
