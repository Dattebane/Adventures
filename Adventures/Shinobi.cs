using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures
{
    class Shinobi
    {
        // properties
        private string name;
        private int age;
        private int x;
        private int y;
        private int z;
        private int width;
        private int depth;
        private int height;
        Location location;


        // constructors
        public Shinobi()
        {
            Console.WriteLine("A new shinobi has entered the battlefield!");
        }
        public Shinobi(string name)
        {
            Console.WriteLine("{0} has entered the battlefield!", name);
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
        public int getWidth()
        {
            return width;
        }
        public int getDepth()
        {
            return depth;
        }
        public int getHeight()
        {
            return height;
        }
        public Location getLocation()
        {
            return this.location;
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
        public void setHeight(int height)
        {
            this.width = 10;
            this.depth = 10;
            this.height = height;
        }
        public void setCoor(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Actions
        public void enter()
        {
            Console.WriteLine("{0} has entered the battlefield!", this.name);
        }
        public void exit()
        {
            Console.WriteLine("{0} has left the battlefield!", this.name);
        }
    }
}
