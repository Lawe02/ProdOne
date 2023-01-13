using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class DataInitializer
    {
        public void AddShapes(ApplicationDbContext db)
        {
            if(!db.Shapes.Any(x => x.Id == 41))
            {
                db.Shapes.Add(new Paralellogram()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Paralellogram"
                });              
            }
            if (!db.Shapes.Any(x => x.Id == 42))
            {
                db.Shapes.Add(new Romb()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Romb"
                });
            }
            if (!db.Shapes.Any(x => x.Id == 43))
            {
                db.Shapes.Add(new Triangel()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Tiangel"
                });
            }
            if (!db.Shapes.Any(x => x.Id == 44))
            {
                db.Shapes.Add(new Rectangel()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Rectangel"
                });
            }
        }
    }
}
