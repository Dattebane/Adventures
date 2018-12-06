using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just getting my bearings here...
            drawValley(36);
            Console.ReadLine();

            Shinobi player = new Shinobi();
            Console.ReadLine();

            Console.WriteLine("Oh! Hello there! My name is Zigzo. What's your name?");
            player.setName(Console.ReadLine());

            Console.WriteLine("{0} is it? That's a weird name... You're not from around here, are you? How old are you anyway?", player.getName());
            player.setAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("You're {0}, huh?", player.getAge());
            Location Konoha = new Location("Konoha", 40, 40, 40);
            player.setHeight(10);
            Konoha.place(player, 0,0,0);
            Konoha.place(player, 0, 0, 10);
            //Konoha.place(player, 0, 0, 9);
            Konoha.showTop();
            Konoha.showRight();




            Console.ReadLine();
        }
        static void drawValley(int n)
        {
            for(int i = 0; i <= n; i++) //each row
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < ((2 * n) - (2 * i)); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
