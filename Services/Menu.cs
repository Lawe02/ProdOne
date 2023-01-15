using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;
using ProjectOne.Services;

namespace ProjectOne.Services
{
    public class Menu
    {
        private readonly ApplicationDbContext _context;
        private readonly shapeService _shapeService;
        public Menu(ApplicationDbContext dbContext, shapeService service)
        {
            _context = dbContext;
            _shapeService = service;
        }
        public void ShapeMenu()
        {
            while (true)
            {
                Console.WriteLine("Ange 1 för Romb");
                Console.WriteLine("Ange 2 för Rektangel");
                Console.WriteLine("Ange 3 för Paralellogram");
                Console.WriteLine("Ange 4 för Triangel");
                Console.WriteLine("Ange 5 för att gå tillbaka");

                try
                {
                    var s = new Shape();
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            s = _shapeService.AddShape(1);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 2:
                            s = _shapeService.AddShape(2);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 3:
                            s = _shapeService.AddShape(3);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 4:
                            s = _shapeService.AddShape(4);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 5:
                            MainMenu();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Ange 1 för att komma till shapeMenu");
                Console.WriteLine("Ange 2 för att komma till kalkylatorMenu");
                Console.WriteLine("Ange 3 för att komma till StenSaxPåseMenu");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            ShapeMenu();
                            break;

                        case 2:
                            break;

                        case 3:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
