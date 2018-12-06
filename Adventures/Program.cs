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
            Shinobi player = new Shinobi();
            Console.WriteLine("Oh! Hello there! My name is Zigzo. What's your name?");
            player.setName(Console.ReadLine());
            Console.WriteLine("{0} is it? That's a weird name... You're not from around here, are you? How old are you anyway?", player.getName());
            player.setAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You're {0}, huh?", player.getAge());
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
        class Shinobi
        {

            // properties
            private string name;
            private int age;
            public Shinobi()
            {
                Console.WriteLine("A new shinobi has entered the battlefield");
            }
            // getters
            public string getName()
            {
                return name;
            }
            public int getAge()
            {
                return age;
            }

            // setters
            public void setName(string name)
            {
                this.name = name;
            }
            public void setAge(int age)
            {
                this.age = age;
            }
        }
    }
}
