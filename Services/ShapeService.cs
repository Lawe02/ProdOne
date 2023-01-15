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
            Shape s = new();
            var x = new Shape();
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
    }
}
