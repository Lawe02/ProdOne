using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Services
{
    public class Menu
    {
        public int ShapeMenu()
        {
            Console.WriteLine("Ange 1 för Romb");
            Console.WriteLine("Ange 2 för Rektangel");
            Console.WriteLine("Ange 3 för Paralellogram");
            Console.WriteLine("Ange 4 för Triangel");

            int choise = int.Parse(Console.ReadLine());
            return choise;
        }
    }
}
