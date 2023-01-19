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
                Console.Clear();
                Console.WriteLine("Ange 1 för Romb");
                Console.WriteLine("Ange 2 för Rektangel");
                Console.WriteLine("Ange 3 för Paralellogram");
                Console.WriteLine("Ange 4 för Triangel");
                Console.WriteLine("Ange 5 för att gå tillbaka");
                Console.WriteLine("Ange 6 för att ta bort shape");
                Console.WriteLine("Ange 7 för att uppdatera shape");
                Console.WriteLine("Ange 8 för att se alla former");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            var s = _shapeService.AddShape(1);
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

                        case 6:
                            _shapeService.ReadShapes(_context);
                            var shapeToRemove = _shapeService.ReturnShape(_context);
                            _context.Shapes.Remove(shapeToRemove);
                            _context.SaveChanges();
                            break;
                        
                        case 7:
                            _shapeService.ReadShapes(_context);
                            var shapeToUpdate = _shapeService.ReturnShape(_context);
                            shapeToUpdate = _shapeService.UpdateShape(shapeToUpdate);
                            _context.SaveChanges();
                            break;

                        case 8:
                            _shapeService.ReadShapes(_context);
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void CalcMenu()
        {
            while (true)
            {
                Console.WriteLine("Ange 1 för addition");
                Console.WriteLine("Ange 2 för subtraktion");
                Console.WriteLine("Ange 3 för division");
                Console.WriteLine("Ange 4 för multiplikation");
                Console.WriteLine("Ange 5 för roten");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                }
                catch(Exception ex)
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
