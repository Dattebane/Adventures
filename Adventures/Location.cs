using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures
{
    class Location
    {
        string name;
        int occupancy = 0;
        static int length, width, height;
        object[,,] space = new object[length, width, height];
        List<Shinobi> occupants = new List<Shinobi>();
        List<Location> rooms = new List<Location>();

        // Constructors
        public Location()
        {
            name = "unknown location";
            occupancy = 0;
        }
        public Location(string name)
        {
            this.name = name;
            occupancy = 0;
        }
        public Location(string name, int x, int y, int z)
        {
            this.name = name;
            length = x;
            width = y;
            height = z;
            space = new object[x, y, z];
        }
        public Location(string name, int x, int y, int z, int occ)
        {
            this.name = name;
            length = x;
            width = y;
            height = z;
            occupancy = occ;
            space = new object[x, y, z];
        }

        // Population Methods
        public void place(Shinobi shinobi, int x, int y, int z)
        {
            bool placed = false;
            for (int w = x; w <= x + shinobi.getWidth() - 1; w++)
            {
                for (int d = y; d <= y + shinobi.getDepth() - 1; d++)
                {
                    for (int h = z; h <= z + shinobi.getHeight() - 1; h++)
                    {
                        //Console.WriteLine(space[w, d, h]);
                        if (space[w, d, h] == null)
                        {
                            space[w, d, h] = shinobi;
                            shinobi.setCoor(x, y, z);
                            placed = true;
                        }
                        else
                        {
                            placed = false;
                        }

                    }
                }
            }
            if (!placed)
            {
                Console.WriteLine("There's no space for that!");
            }
            else
            {
                Console.WriteLine("Shinobi placed at {0}, {1}, {2}.", x, y, z);
            }
        }

        //getters
        public string getName()
        {
            return name;
        }
        public void showTop()
        {
            Console.WriteLine();
            Console.WriteLine("      Top View of: {0}", name);

            Console.WriteLine("      ---------------------------------------------------------------X-Axis--------------------------------------------------->");
            Console.Write("      "); // buffer
            for (int x = 0; x < length; x++)
            {
                if (x <= 9)
                {
                    Console.Write(" {0} ", x);
                }
                else
                {
                    Console.Write("{0} ", x);
                }
            }
            Console.WriteLine();

            string place = "*";
            for (int y = 0; y < width; y++) //each row
            {
                if (y <= 9 && y < width - 1 && (y != (width / 2) && y != (width / 2) + 1 && y != (width / 2) - 2 && y != (width / 2) + 2 && y != (width / 2) + 3))
                {
                    Console.Write(" |  {0} ", y);
                }
                else if (y > 9 && y < width - 1 && (y != (width / 2) && y != (width / 2) + 1 && y != (width / 2) - 2 && y != (width / 2) + 2 && y != (width / 2) + 3))
                {
                    Console.Write(" | {0} ", y);
                }
                else if (y > 9 && y < width - 1 && y == (width / 2) - 2)
                {
                    Console.Write(" Y {0} ", y);
                }
                else if (y > 9 && y < width - 1 && y == (width / 2))
                {
                    Console.Write(" A {0} ", y);
                }
                else if (y > 9 && y < width - 1 && y == (width / 2) + 1)
                {
                    Console.Write(" x {0} ", y);
                }
                else if (y > 9 && y < width - 1 && y == (width / 2) + 2)
                {
                    Console.Write(" i {0} ", y);
                }
                else if (y > 9 && y < width - 1 && y == (width / 2) + 3)
                {
                    Console.Write(" s {0} ", y);
                }
                else if (y >= width - 1)
                {
                    Console.Write(" v {0} ", y);
                }
                for (int x = 0; x < length; x++) // each colomn
                {
                    //Console.Write("The length is " + Convert.ToString(length));
                    for (int z = height - 1; z >= 0; z--)
                    {
                        if (space[x, y, z] != null)
                        {
                            place = " ";
                            break;
                        }
                        else
                        {
                            place = "*";
                        }
                    }
                    Console.Write("[{0}]", place);
                }
                Console.WriteLine();
            }

        }
        public void showRight()
        {

            Console.WriteLine();
            Console.WriteLine("      Right View of: {0}", name);
            string place = "*";
            Console.WriteLine();

            for (int z = height - 1; z >= 0; z--) //each row
            {
                for (int y = width - 1; y >= 0; y--) // each colomn
                {
                    //Console.Write("The length is " + Convert.ToString(length));
                    for (int x = length - 1; x >= 0; x--)
                    {
                        if (space[x, y, z] != null)
                        {
                            place = " ";
                            break;
                        }
                        else
                        {
                            place = "*";
                        }
                    }
                    Console.Write("[{0}]", place);
                }

                if (z <= 9 && z < width - 1 && (z != (width / 2) && z != (width / 2) + 1 && z != (width / 2) - 2 && z != (width / 2) - 1 && z != (width / 2) + 3))
                {
                    Console.Write(" {0}  |", z);
                }
                else if (z > 9 && z < width - 1 && (z != (width / 2) && z != (width / 2) + 1 && z != (width / 2) - 2 && z != (width / 2) - 1 && z != (width / 2) + 3))
                {
                    Console.Write(" {0} |", z);
                }
                else if (z > 9 && z < width - 1 && z == (width / 2) - 2)
                {
                    Console.Write(" {0} s  ", z);
                }
                else if (z > 9 && z < width - 1 && z == (width / 2) - 1)
                {
                    Console.Write(" {0} i  ", z);
                }
                else if (z > 9 && z < width - 1 && z == (width / 2) + 0)
                {
                    Console.Write(" {0} x  ", z);
                }
                else if (z > 9 && z < width - 1 && z == (width / 2) + 1)
                {
                    Console.Write(" {0} A  ", z);
                }
                else if (z > 9 && z < width - 1 && z == (width / 2) + 3)
                {
                    Console.Write(" {0} Z  ", z);
                }
                else if (z >= height - 1)
                {
                    Console.Write(" {0} ^  ", z);
                }
                Console.WriteLine();
            }


            for (int y = width - 1; y >= 0; y--)
            {
                if (y <= 9)
                {
                    Console.Write(" {0} ", y);
                }
                else
                {
                    Console.Write("{0} ", y);
                }
            }


            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------------------------Y-Axis-------------------------------------------------------");

        }

    }
}