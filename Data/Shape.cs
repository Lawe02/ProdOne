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
        public override string Form =>
            "Rätvinklig Triangel";
        public override double Area =>
            Base * Height / 2;
        public override double Circumference =>
            Base + Height + Math.Sqrt(Base * Base + Height * Height);
        public override DateTime CreateDate => 
            DateTime.Now;
        public override void GetParams()
        {
            Console.WriteLine("Ange bas");
            Base = RetInt();
            Console.WriteLine("Ange bas");
            Height = RetInt();
        }   
    }

    public class Rectangel : Shape
    {
        public int Id { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public override string Form =>
            "Rektangel";
        public override double Area =>
            Base * Height;

        public override double Circumference =>
            Base * 2 + Height * 2;

        public override DateTime CreateDate =>
            DateTime.Now;

        public override void GetParams()
        {
            Console.WriteLine("Ange bas");
            Base = RetInt();
            Console.WriteLine("Ange höjd");
            Height = RetInt();
        }
    }

    public class Paralellogram : Shape
    {
        public int Id { get; set; } 
        public int Base { get; set; }
        public int Height { get; set; }
        public int ShortSide { get; set; }
        public override string Form =>
            "Paralellogram";
        public override DateTime CreateDate =>
            DateTime.Now;
        public override double Area =>
            Base * Height;
        public override double Circumference =>
            Base * 2 + Height * 2;

        public override void GetParams()
        {
            Console.WriteLine("Ange långsidan");
            Base = RetInt();
            Console.WriteLine("Ange höjden");
            Height = RetInt();
            Console.WriteLine("Ange kortsidan");
            ShortSide = RetInt();
        }

    }

    public class Romb : Shape
    {
        public override int Id { get; set; }
        public int Side { get; set; }
        public override DateTime CreateDate =>
            DateTime.Now;
        public override double Circumference =>
            Side * 4;
        public override double Area =>
            Side * Side * Math.Sqrt(2) / 2;
        public override void GetParams()
        {
            Console.WriteLine("Ange sidlängd");
            Side = RetInt();
        }
        public override string Form =>
            "Romb";

    }
}
