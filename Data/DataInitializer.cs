using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _context;
        public DataInitializer(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public void AddShapes()
        {
            if(!_context.Shapes.Any(x => x.Id == 41))
            {
                _context.Shapes.Add(new Paralellogram()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Paralellogram"
                });              
            }
            if (!_context.Shapes.Any(x => x.Id == 42))
            {
                _context.Shapes.Add(new Romb()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Romb"
                });
            }
            if (!_context.Shapes.Any(x => x.Id == 43))
            {
                _context.Shapes.Add(new Triangel()
                {
                    Circumference = 3,
                    CreateDate = DateTime.Now,
                    Area = 8,
                    Form = "Tiangel"
                });
            }
            if (!_context.Shapes.Any(x => x.Id == 44))
            {
                _context.Shapes.Add(new Rectangel()
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
