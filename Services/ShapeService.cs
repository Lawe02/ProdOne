using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;

namespace ProjectOne.Services
{
    public class shapeService
    {
        public Shape AddShape(int sel)
        {

            var x = new Shape();
            Shape s;
            switch (sel)
            {
                case 1:
                    s = new Romb();
                    s.GetParams();
                    x = new Romb() { Area = s.Area, Circumference = s.Circumference, CreateDate = s.CreateDate, Form = s.Form };

                    break;

                case 2:
                    s = new Rectangel();
                    s.GetParams();
                    x = new Rectangel() { Area = s.Area, Circumference = s.Circumference, CreateDate = s.CreateDate, Form = s.Form };

                    break;

                case 3:
                    s = new Paralellogram();
                    s.GetParams();
                    x = new Paralellogram() { Area = s.Area, Circumference = s.Circumference, CreateDate = s.CreateDate, Form = s.Form };

                    break;

                case 4:
                    s = new Triangel();
                    s.GetParams();
                    x = new Triangel() { Area = s.Area, Circumference = s.Circumference, CreateDate = s.CreateDate, Form = s.Form };

                    break;
            }

            return x;
        }
        public Shape ReturnShape(ApplicationDbContext db)
        {
            var shape = new Shape();
            while (true)
            {
                Console.WriteLine("Ange Id");
                if (int.TryParse(Console.ReadLine(), out var id))
                {
                    shape = db.Shapes.FirstOrDefault(x => x.Id == id);

                    if (shape != null)
                        break;
                    else
                        Console.WriteLine("Ange ett id som existerar tack");
                }
                else
                    Console.WriteLine("Ange ett Id som existerar");
            }
            return shape;
        }

        public Shape UpdateShape(Shape shape)
        {
            switch (shape.Form)
            {
                case "Rätvinklig Triangel":
                    var triangel = new Triangel();
                    triangel.GetParams();
                    shape.Circumference = triangel.Circumference; shape.Area = triangel.Area; 
                    break;

                case "Romb":
                    var romb = new Romb();
                    romb.GetParams();
                    shape.Circumference = romb.Circumference; shape.Area = romb.Area;
                    break;

                case "Rectangel":
                    var rectangel = new Rectangel();
                    rectangel.GetParams();
                    shape.Circumference = rectangel.Circumference; shape.Area = rectangel.Area;
                    break;

                case "Paralellogram":
                    var paralellogram = new Paralellogram();
                    paralellogram.GetParams();
                    shape.Circumference = paralellogram.Circumference; shape.Area = paralellogram.Area;
                    break;
            }
            return shape;
        }

        public void ReadShapes(ApplicationDbContext db)
        {
            Build builder = new();
            db = builder.BuildApp();
            Console.WriteLine("----ALL SHAPES----");
            db.Shapes.ToList().ForEach(x => Console.WriteLine($"ID: {x.Id} || CREATEDATE: {x.CreateDate} || AREA: {x.Area} || CIRCUMFERENCE: {x.Circumference} || FORM: {x.Form}"));
            Console.ReadLine();
        }
    }
}
