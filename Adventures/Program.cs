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
            Console.WriteLine("Oh! Hello there! My name is Zigzo. What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("{0} is it? That's a weird name... You're not from around here, are you? How old are you anyway?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're {0}, huh?", age);
            
            Console.ReadLine();
        }
    }
}
