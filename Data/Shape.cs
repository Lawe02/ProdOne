using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class Triangel : Shape
    {
        public int Id { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public string Shape =>
            "Liksidig Triangel";
        public double Area =>
            Base * Height / 2;
        public double Circumference =>
            Base * 3;
        public DateTime CreateDate => 
            DateTime.Now;
        public void GetParams()
        {
            Console.WriteLine("Ange bas");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange bas");
            Height = int.Parse(Console.ReadLine());
        }
    }

    public class Rectangel : Shape
    {
        public int Id { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public string Shape =>
            "Rektangel";
        public double Area =>
            Base * Height;

        public double Circumference =>
            Base * 2 + Height * 2;

        public DateTime CreateDate =>
            DateTime.Now;

        public void GetParams()
        {
            Console.WriteLine("Ange bas");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange höjd");
            Height = int.Parse(Console.ReadLine());
        }
    }

    public class Paralellogram : Shape
    {
        public int Id { get; set; } 
        public int Base { get; set; }
        public int Height { get; set; }
        public int ShortSide { get; set; }
        public string Form =>
            "Paralellogram";
        public DateTime CreateDate =>
            DateTime.Now;
        public double Area =>
            Base * Height;
        public double Circumference =>
            Base * 2 + Height * 2;

        public void GetParams()
        {
            Console.WriteLine("Ange långsidan");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange höjden");
            Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange kortsidan");
            ShortSide = int.Parse(Console.ReadLine());
        }

    }

    public class Romb : Shape
    {
        public int Id { get; set; }
        public int Side { get; set; }
        public DateTime CreateDate =>
            DateTime.Now;
        public double Circumference =>
            Side * 4;
        public double Area =>
            Side * Side * Math.Sqrt(2) / 2;
        public void GetParams()
        {
            Console.WriteLine("Ange sidlängd");
            Side = int.Parse(Console.ReadLine());
        }
        public string Form =>
            "Romb";

    }
}
